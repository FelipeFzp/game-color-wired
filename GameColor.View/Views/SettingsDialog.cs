using GameColor.Core.Interfaces;
using GameColor.Core.Models;
using MetroFramework.Forms;
using System;

namespace GameColor.View.Views
{
    public partial class SettingsDialog : MetroForm
    {
        private readonly IConfigurationService _configurationService;
        private Configuration _configuration;

        public SettingsDialog(IConfigurationService configurationService)
        {
            _configurationService = configurationService;
            _configuration = configurationService.GetCurrentConfiguration();

            InitializeComponent();
            LoadDefaultData();
        }

        private void LoadDefaultData()
        {
            Toggle_InitializeWithWindows.CheckedChanged -= Toggle_InitializeWithWindows_CheckedChanged;
            CheckBox_Red.CheckedChanged -= CheckBox_Red_CheckedChanged;
            CheckBox_Green.CheckedChanged -= CheckBox_Green_CheckedChanged;
            CheckBox_Blue.CheckedChanged -= CheckBox_Blue_CheckedChanged;

            Toggle_InitializeWithWindows.Checked = (bool)_configuration.StartWithWindows?.Enabled;
            CheckBox_Red.Checked = (bool)_configuration.TurnOnWhenOpen?.Red;
            CheckBox_Green.Checked = (bool)_configuration.TurnOnWhenOpen?.Green;
            CheckBox_Blue.Checked = (bool)_configuration.TurnOnWhenOpen?.Blue;

            CheckBox_Red.CheckedChanged += CheckBox_Red_CheckedChanged;
            CheckBox_Green.CheckedChanged += CheckBox_Green_CheckedChanged;
            CheckBox_Blue.CheckedChanged += CheckBox_Blue_CheckedChanged;
            Toggle_InitializeWithWindows.CheckedChanged += Toggle_InitializeWithWindows_CheckedChanged;
        }

        private void Toggle_InitializeWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (_configuration.StartWithWindows == null)
                _configuration.StartWithWindows = new ConfigurationStartWithWindows();

            _configuration.StartWithWindows.Enabled = Toggle_InitializeWithWindows.Checked;
        }

        private void Button_Apply_Click(object sender, EventArgs e)
        {
            _configurationService.SetConfiguration(_configuration);
            _configurationService.ApplyCurrentConfigurations();
        }

        private void CheckBox_Red_CheckedChanged(object sender, EventArgs e) =>
            _configuration.TurnOnWhenOpen.Red = CheckBox_Red.Checked;

        private void CheckBox_Green_CheckedChanged(object sender, EventArgs e) =>
            _configuration.TurnOnWhenOpen.Green = CheckBox_Green.Checked;

        private void CheckBox_Blue_CheckedChanged(object sender, EventArgs e) =>
            _configuration.TurnOnWhenOpen.Blue = CheckBox_Blue.Checked;
    }
}
