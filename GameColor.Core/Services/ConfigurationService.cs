using GameColor.Core.Constants;
using GameColor.Core.Interfaces;
using GameColor.Core.Models;
using Microsoft.Win32;
using Newtonsoft.Json;
using System.IO;

namespace GameColor.Core.Services
{
    public class ConfigurationService : IConfigurationService
    {

        #region Fields
        private readonly string _tempPath;
        private readonly string _applicationExecutablePath;
        private readonly IUserPresetService _userPresetService;
        private readonly IUserLoggingService _userLoggingService;
        #endregion

        #region Constructor
        public ConfigurationService(string applicationExecutablePath, IUserPresetService userPresetService, IUserLoggingService userLoggingService)
        {
            _userLoggingService = userLoggingService;

            _userPresetService = userPresetService;
            _applicationExecutablePath = applicationExecutablePath;
            _tempPath = Path.GetTempPath();
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
        public void SetConfiguration(Configuration configuration) =>
            File.WriteAllText($"{_tempPath}/GAME_COLOR_SETTINGS.json", configuration.ToString());
        public void ApplyCurrentConfigurations(bool isStartup = false)
        {
            var configuration = DeserializeConfigurationFile();

            if (!isStartup)
            {
                if (configuration.StartWithWindows != null && configuration.StartWithWindows.Enabled)
                {
                    Registry.CurrentUser
                            .OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true)
                            .SetValue(ConfigurationFile.REGISTER_APPLICATION_NAME, _applicationExecutablePath);


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
        #endregion
    }
}
