using GameColor.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;

namespace GameColor.Core.Services
{
    public class CommunicationService : ICommunicationService
    {
        #region Fields
        private const int TIMEOUT = 100;

        private readonly IUserLoggingService _userLoggingService;

        private SerialPort SerialPort;
        private Subject<string> DataSendSubject = new Subject<string>();
        #endregion

        #region Constructor
        public CommunicationService(IUserLoggingService userLoggingService)
        {
            _userLoggingService = userLoggingService;
            DataSendSubject
                .Throttle(TimeSpan.FromMilliseconds(200))
                .Subscribe(async e => await SendDataAsync(e));
        }
        #endregion

        #region Public Methods
        public void BindPort(string comPort, int writeTimeout = TIMEOUT, int readTimeout = TIMEOUT)
        {
            SerialPort = new SerialPort(comPort, 9600);
            SerialPort.WriteTimeout = writeTimeout;
            SerialPort.ReadTimeout = readTimeout;
        }

        public string GetBindedPort() =>
            SerialPort != null ? SerialPort.PortName : string.Empty;

        public async Task<bool> TestConnectionAsync()
        {
            var hasConnection = await SendDataAsync(string.Empty);
            if (hasConnection)
                _userLoggingService.LogLine("Connection successfully established.");

            return hasConnection;
        }

        public void ChangeColor(byte[] rgb) =>
            DataSendSubject.OnNext($"rgb({string.Join(",", rgb)})");
        #endregion

        #region Private Methods
        private async Task<bool> SendDataAsync(string data, bool log = true)
        {
            var response = string.Empty;

            if (SerialPort == null)
                return false;

            await Task.Run(async () =>
            {
                try
                {
                    Console.WriteLine(data);
                    OpenSerial();

                    SerialPort.WriteLine(data);
                    await Task.Delay(50);
                    response = SerialPort.ReadExisting();

                    CloseSerial();
                }
                catch (Exception e)
                {
                    if (log)
                        _userLoggingService.LogLine($"Error: {e.Message}");
                }
                finally
                {
                    if (log && !string.IsNullOrEmpty(response))
                        _userLoggingService.LogLine(response);

                }
            });

            return string.IsNullOrEmpty(response);
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
