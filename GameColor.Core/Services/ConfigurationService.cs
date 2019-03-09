using GameColor.Core.Constants;
using GameColor.Core.Helpers;
using GameColor.Core.Interfaces;
using GameColor.Core.Models;
using Gma.System.MouseKeyHook;
using Microsoft.Win32;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace GameColor.Core.Services
{
    public class ConfigurationService : IConfigurationService
    {
        #region Fields
        private readonly string _tempPath;
        private readonly string _applicationExecutablePath;

        private readonly IUserLoggingService _userLoggingService;
        private readonly IUserPresetService _userPresetService;
        private readonly IGamePresetService _gamePresetService;
        private readonly IKeyboardMouseEvents _hooks;

        #endregion

        #region Constructor
        public ConfigurationService(string applicationExecutablePath, IUserPresetService userPresetService, IGamePresetService gamePresetService, IUserLoggingService userLoggingService)
        {
            _applicationExecutablePath = applicationExecutablePath;

            _userPresetService = userPresetService;
            _gamePresetService = gamePresetService;
            _userLoggingService = userLoggingService;

            _tempPath = Path.GetTempPath();

            _hooks = Hook.GlobalEvents();

            _hooks.KeyUp += GlobalHookKeyUp;
            _hooks.MouseDownExt += GlobalHookMouseDownExt;
        }
        #endregion

        #region Public Methods
        public Configuration GetCurrentConfiguration() =>
            DeserializeConfigurationFile();
        public void SetDefaultConfiguration(bool reset = false)
        {
            if (reset)
                SetConfiguration(new Configuration());
            else if (!File.Exists($"{_tempPath}/{ConfigurationFile.CONFIG_FILE_NAME}.json"))
                SetConfiguration(new Configuration());
            else
                ApplyCurrentConfigurations(true);
        }
        public void DisposeConfigurations()
        {
            _hooks.Dispose();
        }
        public void SetConfiguration(Configuration configuration) =>
            File.WriteAllText($"{_tempPath}/{ConfigurationFile.CONFIG_FILE_NAME}.json", configuration.ToString());
        public void ApplyCurrentConfigurations(bool isStartup = false)
        {
            var configuration = DeserializeConfigurationFile();

            if (!isStartup)
            {
                if (configuration.StartWithWindows != null && configuration.StartWithWindows.Enabled)
                {
                    Registry.CurrentUser
                            .OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true)
                            .SetValue(ConfigurationFile.REGISTER_APPLICATION_NAME, $"{_applicationExecutablePath} {MainArgs.IS_WIN_INITIALIZATION}");
                }
                else Registry.CurrentUser
                             .OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true)
                             .DeleteValue(ConfigurationFile.REGISTER_APPLICATION_NAME, false);
            }
        }
        #endregion

        #region Private Methods
        private Configuration DeserializeConfigurationFile()
        {
            if (File.Exists($"{_tempPath}/{ConfigurationFile.CONFIG_FILE_NAME}.json"))
            {
                var rawFile = File.ReadAllText($"{_tempPath}/{ConfigurationFile.CONFIG_FILE_NAME}.json");
                try
                {
                    return JsonConvert.DeserializeObject<Configuration>(rawFile);
                }
                catch
                {
                    SetDefaultConfiguration(true);
                    rawFile = File.ReadAllText($"{_tempPath}/{ConfigurationFile.CONFIG_FILE_NAME}.json");
                    return JsonConvert.DeserializeObject<Configuration>(rawFile);
                }
            }

            return null;
        }

        private void GlobalHookKeyUp(object sender, KeyEventArgs e)
        {
            var config = GetCurrentConfiguration();
            var combination = e.Serialize();

            if (!_gamePresetService.IsRunning())
            {
                if (config.Shortcuts.TurnOnRed == combination)
                    _userPresetService.ToggleRed();
                if (config.Shortcuts.TurnOnGreen == combination)
                    _userPresetService.ToggleGreen();
                if (config.Shortcuts.TurnOnBlue == combination)
                    _userPresetService.ToggleBlue();
                if (config.Shortcuts.TurnOff == combination)
                    _userPresetService.ToggleColor(false, false, false);
            }
        }

        private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {
            var config = GetCurrentConfiguration();
            var combination = MouseEvents.MOUSE_RIGHT_CLICK_EVENT;

            if(!_gamePresetService.IsRunning())
            {
                if (config.Shortcuts.TurnOnRed == combination)
                    _userPresetService.ToggleRed();
                if (config.Shortcuts.TurnOnGreen == combination)
                    _userPresetService.ToggleGreen();
                if (config.Shortcuts.TurnOnBlue == combination)
                    _userPresetService.ToggleBlue();
                if (config.Shortcuts.TurnOff == combination)
                    _userPresetService.ToggleColor(false, false, false);
            }
        }
        #endregion
    }
}
