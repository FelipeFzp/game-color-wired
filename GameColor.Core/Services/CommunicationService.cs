using GameColor.Core.Enums;
using GameColor.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GameColor.Core.Services
{
    public class CommunicationService : ICommunicationService
    {
        #region Fields
        private const int TIMEOUT = 100;

        private readonly IUserLoggingService _userLoggingService;

        private SerialPort SerialPort;
        private bool TaskInProgress;
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
        public async Task<bool> TestConnectionAsync()
        {
            var hasConnection = await SendDataAsync(String.Empty);
            if (hasConnection)
                _userLoggingService.LogLine("Connection successfully established.");

            return hasConnection;
        }
        public async Task TurnOffLightsAsync() =>
            await SendDataAsync(((int)AcceptedColor.Black).ToString());
        public async Task ChangeColorAsync(AcceptedColor color) =>
            await SendDataAsync(((int)color).ToString());
        #endregion

        #region Private Methods
        private async Task<bool> SendDataAsync(string data, bool log = true)
        {
            var response = String.Empty;

            if (SerialPort == null)
                return false;

            await Task.Run(async () =>
            {
                await WaitForAvailableSerialAsync();
                TaskInProgress = true;

                try { response = await SerialWriteAsync(data); }
                catch(Exception e)
                {
                    if (log)
                        _userLoggingService.LogLine($"Error: {e.Message}");
                }
                finally
                {
                    if (log)
                        _userLoggingService.LogLine(response);

                    TaskInProgress = false;
                }
            });

            return String.IsNullOrEmpty(response);
        }
        private async Task WaitForAvailableSerialAsync()
        {
            while (TaskInProgress)
                await Task.Delay(40);
        }
        private void OpenSerial()
        {
            if (!SerialPort.IsOpen)
                SerialPort.Open();
        }

        private void CloseSerial()
        {
            if (SerialPort.IsOpen)
                SerialPort.Close();
        }
        private async Task<string> SerialWriteAsync(string data)
        {
            OpenSerial();

            SerialPort.WriteLine(data);
            await Task.Delay(50);
            var response = SerialPort.ReadExisting();

            CloseSerial();

            return response;
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
