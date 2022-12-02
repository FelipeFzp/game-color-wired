namespace GameColor.View.Views
{
    partial class SettingsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            this.Button_Apply = new MetroFramework.Controls.MetroButton();
            this.Button_Cancel = new MetroFramework.Controls.MetroButton();
            this.Toggle_InitializeWithWindows = new MetroFramework.Controls.MetroToggle();
            this.Label_StartWithWindows = new MetroFramework.Controls.MetroLabel();
            this.CheckBox_Red = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBox_Green = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBox_Blue = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Label_KeyboardShortcuts = new MetroFramework.Controls.MetroLabel();
            this.Label_Divider1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_ShortcutRedInc = new MetroFramework.Controls.MetroLabel();
            this.TextBox_ShortcutRedInc = new MetroFramework.Controls.MetroTextBox();
            this.Label_RemoveShortcut = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.TextBox_ShortcutTurnOff = new MetroFramework.Controls.MetroTextBox();
            this.Label_ShortcutTurnOff = new MetroFramework.Controls.MetroLabel();
            this.TextBox_ShortcutBlueDec = new MetroFramework.Controls.MetroTextBox();
            this.Label_ShortcutBlueDec = new MetroFramework.Controls.MetroLabel();
            this.Label_ShortcutBlueInc = new MetroFramework.Controls.MetroLabel();
            this.TextBox_ShortcutBlueInc = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_ShortcutGreenDec = new MetroFramework.Controls.MetroTextBox();
            this.Label_ShortcutGreenDec = new MetroFramework.Controls.MetroLabel();
            this.Label_ShortcutGreenInc = new MetroFramework.Controls.MetroLabel();
            this.TextBox_ShortcutGreenInc = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_ShortcutRedDec = new MetroFramework.Controls.MetroTextBox();
            this.Label_ShortcutRedDec = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Apply
            // 
            this.Button_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Apply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_Apply.Location = new System.Drawing.Point(284, 7);
            this.Button_Apply.Name = "Button_Apply";
            this.Button_Apply.Size = new System.Drawing.Size(56, 28);
            this.Button_Apply.TabIndex = 0;
            this.Button_Apply.Text = "Apply";
            this.Button_Apply.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Button_Apply.Click += new System.EventHandler(this.Button_Apply_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(218, 7);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(56, 28);
            this.Button_Cancel.TabIndex = 1;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Toggle_InitializeWithWindows
            // 
            this.Toggle_InitializeWithWindows.AutoSize = true;
            this.Toggle_InitializeWithWindows.DisplayStatus = false;
            this.Toggle_InitializeWithWindows.Location = new System.Drawing.Point(313, 67);
            this.Toggle_InitializeWithWindows.Name = "Toggle_InitializeWithWindows";
            this.Toggle_InitializeWithWindows.Size = new System.Drawing.Size(50, 17);
            this.Toggle_InitializeWithWindows.TabIndex = 2;
            this.Toggle_InitializeWithWindows.Text = "Off";
            this.Toggle_InitializeWithWindows.UseVisualStyleBackColor = true;
            this.Toggle_InitializeWithWindows.CheckedChanged += new System.EventHandler(this.Toggle_InitializeWithWindows_CheckedChanged);
            // 
            // Label_StartWithWindows
            // 
            this.Label_StartWithWindows.AutoSize = true;
            this.Label_StartWithWindows.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Label_StartWithWindows.Location = new System.Drawing.Point(19, 65);
            this.Label_StartWithWindows.Name = "Label_StartWithWindows";
            this.Label_StartWithWindows.Size = new System.Drawing.Size(201, 19);
            this.Label_StartWithWindows.TabIndex = 3;
            this.Label_StartWithWindows.Text = "Start with windows initialization";
            // 
            // CheckBox_Red
            // 
            this.CheckBox_Red.AutoSize = true;
            this.CheckBox_Red.Location = new System.Drawing.Point(28, 129);
            this.CheckBox_Red.Name = "CheckBox_Red";
            this.CheckBox_Red.Size = new System.Drawing.Size(43, 15);
            this.CheckBox_Red.TabIndex = 4;
            this.CheckBox_Red.Text = "Red";
            this.CheckBox_Red.UseVisualStyleBackColor = true;
            this.CheckBox_Red.CheckedChanged += new System.EventHandler(this.CheckBox_Red_CheckedChanged);
            // 
            // CheckBox_Green
            // 
            this.CheckBox_Green.AutoSize = true;
            this.CheckBox_Green.Location = new System.Drawing.Point(77, 129);
            this.CheckBox_Green.Name = "CheckBox_Green";
            this.CheckBox_Green.Size = new System.Drawing.Size(54, 15);
            this.CheckBox_Green.TabIndex = 5;
            this.CheckBox_Green.Text = "Green";
            this.CheckBox_Green.UseVisualStyleBackColor = true;
            this.CheckBox_Green.CheckedChanged += new System.EventHandler(this.CheckBox_Green_CheckedChanged);
            // 
            // CheckBox_Blue
            // 
            this.CheckBox_Blue.AutoSize = true;
            this.CheckBox_Blue.Location = new System.Drawing.Point(137, 129);
            this.CheckBox_Blue.Name = "CheckBox_Blue";
            this.CheckBox_Blue.Size = new System.Drawing.Size(46, 15);
            this.CheckBox_Blue.TabIndex = 6;
            this.CheckBox_Blue.Text = "Blue";
            this.CheckBox_Blue.UseVisualStyleBackColor = true;
            this.CheckBox_Blue.CheckedChanged += new System.EventHandler(this.CheckBox_Blue_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(17, 103);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(166, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Turn on lights when open";
            // 
            // Label_KeyboardShortcuts
            // 
            this.Label_KeyboardShortcuts.AutoSize = true;
            this.Label_KeyboardShortcuts.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Label_KeyboardShortcuts.Location = new System.Drawing.Point(16, 160);
            this.Label_KeyboardShortcuts.Name = "Label_KeyboardShortcuts";
            this.Label_KeyboardShortcuts.Size = new System.Drawing.Size(129, 19);
            this.Label_KeyboardShortcuts.TabIndex = 8;
            this.Label_KeyboardShortcuts.Text = "Keyboard Shortcuts";
            // 
            // Label_Divider1
            // 
            this.Label_Divider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label_Divider1.Location = new System.Drawing.Point(11, 98);
            this.Label_Divider1.Name = "Label_Divider1";
            this.Label_Divider1.Size = new System.Drawing.Size(351, 2);
            this.Label_Divider1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 2);
            this.label1.TabIndex = 11;
            // 
            // Label_ShortcutRedInc
            // 
            this.Label_ShortcutRedInc.AutoSize = true;
            this.Label_ShortcutRedInc.Location = new System.Drawing.Point(3, 12);
            this.Label_ShortcutRedInc.Name = "Label_ShortcutRedInc";
            this.Label_ShortcutRedInc.Size = new System.Drawing.Size(108, 19);
            this.Label_ShortcutRedInc.TabIndex = 13;
            this.Label_ShortcutRedInc.Text = "Red Brightness +";
            // 
            // TextBox_ShortcutRedInc
            // 
            this.TextBox_ShortcutRedInc.Location = new System.Drawing.Point(157, 10);
            this.TextBox_ShortcutRedInc.Name = "TextBox_ShortcutRedInc";
            this.TextBox_ShortcutRedInc.ReadOnly = true;
            this.TextBox_ShortcutRedInc.Size = new System.Drawing.Size(177, 23);
            this.TextBox_ShortcutRedInc.TabIndex = 17;
            this.TextBox_ShortcutRedInc.Text = "Press a key combination";
            this.TextBox_ShortcutRedInc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_Shortcut_KeyDown);
            // 
            // Label_RemoveShortcut
            // 
            this.Label_RemoveShortcut.AutoSize = true;
            this.Label_RemoveShortcut.BackColor = System.Drawing.Color.White;
            this.Label_RemoveShortcut.FontSize = MetroFramework.MetroLabelSize.Small;
            this.Label_RemoveShortcut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_RemoveShortcut.Location = new System.Drawing.Point(262, 162);
            this.Label_RemoveShortcut.Name = "Label_RemoveShortcut";
            this.Label_RemoveShortcut.Size = new System.Drawing.Size(107, 15);
            this.Label_RemoveShortcut.TabIndex = 22;
            this.Label_RemoveShortcut.Text = "Press ESC to unbind";
            this.Label_RemoveShortcut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.AutoSize = true;
            this.metroPanel1.BackColor = System.Drawing.Color.White;
            this.metroPanel1.Controls.Add(this.TextBox_ShortcutTurnOff);
            this.metroPanel1.Controls.Add(this.Label_ShortcutTurnOff);
            this.metroPanel1.Controls.Add(this.TextBox_ShortcutBlueDec);
            this.metroPanel1.Controls.Add(this.Label_ShortcutBlueDec);
            this.metroPanel1.Controls.Add(this.Label_ShortcutBlueInc);
            this.metroPanel1.Controls.Add(this.TextBox_ShortcutBlueInc);
            this.metroPanel1.Controls.Add(this.TextBox_ShortcutGreenDec);
            this.metroPanel1.Controls.Add(this.Label_ShortcutGreenDec);
            this.metroPanel1.Controls.Add(this.Label_ShortcutGreenInc);
            this.metroPanel1.Controls.Add(this.TextBox_ShortcutGreenInc);
            this.metroPanel1.Controls.Add(this.TextBox_ShortcutRedDec);
            this.metroPanel1.Controls.Add(this.Label_ShortcutRedDec);
            this.metroPanel1.Controls.Add(this.Label_ShortcutRedInc);
            this.metroPanel1.Controls.Add(this.TextBox_ShortcutRedInc);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 183);
            this.metroPanel1.MaximumSize = new System.Drawing.Size(0, 120);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.metroPanel1.Size = new System.Drawing.Size(340, 120);
            this.metroPanel1.TabIndex = 23;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = true;
            this.metroPanel1.VerticalScrollbarSize = 5;
            // 
            // TextBox_ShortcutTurnOff
            // 
            this.TextBox_ShortcutTurnOff.Location = new System.Drawing.Point(157, 195);
            this.TextBox_ShortcutTurnOff.Name = "TextBox_ShortcutTurnOff";
            this.TextBox_ShortcutTurnOff.ReadOnly = true;
            this.TextBox_ShortcutTurnOff.Size = new System.Drawing.Size(177, 23);
            this.TextBox_ShortcutTurnOff.TabIndex = 33;
            this.TextBox_ShortcutTurnOff.Text = "Press a key combination";
            this.TextBox_ShortcutTurnOff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_Shortcut_KeyDown);
            // 
            // Label_ShortcutTurnOff
            // 
            this.Label_ShortcutTurnOff.AutoSize = true;
            this.Label_ShortcutTurnOff.Location = new System.Drawing.Point(3, 197);
            this.Label_ShortcutTurnOff.Name = "Label_ShortcutTurnOff";
            this.Label_ShortcutTurnOff.Size = new System.Drawing.Size(53, 19);
            this.Label_ShortcutTurnOff.TabIndex = 32;
            this.Label_ShortcutTurnOff.Text = "Turn off";
            // 
            // TextBox_ShortcutBlueDec
            // 
            this.TextBox_ShortcutBlueDec.Location = new System.Drawing.Point(158, 164);
            this.TextBox_ShortcutBlueDec.Name = "TextBox_ShortcutBlueDec";
            this.TextBox_ShortcutBlueDec.ReadOnly = true;
            this.TextBox_ShortcutBlueDec.Size = new System.Drawing.Size(177, 23);
            this.TextBox_ShortcutBlueDec.TabIndex = 31;
            this.TextBox_ShortcutBlueDec.Text = "Press a key combination";
            this.TextBox_ShortcutBlueDec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_Shortcut_KeyDown);
            // 
            // Label_ShortcutBlueDec
            // 
            this.Label_ShortcutBlueDec.AutoSize = true;
            this.Label_ShortcutBlueDec.Location = new System.Drawing.Point(4, 166);
            this.Label_ShortcutBlueDec.Name = "Label_ShortcutBlueDec";
            this.Label_ShortcutBlueDec.Size = new System.Drawing.Size(107, 19);
            this.Label_ShortcutBlueDec.TabIndex = 30;
            this.Label_ShortcutBlueDec.Text = "Blue Brightness -";
            // 
            // Label_ShortcutBlueInc
            // 
            this.Label_ShortcutBlueInc.AutoSize = true;
            this.Label_ShortcutBlueInc.Location = new System.Drawing.Point(4, 136);
            this.Label_ShortcutBlueInc.Name = "Label_ShortcutBlueInc";
            this.Label_ShortcutBlueInc.Size = new System.Drawing.Size(110, 19);
            this.Label_ShortcutBlueInc.TabIndex = 28;
            this.Label_ShortcutBlueInc.Text = "Blue Brightness +";
            // 
            // TextBox_ShortcutBlueInc
            // 
            this.TextBox_ShortcutBlueInc.Location = new System.Drawing.Point(158, 134);
            this.TextBox_ShortcutBlueInc.Name = "TextBox_ShortcutBlueInc";
            this.TextBox_ShortcutBlueInc.ReadOnly = true;
            this.TextBox_ShortcutBlueInc.Size = new System.Drawing.Size(177, 23);
            this.TextBox_ShortcutBlueInc.TabIndex = 29;
            this.TextBox_ShortcutBlueInc.Text = "Press a key combination";
            this.TextBox_ShortcutBlueInc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_Shortcut_KeyDown);
            // 
            // TextBox_ShortcutGreenDec
            // 
            this.TextBox_ShortcutGreenDec.Location = new System.Drawing.Point(158, 101);
            this.TextBox_ShortcutGreenDec.Name = "TextBox_ShortcutGreenDec";
            this.TextBox_ShortcutGreenDec.ReadOnly = true;
            this.TextBox_ShortcutGreenDec.Size = new System.Drawing.Size(177, 23);
            this.TextBox_ShortcutGreenDec.TabIndex = 27;
            this.TextBox_ShortcutGreenDec.Text = "Press a key combination";
            this.TextBox_ShortcutGreenDec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_Shortcut_KeyDown);
            // 
            // Label_ShortcutGreenDec
            // 
            this.Label_ShortcutGreenDec.AutoSize = true;
            this.Label_ShortcutGreenDec.Location = new System.Drawing.Point(4, 103);
            this.Label_ShortcutGreenDec.Name = "Label_ShortcutGreenDec";
            this.Label_ShortcutGreenDec.Size = new System.Drawing.Size(117, 19);
            this.Label_ShortcutGreenDec.TabIndex = 26;
            this.Label_ShortcutGreenDec.Text = "Green Brightness -";
            // 
            // Label_ShortcutGreenInc
            // 
            this.Label_ShortcutGreenInc.AutoSize = true;
            this.Label_ShortcutGreenInc.Location = new System.Drawing.Point(4, 73);
            this.Label_ShortcutGreenInc.Name = "Label_ShortcutGreenInc";
            this.Label_ShortcutGreenInc.Size = new System.Drawing.Size(120, 19);
            this.Label_ShortcutGreenInc.TabIndex = 24;
            this.Label_ShortcutGreenInc.Text = "Green Brightness +";
            // 
            // TextBox_ShortcutGreenInc
            // 
            this.TextBox_ShortcutGreenInc.Location = new System.Drawing.Point(158, 71);
            this.TextBox_ShortcutGreenInc.Name = "TextBox_ShortcutGreenInc";
            this.TextBox_ShortcutGreenInc.ReadOnly = true;
            this.TextBox_ShortcutGreenInc.Size = new System.Drawing.Size(177, 23);
            this.TextBox_ShortcutGreenInc.TabIndex = 25;
            this.TextBox_ShortcutGreenInc.Text = "Press a key combination";
            this.TextBox_ShortcutGreenInc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_Shortcut_KeyDown);
            // 
            // TextBox_ShortcutRedDec
            // 
            this.TextBox_ShortcutRedDec.Location = new System.Drawing.Point(157, 40);
            this.TextBox_ShortcutRedDec.Name = "TextBox_ShortcutRedDec";
            this.TextBox_ShortcutRedDec.ReadOnly = true;
            this.TextBox_ShortcutRedDec.Size = new System.Drawing.Size(177, 23);
            this.TextBox_ShortcutRedDec.TabIndex = 23;
            this.TextBox_ShortcutRedDec.Text = "Press a key combination";
            this.TextBox_ShortcutRedDec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_Shortcut_KeyDown);
            // 
            // Label_ShortcutRedDec
            // 
            this.Label_ShortcutRedDec.AutoSize = true;
            this.Label_ShortcutRedDec.Location = new System.Drawing.Point(3, 42);
            this.Label_ShortcutRedDec.Name = "Label_ShortcutRedDec";
            this.Label_ShortcutRedDec.Size = new System.Drawing.Size(105, 19);
            this.Label_ShortcutRedDec.TabIndex = 22;
            this.Label_ShortcutRedDec.Text = "Red Brightness -";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Button_Apply);
            this.panel1.Controls.Add(this.Button_Cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 35);
            this.panel1.TabIndex = 24;
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 353);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Label_RemoveShortcut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_Divider1);
            this.Controls.Add(this.Label_KeyboardShortcuts);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CheckBox_Blue);
            this.Controls.Add(this.CheckBox_Green);
            this.Controls.Add(this.CheckBox_Red);
            this.Controls.Add(this.Label_StartWithWindows);
            this.Controls.Add(this.Toggle_InitializeWithWindows);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsDialog";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 15, 15);
            this.Resizable = false;
            this.Text = "Advanced Settings";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Button_Apply;
        private MetroFramework.Controls.MetroButton Button_Cancel;
        private MetroFramework.Controls.MetroToggle Toggle_InitializeWithWindows;
        private MetroFramework.Controls.MetroLabel Label_StartWithWindows;
        private MetroFramework.Controls.MetroCheckBox CheckBox_Red;
        private MetroFramework.Controls.MetroCheckBox CheckBox_Green;
        private MetroFramework.Controls.MetroCheckBox CheckBox_Blue;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel Label_KeyboardShortcuts;
        private System.Windows.Forms.Label Label_Divider1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel Label_ShortcutRedInc;
        private MetroFramework.Controls.MetroTextBox TextBox_ShortcutRedInc;
        private MetroFramework.Controls.MetroLabel Label_RemoveShortcut;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox TextBox_ShortcutRedDec;
        private MetroFramework.Controls.MetroLabel Label_ShortcutRedDec;
        private MetroFramework.Controls.MetroTextBox TextBox_ShortcutBlueDec;
        private MetroFramework.Controls.MetroLabel Label_ShortcutBlueDec;
        private MetroFramework.Controls.MetroLabel Label_ShortcutBlueInc;
        private MetroFramework.Controls.MetroTextBox TextBox_ShortcutBlueInc;
        private MetroFramework.Controls.MetroTextBox TextBox_ShortcutGreenDec;
        private MetroFramework.Controls.MetroLabel Label_ShortcutGreenDec;
        private MetroFramework.Controls.MetroLabel Label_ShortcutGreenInc;
        private MetroFramework.Controls.MetroTextBox TextBox_ShortcutGreenInc;
        private MetroFramework.Controls.MetroTextBox TextBox_ShortcutTurnOff;
        private MetroFramework.Controls.MetroLabel Label_ShortcutTurnOff;
    }
}