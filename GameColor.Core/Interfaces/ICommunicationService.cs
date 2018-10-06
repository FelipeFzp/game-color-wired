using GameColor.Common.Enums;

namespace GameColor.Core.Interfaces
{
    public interface ICommunicationService
    {
        void BindPort(string comPort);
        string GetBindedPort();
        bool TestConnection();
        void TurnOffLights();
        void ChangeColor(AcceptedColor color);
    }
}
