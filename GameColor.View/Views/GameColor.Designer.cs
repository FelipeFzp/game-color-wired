namespace GameColor.View.Views
{
    partial class GameColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameColor));
            this.TabControl_Presets = new MetroFramework.Controls.MetroTabControl();
            this.Tab_UserPreset = new MetroFramework.Controls.MetroTabPage();
            this.Checkbox_Blue = new MetroFramework.Controls.MetroCheckBox();
            this.Checkbox_Green = new MetroFramework.Controls.MetroCheckBox();
            this.Checkbox_Red = new MetroFramework.Controls.MetroCheckBox();
            this.Tab_GamePreset = new MetroFramework.Controls.MetroTabPage();
            this.ListView_UserLog = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComboBox_GamePreset = new MetroFramework.Controls.MetroComboBox();
            this.Button_StartGamePreset = new System.Windows.Forms.Button();
            this.ComboBox_Ports = new MetroFramework.Controls.MetroComboBox();
            this.Label_PortErrorMessage = new System.Windows.Forms.Label();
            this.TabControl_Presets.SuspendLayout();
            this.Tab_UserPreset.SuspendLayout();
            this.Tab_GamePreset.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_Presets
            // 
            this.TabControl_Presets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_Presets.Controls.Add(this.Tab_UserPreset);
            this.TabControl_Presets.Controls.Add(this.Tab_GamePreset);
            this.TabControl_Presets.Location = new System.Drawing.Point(0, 63);
            this.TabControl_Presets.Name = "TabControl_Presets";
            this.TabControl_Presets.SelectedIndex = 1;
            this.TabControl_Presets.Size = new System.Drawing.Size(335, 235);
            this.TabControl_Presets.TabIndex = 0;
            this.TabControl_Presets.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControl_Presets_Selecting);
            // 
            // Tab_UserPreset
            // 
            this.Tab_UserPreset.Controls.Add(this.Checkbox_Blue);
            this.Tab_UserPreset.Controls.Add(this.Checkbox_Green);
            this.Tab_UserPreset.Controls.Add(this.Checkbox_Red);
            this.Tab_UserPreset.HorizontalScrollbarBarColor = true;
            this.Tab_UserPreset.Location = new System.Drawing.Point(4, 35);
            this.Tab_UserPreset.Name = "Tab_UserPreset";
            this.Tab_UserPreset.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Tab_UserPreset.Size = new System.Drawing.Size(322, 196);
            this.Tab_UserPreset.TabIndex = 0;
            this.Tab_UserPreset.Text = "User Preset";
            this.Tab_UserPreset.VerticalScrollbarBarColor = true;
            // 
            // Checkbox_Blue
            // 
            this.Checkbox_Blue.AutoSize = true;
            this.Checkbox_Blue.Enabled = false;
            this.Checkbox_Blue.Location = new System.Drawing.Point(19, 87);
            this.Checkbox_Blue.Name = "Checkbox_Blue";
            this.Checkbox_Blue.Size = new System.Drawing.Size(46, 15);
            this.Checkbox_Blue.TabIndex = 4;
            this.Checkbox_Blue.Text = "Blue";
            this.Checkbox_Blue.UseVisualStyleBackColor = true;
            this.Checkbox_Blue.CheckedChanged += new System.EventHandler(this.Checkbox_Blue_CheckedChanged);
            // 
            // Checkbox_Green
            // 
            this.Checkbox_Green.AutoSize = true;
            this.Checkbox_Green.Enabled = false;
            this.Checkbox_Green.Location = new System.Drawing.Point(19, 51);
            this.Checkbox_Green.Name = "Checkbox_Green";
            this.Checkbox_Green.Size = new System.Drawing.Size(54, 15);
            this.Checkbox_Green.TabIndex = 3;
            this.Checkbox_Green.Text = "Green";
            this.Checkbox_Green.UseVisualStyleBackColor = true;
            this.Checkbox_Green.CheckedChanged += new System.EventHandler(this.Checkbox_Green_CheckedChanged);
            // 
            // Checkbox_Red
            // 
            this.Checkbox_Red.AutoSize = true;
            this.Checkbox_Red.Enabled = false;
            this.Checkbox_Red.Location = new System.Drawing.Point(19, 17);
            this.Checkbox_Red.Name = "Checkbox_Red";
            this.Checkbox_Red.Size = new System.Drawing.Size(43, 15);
            this.Checkbox_Red.TabIndex = 2;
            this.Checkbox_Red.Text = "Red";
            this.Checkbox_Red.UseVisualStyleBackColor = true;
            this.Checkbox_Red.CheckedChanged += new System.EventHandler(this.Checkbox_Red_CheckedChanged);
            // 
            // Tab_GamePreset
            // 
            this.Tab_GamePreset.Controls.Add(this.ListView_UserLog);
            this.Tab_GamePreset.Controls.Add(this.ComboBox_GamePreset);
            this.Tab_GamePreset.Controls.Add(this.Button_StartGamePreset);
            this.Tab_GamePreset.HorizontalScrollbarBarColor = true;
            this.Tab_GamePreset.Location = new System.Drawing.Point(4, 35);
            this.Tab_GamePreset.Name = "Tab_GamePreset";
            this.Tab_GamePreset.Size = new System.Drawing.Size(327, 196);
            this.Tab_GamePreset.TabIndex = 1;
            this.Tab_GamePreset.Text = "Game Preset";
            this.Tab_GamePreset.VerticalScrollbarBarColor = true;
            // 
            // ListView_UserLog
            // 
            this.ListView_UserLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_UserLog.BackColor = System.Drawing.Color.SlateGray;
            this.ListView_UserLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ListView_UserLog.ForeColor = System.Drawing.Color.White;
            this.ListView_UserLog.FullRowSelect = true;
            this.ListView_UserLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListView_UserLog.LabelWrap = false;
            this.ListView_UserLog.Location = new System.Drawing.Point(7, 47);
            this.ListView_UserLog.Name = "ListView_UserLog";
            this.ListView_UserLog.Size = new System.Drawing.Size(312, 144);
            this.ListView_UserLog.TabIndex = 5;
            this.ListView_UserLog.UseCompatibleStateImageBehavior = false;
            this.ListView_UserLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 307;
            // 
            // ComboBox_GamePreset
            // 
            this.ComboBox_GamePreset.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.ComboBox_GamePreset.DisplayMember = "fs";
            this.ComboBox_GamePreset.FormattingEnabled = true;
            this.ComboBox_GamePreset.ItemHeight = 23;
            this.ComboBox_GamePreset.Items.AddRange(new object[] {
            "",
            "Fortnite",
            "Minecraft"});
            this.ComboBox_GamePreset.Location = new System.Drawing.Point(7, 12);
            this.ComboBox_GamePreset.Name = "ComboBox_GamePreset";
            this.ComboBox_GamePreset.Size = new System.Drawing.Size(206, 29);
            this.ComboBox_GamePreset.Sorted = true;
            this.ComboBox_GamePreset.TabIndex = 1;
            // 
            // Button_StartGamePreset
            // 
            this.Button_StartGamePreset.Enabled = false;
            this.Button_StartGamePreset.Location = new System.Drawing.Point(241, 15);
            this.Button_StartGamePreset.Name = "Button_StartGamePreset";
            this.Button_StartGamePreset.Size = new System.Drawing.Size(73, 23);
            this.Button_StartGamePreset.TabIndex = 3;
            this.Button_StartGamePreset.Text = "Start";
            this.Button_StartGamePreset.UseVisualStyleBackColor = true;
            this.Button_StartGamePreset.Click += new System.EventHandler(this.Button_StartGamePreset_Click);
            // 
            // ComboBox_Ports
            // 
            this.ComboBox_Ports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Ports.DisplayMember = "Ports";
            this.ComboBox_Ports.FormattingEnabled = true;
            this.ComboBox_Ports.ItemHeight = 23;
            this.ComboBox_Ports.Location = new System.Drawing.Point(250, 25);
            this.ComboBox_Ports.Name = "ComboBox_Ports";
            this.ComboBox_Ports.Size = new System.Drawing.Size(73, 29);
            this.ComboBox_Ports.TabIndex = 5;
            this.ComboBox_Ports.ValueMember = "Ports";
            this.ComboBox_Ports.SelectedValueChanged += new System.EventHandler(this.ComboBox_Ports_SelectedValueChanged);
            this.ComboBox_Ports.Click += new System.EventHandler(this.ComboBox_Ports_Click);
            // 
            // Label_PortErrorMessage
            // 
            this.Label_PortErrorMessage.AutoSize = true;
            this.Label_PortErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.Label_PortErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.Label_PortErrorMessage.Location = new System.Drawing.Point(245, 57);
            this.Label_PortErrorMessage.Name = "Label_PortErrorMessage";
            this.Label_PortErrorMessage.Size = new System.Drawing.Size(73, 13);
            this.Label_PortErrorMessage.TabIndex = 5;
            this.Label_PortErrorMessage.Text = "Select an port";
            // 
            // GameColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 298);
            this.Controls.Add(this.Label_PortErrorMessage);
            this.Controls.Add(this.ComboBox_Ports);
            this.Controls.Add(this.TabControl_Presets);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(335, 298);
            this.Name = "GameColor";
            this.Text = "Game Color";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameColor_FormClosing);
            this.TabControl_Presets.ResumeLayout(false);
            this.Tab_UserPreset.ResumeLayout(false);
            this.Tab_UserPreset.PerformLayout();
            this.Tab_GamePreset.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControl_Presets;
        private MetroFramework.Controls.MetroTabPage Tab_UserPreset;
        private MetroFramework.Controls.MetroTabPage Tab_GamePreset;
        private MetroFramework.Controls.MetroCheckBox Checkbox_Blue;
        private MetroFramework.Controls.MetroCheckBox Checkbox_Green;
        private MetroFramework.Controls.MetroCheckBox Checkbox_Red;
        private System.Windows.Forms.Button Button_StartGamePreset;
        private MetroFramework.Controls.MetroComboBox ComboBox_GamePreset;
        private MetroFramework.Controls.MetroComboBox ComboBox_Ports;
        private System.Windows.Forms.Label Label_PortErrorMessage;
        private System.Windows.Forms.ListView ListView_UserLog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}