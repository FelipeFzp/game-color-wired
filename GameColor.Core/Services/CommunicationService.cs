using GameColor.Common.Enums;
using GameColor.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;

namespace GameColor.Core.Services
{
    public class CommunicationService : ICommunicationService
    {
        #region Fields
        private const int TIMEOUT = 100;

        private readonly IUserLoggingService _userLoggingService;

        private SerialPort SerialPort;
        #endregion

        #region Constructor
        public CommunicationService(IUserLoggingService userLoggingService) =>
            _userLoggingService = userLoggingService;
        #endregion

        #region Public Methods
        public void BindPort(string comPort, int writeTimeout = TIMEOUT, int readTimeout = TIMEOUT)
        {
            SerialPort = new SerialPort(comPort, 9600);
            SerialPort.WriteTimeout = writeTimeout;
            SerialPort.ReadTimeout = readTimeout;
        }
        public string GetBindedPort() =>
            SerialPort != null ? SerialPort.PortName : String.Empty;
        public bool TestConnection()
        {
            try { SendData(' '); }
            catch { return false; }

            return true;
        }
        public void TurnOffLights() =>
            SendData('X');
        public void ChangeColor(AcceptedColor color) =>
            SendData(((int)color).ToString().First());
        #endregion

        #region Private Methods
        private void SendData(char data)
        {
            if (SerialPort != null)
            {
                try
                {
                    if (!SerialPort.IsOpen)
                        SerialPort.Open();

                    SerialPort.WriteLine(data.ToString());
                    SerialPort.Close();
                }
                catch
                {
                    _userLoggingService.LogLine("Could not send command...");
                }
            }
        }
        #endregion

        #region Static Methods
        //TODO: implementar splash screen na aplicação e exibir somente portas com o hardware connectado
        //é uma operação pesadas, por isso deve ser feita apenas na inicialização, remover chamada do evento de click do combobox
        public static List<string> GetAvailableCom() =>
            SerialPort.GetPortNames()
                      .OrderBy(p => p)
                      .ToList();
        #endregion
    }
}
