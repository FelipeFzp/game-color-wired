using GameColor.Core.Constants;
using GameColor.Core.Helpers;
using GameColor.Core.Interfaces;
using GameColor.Core.Models;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
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
            Toggle_InitializeWithWindows.Checked = (bool)_configuration.StartWithWindows?.Enabled;
            Toggle_InitializeWithWindows.CheckedChanged += Toggle_InitializeWithWindows_CheckedChanged;

            CheckBox_Red.CheckedChanged -= CheckBox_Red_CheckedChanged;
            CheckBox_Red.Checked = (bool)_configuration.TurnOnWhenOpen?.Red;
            CheckBox_Red.CheckedChanged += CheckBox_Red_CheckedChanged;

            CheckBox_Green.CheckedChanged -= CheckBox_Green_CheckedChanged;
            CheckBox_Green.Checked = (bool)_configuration.TurnOnWhenOpen?.Green;
            CheckBox_Green.CheckedChanged += CheckBox_Green_CheckedChanged;

            CheckBox_Blue.CheckedChanged -= CheckBox_Blue_CheckedChanged;
            CheckBox_Blue.Checked = (bool)_configuration.TurnOnWhenOpen?.Blue;
            CheckBox_Blue.CheckedChanged += CheckBox_Blue_CheckedChanged;


            if (!string.IsNullOrEmpty(_configuration.Shortcuts.IncrementRed))
                TextBox_ShortcutRedInc.Text = _configuration.Shortcuts.IncrementRed;
            if (!string.IsNullOrEmpty(_configuration.Shortcuts.DecrementRed))
                TextBox_ShortcutRedDec.Text = _configuration.Shortcuts.DecrementRed;
            
            if (!string.IsNullOrEmpty(_configuration.Shortcuts.IncrementGreen))
                TextBox_ShortcutGreenInc.Text = _configuration.Shortcuts.IncrementGreen;
            if (!string.IsNullOrEmpty(_configuration.Shortcuts.DecrementGreen))
                TextBox_ShortcutGreenDec.Text = _configuration.Shortcuts.DecrementGreen;
            
            
            if (!string.IsNullOrEmpty(_configuration.Shortcuts.IncrementBlue))
                TextBox_ShortcutBlueInc.Text = _configuration.Shortcuts.IncrementBlue;
            if (!string.IsNullOrEmpty(_configuration.Shortcuts.DecrementBlue))
                TextBox_ShortcutBlueDec.Text = _configuration.Shortcuts.DecrementBlue;

            if (!string.IsNullOrEmpty(_configuration.Shortcuts.TurnOff))
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

        private void TextBox_Shortcut_KeyDown(object sender, KeyEventArgs e)
        {
            var textBox = sender as MetroTextBox;
            var shortCutDescription = GetShortcutKeyCombinationDescription(e);

            textBox.Text = shortCutDescription;

            var shortcutMapByTextboxName = new Dictionary<string, Action<string>>()
            {
                //RED
                { TextBox_ShortcutRedInc.Name, (shortcut) => _configuration.Shortcuts.IncrementRed = shortcut != KeyCombination.PRESS_KEY_COMBINATION_LABEL ? shortcut : null },
                { TextBox_ShortcutRedDec.Name, (shortcut) => _configuration.Shortcuts.DecrementRed = shortcut != KeyCombination.PRESS_KEY_COMBINATION_LABEL ? shortcut : null },

                //GREEN
                { TextBox_ShortcutGreenInc.Name, (shortcut) => _configuration.Shortcuts.IncrementGreen = shortcut != KeyCombination.PRESS_KEY_COMBINATION_LABEL ? shortcut : null },
                { TextBox_ShortcutGreenDec.Name, (shortcut) => _configuration.Shortcuts.DecrementGreen = shortcut != KeyCombination.PRESS_KEY_COMBINATION_LABEL ? shortcut : null },

                //BLUE
                { TextBox_ShortcutBlueInc.Name, (shortcut) => _configuration.Shortcuts.IncrementBlue = shortcut != KeyCombination.PRESS_KEY_COMBINATION_LABEL ? shortcut : null },
                { TextBox_ShortcutBlueDec.Name, (shortcut) => _configuration.Shortcuts.DecrementBlue = shortcut != KeyCombination.PRESS_KEY_COMBINATION_LABEL ? shortcut : null },

                //OFF
                { TextBox_ShortcutTurnOff.Name, (shortcut) => _configuration.Shortcuts.TurnOff = shortcut != KeyCombination.PRESS_KEY_COMBINATION_LABEL ? shortcut : null }
            };

            shortcutMapByTextboxName.TryGetValue(textBox.Name, out var setShortcut);
            setShortcut?.Invoke(shortCutDescription);
        }
        #endregion

        #region Methods
        private string GetShortcutKeyCombinationDescription(KeyEventArgs e)
        {
            var combination = e.SerializeToString();

            return combination;
        }
        #endregion
    }
}
