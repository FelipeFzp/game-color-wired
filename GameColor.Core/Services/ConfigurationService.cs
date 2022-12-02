using GameColor.Core.Constants;
using GameColor.Core.Helpers;
using GameColor.Core.Interfaces;
using GameColor.Core.Models;
using Gma.System.MouseKeyHook;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        private readonly ICommunicationService _communicationService;
        private readonly IKeyboardMouseEvents _hooks;

        #endregion

        #region Constructor
        public ConfigurationService(
            string applicationExecutablePath, 
            IUserPresetService userPresetService, 
            IGamePresetService gamePresetService, 
            IUserLoggingService userLoggingService,
            ICommunicationService communicationService)
        {
            _applicationExecutablePath = applicationExecutablePath;

            _userPresetService = userPresetService;
            _gamePresetService = gamePresetService;
            _userLoggingService = userLoggingService;
            _communicationService = communicationService;

            _tempPath = Path.GetTempPath();

            _hooks = Hook.GlobalEvents();
            _hooks.KeyUp += GlobalHookKeyUp;
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
            if (string.IsNullOrEmpty(_communicationService.GetBindedPort())) return;

            var config = GetCurrentConfiguration();
            var combination = e.SerializeToString();

            _userLoggingService.LogLine(e.KeyCode.ToString());

            if (_gamePresetService.IsRunning())
                return;

            var combinationDictionary = new Dictionary<string, Action>();


            const int INC_DEC_STEP = 15;
            if (config.Shortcuts.IncrementRed != null)
                combinationDictionary.Add(config.Shortcuts.IncrementRed, () => _userPresetService.SetRed(INC_DEC_STEP, true));

            if (config.Shortcuts.DecrementRed != null)
                combinationDictionary.Add(config.Shortcuts.DecrementRed, () => _userPresetService.SetRed(-INC_DEC_STEP, true));

            if (config.Shortcuts.IncrementGreen != null)
                combinationDictionary.Add(config.Shortcuts.IncrementGreen, () => _userPresetService.SetGreen(INC_DEC_STEP, true));

            if (config.Shortcuts.DecrementGreen != null)
                combinationDictionary.Add(config.Shortcuts.DecrementGreen, () => _userPresetService.SetGreen(-INC_DEC_STEP, true));

            if (config.Shortcuts.IncrementBlue != null)
                combinationDictionary.Add(config.Shortcuts.IncrementBlue, () => _userPresetService.SetBlue(INC_DEC_STEP, true));

            if (config.Shortcuts.DecrementBlue != null)
                combinationDictionary.Add(config.Shortcuts.DecrementBlue, () => _userPresetService.SetBlue(-INC_DEC_STEP, true));

            if (config.Shortcuts.TurnOff != null)
                combinationDictionary.Add(config.Shortcuts.TurnOff, () => _userPresetService.SetColor(0, 0, 0));

            combinationDictionary.TryGetValue(combination, out var shortcutAction);
            shortcutAction?.Invoke();
        }
        #endregion
    }
}
