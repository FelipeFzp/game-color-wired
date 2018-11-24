using MetroFramework.Forms;
using CefSharp.WinForms;
using CefSharp;
using System.Windows.Forms;
using System;

namespace GameColor.View.Views
{
    public partial class UpdaterDialog : MetroForm
    {
        public const string DRIVE_FOLDER_URL = @"https://drive.google.com/drive/folders/1kdsUrv2v1G9Cd4tFzvldZ7d2l1LyeEX1";

        public UpdaterDialog()
        {
            InitializeComponent();
            InitializeChromium();
        }

        public void InitializeChromium()
        {
            var settings = new CefSettings();

            if (!Cef.IsInitialized)
                Cef.Initialize(settings);

            var browser = new ChromiumWebBrowser(DRIVE_FOLDER_URL);
            browser.Dock = DockStyle.Fill;

            Controls.Add(browser);
        }
    }
}
