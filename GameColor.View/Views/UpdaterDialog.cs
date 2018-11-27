using MetroFramework.Forms;
using CefSharp.WinForms;
using CefSharp;
using System.Windows.Forms;
using System;
using GameColor.View.Handlers;
using System.Linq;
using GameColor.Core.Interfaces;
using GameColor.Core.Models;
using System.IO;
using Newtonsoft.Json;
using ArduinoUploader;
using ArduinoUploader.Hardware;
using ICSharpCode.SharpZipLib.Zip;

namespace GameColor.View.Views
{
    public partial class UpdaterDialog : MetroForm
    {
        public const string DRIVE_FOLDER_URL = @"https://drive.google.com/drive/folders/1kdsUrv2v1G9Cd4tFzvldZ7d2l1LyeEX1";

        private readonly ICommunicationService _communicationService;
        private string _fullPath;
        private string _fileName;
        private string _folderPath;

        public UpdaterDialog(ICommunicationService communicationService)
        {
            InitializeComponent();
            InitializeChromium();

            _communicationService = communicationService;
        }

        private void InitializeChromium()
        {
            var settings = new CefSettings();

            if (!Cef.IsInitialized)
            {
                Cef.EnableHighDPISupport();
                Cef.Initialize(settings);
            }

            var browser = new ChromiumWebBrowser(DRIVE_FOLDER_URL);
            browser.Dock = DockStyle.Fill;

            var downloadHandler = new DownloadHandler();
            downloadHandler.OnDownloadUpdatedFired += DownloadHandler;
            browser.DownloadHandler = downloadHandler;

            Controls.Add(browser);
        }

        #region Events
        private void DownloadHandler(object sender, DownloadItem download)
        {
            //if (download.IsCancelled)
            //TODO: avisar usuário que o download foi cancelado

            if (download.IsComplete)
            {
                _fullPath = download.FullPath;
                _fileName = _fullPath.Split('\\')
                                       .ToList()
                                       .Last();

                _folderPath = _fullPath.TrimEnd(_fileName.ToArray());

                var tempFolder = default(DirectoryInfo);

                try
                {
                    tempFolder = CreateTemporaryFolder();

                    ExtractZipToTempAndDelete(tempFolder);

                    var manifest = ReadManifestFile(tempFolder);

                    MoveUserFileToSelectedPath(tempFolder, manifest);

                    UploadMicroControllerFirmware(tempFolder, manifest);
                }
                catch (Exception e)
                {
                    //TODO: lançar exceção e exibir mensagem amigavel para o usuario
                }
                finally
                {
                    if (tempFolder != null)
                        tempFolder.Delete(true);

                    Invoke((MethodInvoker)delegate { Close(); });
                }
            }
        }
        #endregion

        #region Methods
        private DirectoryInfo CreateTemporaryFolder()
        {
            var targetDirectory = $"{_folderPath}GameColorTemp";

            if (Directory.Exists(targetDirectory))
                Directory.Delete(targetDirectory);

            var tempFolder = Directory.CreateDirectory(targetDirectory);
            tempFolder.Attributes = FileAttributes.Directory | FileAttributes.Hidden;

            return tempFolder;
        }

        private void ExtractZipToTempAndDelete(DirectoryInfo tempFolder)
        {
            new FastZip().ExtractZip(_fullPath, tempFolder.FullName, null);
            File.Delete(_fullPath);
        }

        private UpdateManifest ReadManifestFile(DirectoryInfo tempFolder)
        {
            var rawManifest = File.ReadAllText($"{tempFolder.FullName}\\Manifest.json");
            return JsonConvert.DeserializeObject<UpdateManifest>(rawManifest);
        }

        private void MoveUserFileToSelectedPath(DirectoryInfo tempFolder, UpdateManifest manifest)
        {
            var targetFilePath = $"{_folderPath}\\{manifest.UserFile}";

            if (File.Exists(targetFilePath))
                File.Delete(targetFilePath);

            File.Move($"{tempFolder.FullName}\\{manifest.UserFile}", $"{_folderPath}\\{manifest.UserFile}");
        }

        private void UploadMicroControllerFirmware(DirectoryInfo tempFolder, UpdateManifest manifest)
        {
            var comPort = _communicationService.GetBindedPort();

            //if (String.IsNullOrEmpty(comPort))
            //TODO: lançar exceção amigavel e exibir para o usuário avisando que a conexão com a arduino nao foi estabelecida

            new ArduinoSketchUploader(
                new ArduinoSketchUploaderOptions()
                {
                    FileName = $"{tempFolder.FullName}\\{manifest.MicroControllerFile}",
                    PortName = comPort,
                    ArduinoModel = ArduinoModel.UnoR3 //Primeiras versões suporta apenas Arduino Uno
                }).UploadSketch();
        }
        #endregion
    }
}
