using GameColor.Core.Interfaces;
using GameColor.Core.Services;
using MetroFramework;
using MetroFramework.Forms;
using System;
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
            _userPresetService.OnRedChange((bool red) =>
            {
                Checkbox_Red.CheckedChanged -= Checkbox_Red_CheckedChanged;
                Checkbox_Red.Checked = red;
                Checkbox_Red.CheckedChanged += Checkbox_Red_CheckedChanged;
                ChangeMetroStyle();
            });

            _userPresetService.OnGreenChange((bool green) =>
            {
                Checkbox_Green.CheckedChanged -= Checkbox_Green_CheckedChanged;
                Checkbox_Green.Checked = green;
                Checkbox_Green.CheckedChanged += Checkbox_Green_CheckedChanged;
                ChangeMetroStyle();
            });

            _userPresetService.OnBlueChange((bool blue) =>
            {
                Checkbox_Blue.CheckedChanged -= Checkbox_Blue_CheckedChanged;
                Checkbox_Blue.Checked = blue;
                Checkbox_Blue.CheckedChanged += Checkbox_Blue_CheckedChanged;
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

                Checkbox_Red.Invoke((MethodInvoker)delegate
                {
                    if (currentConfiguration.TurnOnWhenOpen.Red)
                        Checkbox_Red.Checked = currentConfiguration.TurnOnWhenOpen.Red;
                });
                Checkbox_Green.Invoke((MethodInvoker)delegate
                {
                    if (currentConfiguration.TurnOnWhenOpen.Green)
                        Checkbox_Green.Checked = currentConfiguration.TurnOnWhenOpen.Green;
                });
                Checkbox_Blue.Invoke((MethodInvoker)delegate
                {
                    if (currentConfiguration.TurnOnWhenOpen.Blue)
                        Checkbox_Blue.Checked = currentConfiguration.TurnOnWhenOpen.Blue;
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
            _configurationService.DisposeConfigurations();
        }
        private void Button_StartGamePreset_Click(object sender, EventArgs e)
        {
            if (ComboBox_GamePreset.SelectedItem != null && ComboBox_GamePreset.SelectedItem.ToString() != String.Empty)
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

                _userPresetService.ToggleColor(Checkbox_Red.Checked, Checkbox_Green.Checked, Checkbox_Blue.Checked);
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
            if (port != String.Empty)
            {
                _communicationService.BindPort(port);
                _communicationService.TestConnectionAsync();

                Label_PortErrorMessage.Visible = false;
                Checkbox_Red.Enabled = true;
                Checkbox_Green.Enabled = true;
                Checkbox_Blue.Enabled = true;
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
        private void Tile_Updater_Click(object sender, EventArgs e) =>
            new UpdaterDialog().ShowDialog();
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
