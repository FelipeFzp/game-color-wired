using ColorMine.ColorSpaces;
using GameColor.Common.Enums;
using GameColor.Core.DllImports;
using GameColor.Core.Enums;
using GameColor.Core.Helpers;
using GameColor.Core.Interfaces;
using GameColor.Core.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading;

namespace GameColor.Core.Services
{
    public class GamePresetService : IGamePresetService
    {
        #region Fields
        private AcceptedColor _lastHealthLevel;
        private Process _windowsProcess;

        private static volatile bool _isStopped = true;

        private WatchedProcess _userProcess;
        private readonly ICommunicationService _communicationService;
        private readonly IUserLoggingService _userLoggingService;
        #endregion

        #region Constructor
        public GamePresetService(ICommunicationService communicationService, IUserLoggingService userLoggingService)
        {
            _communicationService = communicationService;
            _userLoggingService = userLoggingService;
        }
        #endregion

        #region Public Methods
        public void SetPreset(string name)
        {
            //TODO: buscar presets configurados pelo usuário
            _userProcess = new WatchedProcess("FortniteClient-Win64-Shipping", 672, 829, 265, 15,
                                  new ColorExpression(100, Color.FromArgb(140, 90, 200), 4, 20, EvaluationStrategy.KeepLast),
                                  new ColorExpression(100, Color.FromArgb(49, 115, 124), 4, 20, EvaluationStrategy.KeepLast),
                                  new ColorExpression(200, Color.FromArgb(99, 202, 70), AcceptedColor.Green, 3, 20, EvaluationStrategy.Normal),
                                  new ColorExpression(100, Color.FromArgb(99, 202, 70), AcceptedColor.Yellow, 2, 20, EvaluationStrategy.Normal),
                                  new ColorExpression(70, Color.FromArgb(99, 202, 70), AcceptedColor.Red, 1, 20, EvaluationStrategy.Normal));
        }
        public void StartApplicationWatcher()
        {
            _isStopped = false;

            var thread = new Thread(() =>
            {
                while (!_isStopped)
                {
                    if (_windowsProcess != null && !_windowsProcess.HasExited && !_isStopped)
                    {
                        var screenshot = TakeScreenshot();
                        var graphics = screenshot.Bitmap.ToGraphics();

                        var unit = GraphicsUnit.Pixel;
                        var bounds = screenshot.Bitmap.GetBounds(ref unit);

                        graphics.CopyFromScreen(_userProcess.Left, _userProcess.Top, 0, 0, new Size(screenshot.Bitmap.Width, screenshot.Bitmap.Height), CopyPixelOperation.SourceCopy);

                        EvaluateColorExpressions(screenshot);
                    }
                    else
                    {
                        //_communicationService.TurnOffLights();
                        _isStopped = false;
                        _windowsProcess = null;
                        _windowsProcess = GetCurrentWindowsProcess();
                    }

                    Thread.Sleep(500);
                }
            }); 

            if (!_isStopped)
                thread.Start();
        }
        public void StopApplicationWatcher()
        {
            _isStopped = true;
            _communicationService.TurnOffLights();
            _userLoggingService.LogLine("Stopping Application Watcher...");
        }
        public bool IsRunning()
            => !_isStopped;
        #endregion

        #region Private Methods
        
        private Process GetCurrentWindowsProcess()
        {
            Process proc;
            do
            {
                _userLoggingService.LogLine($"Finding process {_userProcess.Name}...");
                proc = Process.GetProcessesByName(_userProcess.Name)
                              .ToList()
                              .FirstOrDefault();

                if (proc == null)
                    Thread.Sleep(2000);
                else if (proc.HasExited) break;

            } while (proc == null && !_isStopped);

            if (_isStopped)
                _userLoggingService.LogLine($"Process search canceled!");

            if (proc != null)
                _userLoggingService.LogLine($"Process found!");

            return proc;
        }
        private void EvaluateColorExpressions(Screenshot screenshot)
        {
            var highestHealthLevel = _userProcess.Expression
                                        .OrderBy(p => p.Priority)
                                        .First()
                                        .Status;

            _userProcess.Expression
                    .OrderBy(p => p.Priority)
                    .ToList()
                    .ForEach(e =>
                    {
                        var pixel = screenshot.Bitmap.GetPixel(e.PixelIndex, 0);

                        var expectedLab = ColorHelper.CreateLabFromRgb(e.TargetColor.R, e.TargetColor.G, e.TargetColor.B);
                        var currentLab = ColorHelper.CreateLabFromRgb(pixel.R, pixel.G, pixel.B);

                        var diference = CompareLabColors(expectedLab, currentLab);

                        if (diference > -e.Tolerance && diference < e.Tolerance)
                        {
                            if (e.Strategy == EvaluationStrategy.KeepLast)
                                highestHealthLevel = _lastHealthLevel;
                            else
                                highestHealthLevel = e.Status;
                        }
                        #region Debug
                        //screenshot.Bitmap.MarkPixel(e.PixelIndex, 0, e.Status);
                        #endregion
                    });
            _lastHealthLevel = highestHealthLevel;

            _userLoggingService.LogLine($"Health: {highestHealthLevel}");
            _communicationService.ChangeColor(highestHealthLevel);
        }
        private Screenshot TakeScreenshot()
        {
            var rect = new User32.Rectangle();
            User32.GetWindowRect(_windowsProcess.MainWindowHandle, ref rect);
            var bitmap = new System.Drawing.Bitmap(_userProcess.Width, _userProcess.Height, PixelFormat.Format32bppArgb);

            #region Debug
            //"Capturando tela...".LogLine();
            //    bitmap.Save($"{Directory.GetCurrentDirectory()}\\SCREEN.png", ImageFormat.Png);
            #endregion

            return new Screenshot(bitmap, rect);
        }
        private double CompareLabColors(Lab currentLab, Lab expectedLab)
        {
            return Math.Sqrt(Math.Pow(expectedLab.L - currentLab.L, 2) + Math.Pow(expectedLab.A - currentLab.A, 2) + Math.Pow(expectedLab.B - currentLab.B, 2));
        }
        #endregion
    }
}
