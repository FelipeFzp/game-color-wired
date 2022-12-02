using ColorMine.ColorSpaces;
using GameColor.Core.DllImports;
using GameColor.Core.Helpers;
using GameColor.Core.Interfaces;
using GameColor.Core.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading;
using System.IO;

namespace GameColor.Core.Services
{
    public class GamePresetService : IGamePresetService
    {
        #region Fields
        private Color _lastHealthLevel;
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
            _userProcess = new WatchedProcess(
                "FortniteClient-Win64-Shipping", 0, 0, 2560, 1440,
                new ColorExpression(x: 300, y: 1275, targetColor: Color.FromArgb(0, 171, 234), resultColor: Color.FromArgb(0, 255, 0), tolerance: 20 ),
                new ColorExpression(x: 430, y: 1300, targetColor: Color.FromArgb(63, 213, 48), resultColor: Color.FromArgb(255, 255, 0), tolerance: 20),
                new ColorExpression(x: 250, y: 1300, targetColor: Color.FromArgb(63, 213, 48), resultColor: Color.FromArgb(255, 0, 0), tolerance: 20)
                );
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

                    Thread.Sleep(1000);
                }
            });

            if (!_isStopped)
                thread.Start();
        }
        public void StopApplicationWatcher()
        {
            _isStopped = true;
            _communicationService.ChangeColor(new byte[] { 0, 0, 0 });
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
                                        .Last()
                                        .ResultColor;

            _userProcess.Expression
                    .Reverse()
                    .ToList()
                    .ForEach(e =>
                    {
                        var pixel = screenshot.Bitmap.GetPixel(e.X, e.Y);
                        var currentLab = ColorHelper.CreateLabFromRgb(pixel.R, pixel.G, pixel.B);
                        var expectedLab = ColorHelper.CreateLabFromRgb(e.TargetColor.R, e.TargetColor.G, e.TargetColor.B);

                        var diference = CompareLabColors(expectedLab, currentLab);

                        if (diference > -e.Tolerance && diference < e.Tolerance)
                            highestHealthLevel = e.ResultColor;

                        #region Debug
                        screenshot.Bitmap.MarkPixel(e.X, e.Y, e.ResultColor);
                        #endregion
                    });

            screenshot.Bitmap.Save($"{Directory.GetCurrentDirectory()}\\SCREEN.png", ImageFormat.Png);

            _lastHealthLevel = highestHealthLevel;

            _userLoggingService.LogLine($"Health: {highestHealthLevel}");
            _communicationService.ChangeColor(new byte[] { highestHealthLevel.R, highestHealthLevel.G, highestHealthLevel.B });
        }
        private Screenshot TakeScreenshot()
        {
            var rect = new User32.Rectangle();
            User32.GetWindowRect(_windowsProcess.MainWindowHandle, ref rect);
            var bitmap = new System.Drawing.Bitmap(_userProcess.Width, _userProcess.Height, PixelFormat.Format32bppArgb);

            #region Debug
            //"Capturando tela...".LogLine();
            //bitmap.Save($"{Directory.GetCurrentDirectory()}\\SCREEN.png", ImageFormat.Png);
            #endregion

            return new Screenshot(bitmap, rect);
        }
        private double CompareLabColors(Lab currentLab, Lab expectedLab)
        {
            return Math.Sqrt(
                Math.Pow(expectedLab.L - currentLab.L, 2) +
                Math.Pow(expectedLab.A - currentLab.A, 2) +
                Math.Pow(expectedLab.B - currentLab.B, 2));
        }
        #endregion
    }
}
