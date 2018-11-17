using GameColor.Core.Constants;
using GameColor.Core.Helpers;
using GameColor.Core.Interfaces;
using GameColor.Core.Models;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

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

            if (!String.IsNullOrEmpty(_configuration.Shortcuts.TurnOnRed))
                TextBox_ShortcutRed.Text = _configuration.Shortcuts.TurnOnRed;
            if (!String.IsNullOrEmpty(_configuration.Shortcuts.TurnOnGreen))
                TextBox_ShortcutGreen.Text = _configuration.Shortcuts.TurnOnGreen;
            if (!String.IsNullOrEmpty(_configuration.Shortcuts.TurnOnBlue))
                TextBox_ShortcutBlue.Text = _configuration.Shortcuts.TurnOnBlue;
            if (!String.IsNullOrEmpty(_configuration.Shortcuts.TurnOff))
                TextBox_ShortcutTurnOff.Text = _configuration.Shortcuts.TurnOff;
        }

        #region Events
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

        private void TextBox_ShortcutRed_KeyDown(object sender, KeyEventArgs e)
        {
            var shortCut = GetShortcutKeyCombinationDescription(e);

            TextBox_ShortcutRed.Text = shortCut;
            if (shortCut != KeyCombination.PRESS_KEY_COMBINATION_LABEL)
                _configuration.Shortcuts.TurnOnRed = shortCut;
            else _configuration.Shortcuts.TurnOnRed = null;
        }

        private void TextBox_ShortcutGreen_KeyDown(object sender, KeyEventArgs e)
        {
            var shortCut = GetShortcutKeyCombinationDescription(e);

            TextBox_ShortcutGreen.Text = shortCut;
            if (shortCut != KeyCombination.PRESS_KEY_COMBINATION_LABEL)
                _configuration.Shortcuts.TurnOnGreen = shortCut;
            else _configuration.Shortcuts.TurnOnGreen = null;
        }

        private void TextBox_ShortcutBlue_KeyDown(object sender, KeyEventArgs e)
        {
            var shortCut = GetShortcutKeyCombinationDescription(e);

            TextBox_ShortcutBlue.Text = shortCut;
            if (shortCut != KeyCombination.PRESS_KEY_COMBINATION_LABEL)
                _configuration.Shortcuts.TurnOnBlue = shortCut;
            else _configuration.Shortcuts.TurnOnBlue = null;
        }

        private void TextBox_ShortcutTurnOff_KeyDown(object sender, KeyEventArgs e)
        {
            var shortCut = GetShortcutKeyCombinationDescription(e);

            TextBox_ShortcutTurnOff.Text = shortCut;
            if (shortCut != KeyCombination.PRESS_KEY_COMBINATION_LABEL)
                _configuration.Shortcuts.TurnOff = shortCut;
            else _configuration.Shortcuts.TurnOff = null;
        }

        private void TextBox_ShortcutRed_Click(object sender, EventArgs e)
        {
            _configuration.Shortcuts.TurnOnRed = KeyEvents.MOUSE_RIGHT_CLICK_EVENT;
            TextBox_ShortcutRed.Text = KeyEvents.MOUSE_RIGHT_CLICK_EVENT;
        }

        private void TextBox_ShortcutGreen_Click(object sender, EventArgs e)
        {
            _configuration.Shortcuts.TurnOnGreen = KeyEvents.MOUSE_RIGHT_CLICK_EVENT;
            TextBox_ShortcutGreen.Text = KeyEvents.MOUSE_RIGHT_CLICK_EVENT;
        }

        private void TextBox_ShortcutBlue_Click(object sender, EventArgs e)
        {
            _configuration.Shortcuts.TurnOnBlue = KeyEvents.MOUSE_RIGHT_CLICK_EVENT;
            TextBox_ShortcutBlue.Text = KeyEvents.MOUSE_RIGHT_CLICK_EVENT;
        }

        private void TextBox_ShortcutTurnOff_Click(object sender, EventArgs e)
        {
            _configuration.Shortcuts.TurnOff = KeyEvents.MOUSE_RIGHT_CLICK_EVENT;
            TextBox_ShortcutTurnOff.Text = KeyEvents.MOUSE_RIGHT_CLICK_EVENT;
        }
        #endregion

        #region Methods
        private string GetShortcutKeyCombinationDescription(KeyEventArgs e)
        {
            var combination = e.Serialize(KeyCombination.PRESS_KEY_COMBINATION_LABEL);

            return combination;
        }
        #endregion
    }
}
