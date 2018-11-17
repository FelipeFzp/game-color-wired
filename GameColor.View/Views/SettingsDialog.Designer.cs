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
            this.Label_ShortcutRed = new MetroFramework.Controls.MetroLabel();
            this.Label_ShortcutBlue = new MetroFramework.Controls.MetroLabel();
            this.Label_ShortcutGreen = new MetroFramework.Controls.MetroLabel();
            this.TextBox_ShortcutRed = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_ShortcutGreen = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_ShortcutBlue = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_ShortcutTurnOff = new MetroFramework.Controls.MetroTextBox();
            this.Label_ShortcutTurnOff = new MetroFramework.Controls.MetroLabel();
            this.Label_RemoveShortcut = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // Button_Apply
            // 
            this.Button_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Apply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_Apply.Location = new System.Drawing.Point(308, 311);
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
            this.Button_Cancel.Location = new System.Drawing.Point(245, 311);
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
            this.Toggle_InitializeWithWindows.Location = new System.Drawing.Point(308, 67);
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
            this.Label_StartWithWindows.Location = new System.Drawing.Point(14, 65);
            this.Label_StartWithWindows.Name = "Label_StartWithWindows";
            this.Label_StartWithWindows.Size = new System.Drawing.Size(201, 19);
            this.Label_StartWithWindows.TabIndex = 3;
            this.Label_StartWithWindows.Text = "Start with windows initialization";
            // 
            // CheckBox_Red
            // 
            this.CheckBox_Red.AutoSize = true;
            this.CheckBox_Red.Location = new System.Drawing.Point(23, 135);
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
            this.CheckBox_Green.Location = new System.Drawing.Point(72, 135);
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
            this.CheckBox_Blue.Location = new System.Drawing.Point(132, 135);
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
            this.metroLabel1.Location = new System.Drawing.Point(12, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(166, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Turn on lights when open";
            // 
            // Label_KeyboardShortcuts
            // 
            this.Label_KeyboardShortcuts.AutoSize = true;
            this.Label_KeyboardShortcuts.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Label_KeyboardShortcuts.Location = new System.Drawing.Point(19, 166);
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
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 2);
            this.label1.TabIndex = 11;
            // 
            // Label_ShortcutRed
            // 
            this.Label_ShortcutRed.AutoSize = true;
            this.Label_ShortcutRed.Location = new System.Drawing.Point(23, 197);
            this.Label_ShortcutRed.Name = "Label_ShortcutRed";
            this.Label_ShortcutRed.Size = new System.Drawing.Size(79, 19);
            this.Label_ShortcutRed.TabIndex = 13;
            this.Label_ShortcutRed.Text = "Turn on Red";
            // 
            // Label_ShortcutBlue
            // 
            this.Label_ShortcutBlue.AutoSize = true;
            this.Label_ShortcutBlue.Location = new System.Drawing.Point(23, 247);
            this.Label_ShortcutBlue.Name = "Label_ShortcutBlue";
            this.Label_ShortcutBlue.Size = new System.Drawing.Size(81, 19);
            this.Label_ShortcutBlue.TabIndex = 9;
            this.Label_ShortcutBlue.Text = "Turn on Blue";
            // 
            // Label_ShortcutGreen
            // 
            this.Label_ShortcutGreen.AutoSize = true;
            this.Label_ShortcutGreen.Location = new System.Drawing.Point(23, 222);
            this.Label_ShortcutGreen.Name = "Label_ShortcutGreen";
            this.Label_ShortcutGreen.Size = new System.Drawing.Size(91, 19);
            this.Label_ShortcutGreen.TabIndex = 15;
            this.Label_ShortcutGreen.Text = "Turn on Green";
            // 
            // TextBox_ShortcutRed
            // 
            this.TextBox_ShortcutRed.Location = new System.Drawing.Point(187, 195);
            this.TextBox_ShortcutRed.Name = "TextBox_ShortcutRed";
            this.TextBox_ShortcutRed.ReadOnly = true;
            this.TextBox_ShortcutRed.Size = new System.Drawing.Size(177, 23);
            this.TextBox_ShortcutRed.TabIndex = 17;
            this.TextBox_ShortcutRed.Text = "Press a key combination";
            this.TextBox_ShortcutRed.Click += new System.EventHandler(this.TextBox_ShortcutRed_Click);
            this.TextBox_ShortcutRed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_ShortcutRed_KeyDown);
            // 
            // TextBox_ShortcutGreen
            // 
            this.TextBox_ShortcutGreen.Location = new System.Drawing.Point(187, 220);
            this.TextBox_ShortcutGreen.Name = "TextBox_ShortcutGreen";
            this.TextBox_ShortcutGreen.ReadOnly = true;
            this.TextBox_ShortcutGreen.Size = new System.Drawing.Size(177, 23);
            this.TextBox_ShortcutGreen.TabIndex = 18;
            this.TextBox_ShortcutGreen.Text = "Press a key combination";
            this.TextBox_ShortcutGreen.Click += new System.EventHandler(this.TextBox_ShortcutGreen_Click);
            this.TextBox_ShortcutGreen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_ShortcutGreen_KeyDown);
            // 
            // TextBox_ShortcutBlue
            // 
            this.TextBox_ShortcutBlue.Location = new System.Drawing.Point(187, 245);
            this.TextBox_ShortcutBlue.Name = "TextBox_ShortcutBlue";
            this.TextBox_ShortcutBlue.ReadOnly = true;
            this.TextBox_ShortcutBlue.Size = new System.Drawing.Size(177, 23);
            this.TextBox_ShortcutBlue.TabIndex = 19;
            this.TextBox_ShortcutBlue.Text = "Press a key combination";
            this.TextBox_ShortcutBlue.Click += new System.EventHandler(this.TextBox_ShortcutBlue_Click);
            this.TextBox_ShortcutBlue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_ShortcutBlue_KeyDown);
            // 
            // TextBox_ShortcutTurnOff
            // 
            this.TextBox_ShortcutTurnOff.Location = new System.Drawing.Point(187, 270);
            this.TextBox_ShortcutTurnOff.Name = "TextBox_ShortcutTurnOff";
            this.TextBox_ShortcutTurnOff.ReadOnly = true;
            this.TextBox_ShortcutTurnOff.Size = new System.Drawing.Size(177, 23);
            this.TextBox_ShortcutTurnOff.TabIndex = 21;
            this.TextBox_ShortcutTurnOff.Text = "Press a key combination";
            this.TextBox_ShortcutTurnOff.Click += new System.EventHandler(this.TextBox_ShortcutTurnOff_Click);
            this.TextBox_ShortcutTurnOff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_ShortcutTurnOff_KeyDown);
            // 
            // Label_ShortcutTurnOff
            // 
            this.Label_ShortcutTurnOff.AutoSize = true;
            this.Label_ShortcutTurnOff.Location = new System.Drawing.Point(23, 270);
            this.Label_ShortcutTurnOff.Name = "Label_ShortcutTurnOff";
            this.Label_ShortcutTurnOff.Size = new System.Drawing.Size(53, 19);
            this.Label_ShortcutTurnOff.TabIndex = 20;
            this.Label_ShortcutTurnOff.Text = "Turn off";
            // 
            // Label_RemoveShortcut
            // 
            this.Label_RemoveShortcut.AutoSize = true;
            this.Label_RemoveShortcut.BackColor = System.Drawing.Color.White;
            this.Label_RemoveShortcut.FontSize = MetroFramework.MetroLabelSize.Small;
            this.Label_RemoveShortcut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_RemoveShortcut.Location = new System.Drawing.Point(257, 168);
            this.Label_RemoveShortcut.Name = "Label_RemoveShortcut";
            this.Label_RemoveShortcut.Size = new System.Drawing.Size(107, 15);
            this.Label_RemoveShortcut.TabIndex = 22;
            this.Label_RemoveShortcut.Text = "Press ESC to unbind";
            this.Label_RemoveShortcut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 353);
            this.Controls.Add(this.Label_RemoveShortcut);
            this.Controls.Add(this.TextBox_ShortcutTurnOff);
            this.Controls.Add(this.Label_ShortcutTurnOff);
            this.Controls.Add(this.TextBox_ShortcutBlue);
            this.Controls.Add(this.TextBox_ShortcutGreen);
            this.Controls.Add(this.TextBox_ShortcutRed);
            this.Controls.Add(this.Label_ShortcutGreen);
            this.Controls.Add(this.Label_ShortcutRed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_Divider1);
            this.Controls.Add(this.Label_ShortcutBlue);
            this.Controls.Add(this.Label_KeyboardShortcuts);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CheckBox_Blue);
            this.Controls.Add(this.CheckBox_Green);
            this.Controls.Add(this.CheckBox_Red);
            this.Controls.Add(this.Label_StartWithWindows);
            this.Controls.Add(this.Toggle_InitializeWithWindows);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Apply);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsDialog";
            this.Resizable = false;
            this.Text = "Advanced Settings";
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
        private MetroFramework.Controls.MetroLabel Label_ShortcutRed;
        private MetroFramework.Controls.MetroLabel Label_ShortcutBlue;
        private MetroFramework.Controls.MetroLabel Label_ShortcutGreen;
        private MetroFramework.Controls.MetroTextBox TextBox_ShortcutRed;
        private MetroFramework.Controls.MetroTextBox TextBox_ShortcutGreen;
        private MetroFramework.Controls.MetroTextBox TextBox_ShortcutBlue;
        private MetroFramework.Controls.MetroTextBox TextBox_ShortcutTurnOff;
        private MetroFramework.Controls.MetroLabel Label_ShortcutTurnOff;
        private MetroFramework.Controls.MetroLabel Label_RemoveShortcut;
    }
}