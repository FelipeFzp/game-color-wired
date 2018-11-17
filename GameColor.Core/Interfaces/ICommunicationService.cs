using GameColor.Common.Enums;

namespace GameColor.Core.Interfaces
{
    public interface ICommunicationService
    {
        void BindPort(string comPort, int writeTimeout = 2000, int readTimeout = 2000);
        string GetBindedPort();
        bool TestConnection();
        void TurnOffLights();
        void ChangeColor(AcceptedColor color);
    }
}
