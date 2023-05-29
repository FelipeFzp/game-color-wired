using GameColor.Core.DllImports;
using GameColor.Core.Helpers;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameColor.View.Views
{
    public partial class PresetCreatorDialog : MetroForm
    {
        #region Fields
        private IEnumerable<Process> _processes;
        private ListViewItem _lastProcessChecked;
        #endregion

        public PresetCreatorDialog()
        {
            InitializeComponent();
            Task.Run(() => LoadRunningProcessesToListView());
        }

        #region Events
        private void Button_Apply_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_NameYourProfile_Click(object sender, EventArgs e)
        {
            if (TextBox_NameYourProfile.Text == "Eg.: Stardew Valley")
                TextBox_NameYourProfile.Text = "";
        }

        private void TextBox_NameYourProfile_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox_NameYourProfile.Text))
                TextBox_NameYourProfile.Text = "Eg.: Stardew Valley";
        }

        private void ListView_Processes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_lastProcessChecked != null && _lastProcessChecked.Checked)
            {
                ListView_Processes.ItemCheck -= ListView_Processes_ItemCheck;
                _lastProcessChecked.Checked = false;
                ListView_Processes.ItemCheck += ListView_Processes_ItemCheck;
            }

            _lastProcessChecked = ListView_Processes.Items[e.Index];
            var processChecked = _processes.ElementAt(e.Index);
            Task.Run(async () =>
            {
                User32.BringProcessTo(processChecked, User32.SW_RESTORE);
                await Task.Delay(2000);
                var bitmap = ScreenshotHelper.TakeScreenshot(
                            Screen.PrimaryScreen.Bounds.Width,
                            Screen.PrimaryScreen.Bounds.Height,
                            Screen.PrimaryScreen.Bounds.Left,
                            Screen.PrimaryScreen.Bounds.Top);

                User32.BringProcessTo(processChecked, User32.SW_SHOWMINIMIZED);

                if (Picture_GamePreview.InvokeRequired)
                {
                    Action mainThreadWrite = delegate
                    {
                        Picture_GamePreview.CreateGraphics().DrawImage(bitmap, 0, 0);
                        Picture_GamePreview.SizeMode = PictureBoxSizeMode.Zoom;
                    };
                    Picture_GamePreview.Invoke(mainThreadWrite);
                }
                else
                {
                    Picture_GamePreview.CreateGraphics().DrawImage(bitmap, 0, 0);
                }
            });
        }
        #endregion


        private void LoadRunningProcessesToListView()
        {
            var processes = Process.GetProcesses()
                .OrderBy(p => p.ProcessName)
                .ToArray();
            var imageList = new ImageList();
            var listViewItems = new List<ListViewItem>();
            for (int i = 0; i < processes.Length; i++)
            {
                var process = processes[i];
                try
                {
                    var ico = Icon.ExtractAssociatedIcon(process.MainModule.FileName);
                    imageList.Images.Add(ico);
                }
                catch (Exception)
                {
                    imageList.Images.Add(Icon);
                }

                listViewItems.Add(new ListViewItem
                {
                    Text = $"{process.ProcessName} ({process.Id})",
                    ImageIndex = i,
                });
            }

            _processes = processes;
            if (ListView_Processes.InvokeRequired)
            {
                Action mainThreadWrite = delegate
                {
                    ListView_Processes.Items[0].Remove();
                    ListView_Processes.Enabled = true;
                    ListView_Processes.CheckBoxes = true;
                    ListView_Processes.SmallImageList = imageList;
                    ListView_Processes.Items.AddRange(listViewItems.ToArray());
                };
                ListView_Processes.Invoke(mainThreadWrite);
            }
            else
            {
                ListView_Processes.Items[0].Remove();
                ListView_Processes.Enabled = true;
                ListView_Processes.CheckBoxes = true;
                ListView_Processes.SmallImageList = imageList;
                ListView_Processes.Items.AddRange(listViewItems.ToArray());
            }

        }
    }
}
