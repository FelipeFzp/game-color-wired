using GameColor.Common.Enums;
using GameColor.Core.Interfaces;
using System;
using System.IO.Ports;
using System.Linq;

namespace GameColor.Core.Services
{
    public class CommunicationService : ICommunicationService
    {
        #region Fields
        private readonly IUserLoggingService _userLoggingService;
        private SerialPort _serial;
        #endregion

        #region Constructor
        public CommunicationService(IUserLoggingService userLoggingService) =>
            _userLoggingService = userLoggingService;
        #endregion

        #region Public Methods
        public void BindPort(string comPort) =>
            _serial = new SerialPort(comPort, 9600);
        public string GetBindedPort() =>
            _serial != null ? _serial.PortName : String.Empty;
        public bool TestConnection()
        {
            var exception = default(Exception);
            try
            {
                SendData(' ');
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            return exception != null;
        }
        public void TurnOffLights() =>
            SendData('X');
        public void ChangeColor(AcceptedColor color) =>
            SendData(((int)color).ToString().First());
        #endregion

        #region Private Methods
        private void SendData(char data)
        {
            if(_serial != null)
            {
                try
                {
                    if (!_serial.IsOpen)
                        _serial.Open();

                    _serial.WriteLine(data.ToString());
                    _serial.Close();
                }
                catch(Exception e)
                {
                    _userLoggingService.LogLine("Could not send command...");
                }
            }
        }
        #endregion

        #region Static Methods
        public static string[] GetAvailableComs() =>
          SerialPort.GetPortNames();
        #endregion
    }
}
