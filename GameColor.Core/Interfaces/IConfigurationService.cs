using GameColor.Core.Models;

namespace GameColor.Core.Interfaces
{
    public interface IConfigurationService
    {
        Configuration GetCurrentConfiguration();
        void SetConfiguration(Configuration configuration);
        void SetDefaultConfiguration(bool reset = false);
        void ApplyCurrentConfigurations(bool isStartup = false);
    }
}
