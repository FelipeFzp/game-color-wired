using GameColor.Core.Interfaces;
using GameColor.Core.Services;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameColor.View.Views
{
    public partial class GameColor : MetroForm
    {
        #region Properties
        private readonly bool _initializateBySystem;
        private readonly IUserPresetService _userPresetService;
        private readonly IGamePresetService _gamePresetService;
        private readonly ICommunicationService _communicationService;
        private readonly IUserLoggingService _userLoggingService;
        private readonly IConfigurationService _configurationService;
        #endregion

        #region Constructor
        public GameColor(IUserPresetService userPresetService,
            IGamePresetService gamePresetService,
            ICommunicationService communicationService,
            IUserLoggingService userLoggingService,
            IConfigurationService configurationService, bool initializateBySystem)
        {
            _userPresetService = userPresetService;
            _gamePresetService = gamePresetService;
            _communicationService = communicationService;
            _userLoggingService = userLoggingService;
            _configurationService = configurationService;
            _initializateBySystem = initializateBySystem;

            InitializeComponent();

            ConfigureViewEvents();

            LoadConfiguration();
            LoadDefaultControlsData();
        }
        #endregion

        #region Methods
        private void LoadConfiguration() =>
            _configurationService.SetDefaultConfiguration();

        private void ChangeMetroStyle()
        {
            var red = Convert.ToInt32(TrackBar_Red.Value > 0);
            var green = Convert.ToInt32(TrackBar_Green.Value > 0);
            var blue = Convert.ToInt32(TrackBar_Blue.Value > 0);
            var combination = $"{red}{green}{blue}";

            Style = new Dictionary<string, MetroColorStyle>
            {
                { "111", MetroColorStyle.White },
                { "110", MetroColorStyle.Yellow },
                { "101", MetroColorStyle.Purple },
                { "011", MetroColorStyle.Teal },
                { "100", MetroColorStyle.Red },
                { "010", MetroColorStyle.Green },
                { "001", MetroColorStyle.Blue },
                { "000", MetroColorStyle.Default }
            }[combination];
        }

        private void ResetMetroStyle() =>
            Style = MetroColorStyle.Default;

        private void LoadDefaultControlsData()
        {
            TabControl_Presets.SelectedTab = Tab_Home;

            var availablePorts = CommunicationService.GetAvailableCom();
            ComboBox_Ports.DataSource = availablePorts;

            if (availablePorts.Count > 1)
                ComboBox_Ports.SelectedIndex = 0;
        }

        private void ConfigureViewEvents()
        {
            #region Logs
            _userLoggingService.OnLogChange((string log) =>
            {
                ListView_UserLog.Invoke((MethodInvoker)delegate
                {
                    ListView_UserLog.Items.Add(log);
                    ListView_UserLog.Items[ListView_UserLog.Items.Count - 1]
                                    .EnsureVisible();

                    if (ListView_UserLog.Items.Count > ListView_UserLog.Height / 10)
                        ListView_UserLog.Items.RemoveAt(0);

                    ListView_UserLog.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                });
            });
            #endregion

            #region Colors Checkboxes
            _userPresetService.OnRedChange((byte red) =>
            {
                TrackBar_Red.ValueChanged -= TrackBar_Red_ValueChanged;
                TrackBar_Red.Value = red;
                TrackBar_Red.ValueChanged += TrackBar_Red_ValueChanged;
                ChangeMetroStyle();
            });

            _userPresetService.OnGreenChange((byte green) =>
            {
                TrackBar_Green.ValueChanged -= TrackBar_Green_ValueChanged;
                TrackBar_Green.Value = green;
                TrackBar_Green.ValueChanged += TrackBar_Green_ValueChanged;
                ChangeMetroStyle();
            });

            _userPresetService.OnBlueChange((byte blue) =>
            {
                TrackBar_Blue.ValueChanged -= TrackBar_Blue_ValueChanged;
                TrackBar_Blue.Value = blue;
                TrackBar_Blue.ValueChanged += TrackBar_Blue_ValueChanged;
                ChangeMetroStyle();
            });
            #endregion
        }

        private void ConfigureUserPreferences()
        {
            var currentConfiguration = _configurationService.GetCurrentConfiguration();

            Task.Run(async () =>
            {
                //This delay wait for system COMS driver initialization
                if (_initializateBySystem) await Task.Delay(2000);

                TrackBar_Red.Invoke((MethodInvoker)delegate
                {
                    if (currentConfiguration.TurnOnWhenOpen.Red)
                        TrackBar_Red.Value = currentConfiguration.TurnOnWhenOpen.Red ? 255 : 0;
                });
                TrackBar_Green.Invoke((MethodInvoker)delegate
                {
                    if (currentConfiguration.TurnOnWhenOpen.Green)
                        TrackBar_Green.Value = currentConfiguration.TurnOnWhenOpen.Green ? 255 : 0;
                });
                TrackBar_Blue.Invoke((MethodInvoker)delegate
                {
                    if (currentConfiguration.TurnOnWhenOpen.Blue)
                        TrackBar_Blue.Value = currentConfiguration.TurnOnWhenOpen.Blue ? 255 : 0;
                });
            });
        }
        #endregion

        #region Events
        private void TrackBar_Red_ValueChanged(object sender, EventArgs e)
        {
            _userPresetService.SetRed(Convert.ToByte(TrackBar_Red.Value));
            ChangeMetroStyle();
        }

        private void TrackBar_Green_ValueChanged(object sender, EventArgs e)
        {
            _userPresetService.SetGreen(Convert.ToByte(TrackBar_Green.Value));
            ChangeMetroStyle();
        }

        private void TrackBar_Blue_ValueChanged(object sender, EventArgs e)
        {
            _userPresetService.SetBlue(Convert.ToByte(TrackBar_Blue.Value));
            ChangeMetroStyle();
        }

        private void GameColor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_gamePresetService.IsRunning())
                _gamePresetService.StopApplicationWatcher();

            if (_userPresetService.IsRunning())
                _userPresetService.StopUserPreset();

            _userLoggingService.StopLogging();
            _configurationService.DisposeConfigurations();
        }

        private void Button_StartGamePreset_Click(object sender, EventArgs e)
        {
            if (ComboBox_GamePreset.SelectedItem != null && ComboBox_GamePreset.SelectedItem.ToString() != string.Empty)
            {
                if (_userPresetService.IsRunning())
                    _userPresetService.StopUserPreset();

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
                _userPresetService.SetColor(Convert.ToByte(TrackBar_Red.Value), Convert.ToByte(TrackBar_Green.Value), Convert.ToByte(TrackBar_Blue.Value));
                ChangeMetroStyle();
            }
        }

        private void ComboBox_Ports_Click(object sender, EventArgs e)
        {
            var availablePorts = CommunicationService.GetAvailableCom();
            ComboBox_Ports.DataSource = availablePorts;

            if (availablePorts.Count > 1)
                ComboBox_Ports.SelectedIndex = 0;
        }

        private void ComboBox_Ports_SelectedValueChanged(object sender, EventArgs e)
        {
            var port = ComboBox_Ports.SelectedItem?.ToString();
            if (port != string.Empty)
            {
                _communicationService.BindPort(port);
                _communicationService.TestConnectionAsync();

                Label_PortErrorMessage.Visible = false;
                TrackBar_Red.Enabled = true;
                TrackBar_Green.Enabled = true;
                TrackBar_Blue.Enabled = true;
                Button_StartGamePreset.Enabled = true;

                if (ComboBox_Ports.Visible)
                    HandlePortsComboBoxValueChanged();
                else
                    HandlePortsComboBoxInitialization();
            }
            else
                Label_PortErrorMessage.Visible = true;
        }

        private void Tile_Settings_Click(object sender, EventArgs e) =>
            new SettingsDialog(_configurationService).ShowDialog();

        private void HandlePortsComboBoxValueChanged()
        {
            var port = ComboBox_Ports.SelectedItem?.ToString();
            var currentPort = _communicationService.GetBindedPort();

            if (port != currentPort)
            {
                if (_userPresetService.IsRunning())
                    _userPresetService.StopUserPreset();

                if (_gamePresetService.IsRunning())
                    _gamePresetService.StopApplicationWatcher();

            }
        }

        private void HandlePortsComboBoxInitialization() =>
            ConfigureUserPreferences();

        private void TabControl_Presets_KeyDown(object sender, KeyEventArgs e) =>
            e.Handled = true;
        #endregion
    }
}
