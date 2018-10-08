using GameColor.Core.Interfaces;
using GameColor.Core.Services;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GameColor.View.Views
{
    public partial class GameColor : MetroForm
    {
        #region Properties
        private IUserPresetService _userPresetService;
        private IGamePresetService _gamePresetService;
        private ICommunicationService _communicationService;
        private IUserLoggingService _userLoggingService;
        #endregion

        #region Constructor
        public GameColor(IUserPresetService userPresetService, IGamePresetService gamePresetService, ICommunicationService communicationService, IUserLoggingService userLoggingService)
        {
            _userPresetService = userPresetService;
            _gamePresetService = gamePresetService;
            _communicationService = communicationService;
            _userLoggingService = userLoggingService;

            InitializeComponent();
            ConfigureLogs();
            LoadDefaultData();
        }
        #endregion

        #region Methods
        private void ChangeMetroStyle()
        {
            var red = Checkbox_Red.Checked;
            var green = Checkbox_Green.Checked;
            var blue = Checkbox_Blue.Checked;

            if (red || green || blue)
            {
                if (red && green && blue) Style = MetroColorStyle.White;
                else if (red && green && !blue) Style = MetroColorStyle.Yellow;
                else if (red && !green && blue) Style = MetroColorStyle.Magenta;
                else if (!red && green && blue) Style = MetroColorStyle.Blue;
                else if (red) Style = MetroColorStyle.Red;
                else if (green) Style = MetroColorStyle.Green;
                else if (blue) Style = MetroColorStyle.Blue;
            }
            else Style = MetroColorStyle.Default;
        }
        private void ResetMetroStyle() =>
            Style = MetroColorStyle.Default;
        private void LoadDefaultData()
        {
            TabControl_Presets.SelectedTab = Tab_Home;
            var availablePorts = CommunicationService.GetAvailableComs()
                                                            .ToList();
            ComboBox_Ports.DataSource = availablePorts;

            if (availablePorts.Count() == 1)
                ComboBox_Ports.SelectedIndex = 0;
        }
        private void ConfigureLogs()
        {
            _userLoggingService.OnLogChange((string log) =>
            {
                ListView_UserLog.Invoke((MethodInvoker)delegate {
                    ListView_UserLog.Items.Add(log);
                    ListView_UserLog.Items[ListView_UserLog.Items.Count - 1]
                                    .EnsureVisible();
                    
                    if (ListView_UserLog.Items.Count > ListView_UserLog.Height / 10)
                        ListView_UserLog.Items.RemoveAt(0);

                    ListView_UserLog.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                });
            });
        }
        #endregion

        #region Events
        private void Checkbox_Red_CheckedChanged(object sender, EventArgs e)
        {
            _userPresetService.ToggleRed();
            ChangeMetroStyle();
        }
        private void Checkbox_Green_CheckedChanged(object sender, EventArgs e)
        {
            _userPresetService.ToggleGreen();
            ChangeMetroStyle();
        }
        private void Checkbox_Blue_CheckedChanged(object sender, EventArgs e)
        {
            _userPresetService.ToggleBlue();
            ChangeMetroStyle();
        }
        private void GameColor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_gamePresetService.IsRunning())
                _gamePresetService.StopApplicationWatcher();

            if (_userPresetService.IsRunning())
                _userPresetService.StopUserPreset();

            _userLoggingService.StopLogging();
        }
        private void Button_StartGamePreset_Click(object sender, EventArgs e)
        {
            if (ComboBox_GamePreset.SelectedItem != null && ComboBox_GamePreset.SelectedItem.ToString() != String.Empty)
            {
                if (_userPresetService.IsRunning())
                {
                    _userPresetService.StopUserPreset();
                }
                if (_gamePresetService.IsRunning())
                {
                    _gamePresetService.StopApplicationWatcher();
                    Button_StartGamePreset.Text = "Start";
                }
                else
                {
                    ResetMetroStyle();
                    _gamePresetService.SetPreset(ComboBox_GamePreset.SelectedItem.ToString());
                    _gamePresetService.StartApplicationWatcher();
                    Button_StartGamePreset.Text = "Stop";
                }
            }
        }
        private void TabControl_Presets_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (TabControl_Presets.SelectedTab.Name == Tab_UserPreset.Name)
            {
                if (_gamePresetService.IsRunning())
                {
                    _gamePresetService.StopApplicationWatcher();
                    Button_StartGamePreset.Text = "Start";
                }

                _userPresetService.ToggleColor(Checkbox_Red.Checked, Checkbox_Green.Checked, Checkbox_Blue.Checked);
                ChangeMetroStyle();
            }
        }
        private void ComboBox_Ports_Click(object sender, EventArgs e)
        {
            ComboBox_Ports.DataSource = CommunicationService.GetAvailableComs()
                                                            .ToList();
        }
        private void ComboBox_Ports_SelectedValueChanged(object sender, EventArgs e)
        {
            var port = ComboBox_Ports.SelectedItem?.ToString();
            var currentPort = _communicationService.GetBindedPort();

            if (port != String.Empty)
            {
                if (port != currentPort)
                {
                    _communicationService.BindPort(port);

                    Button_StartGamePreset.Enabled = true;
                    Checkbox_Red.Enabled = true;
                    Checkbox_Green.Enabled = true;
                    Checkbox_Blue.Enabled = true;

                    if (_userPresetService.IsRunning())
                        _userPresetService.StopUserPreset();

                    if (_gamePresetService.IsRunning())
                        _gamePresetService.StopApplicationWatcher();

                    Label_PortErrorMessage.Visible = false;
                }
            }
            else Label_PortErrorMessage.Visible = true;
        }
        #endregion
    }
}
