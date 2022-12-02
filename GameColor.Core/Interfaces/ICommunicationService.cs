using System.Threading.Tasks;

namespace GameColor.Core.Interfaces
{
    public interface ICommunicationService
    {
        void BindPort(string comPort, int writeTimeout = 2000, int readTimeout = 2000);
        string GetBindedPort();
        Task<bool> TestConnectionAsync();
        void ChangeColor(byte[] rgb);
    }
}
