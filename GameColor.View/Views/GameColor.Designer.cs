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
            this.Tab_Home = new MetroFramework.Controls.MetroTabPage();
            this.Tile_PresetsGenerator = new MetroFramework.Controls.MetroTile();
            this.Button_LaunchPresetsCreator = new System.Windows.Forms.Button();
            this.Tile_Informations = new MetroFramework.Controls.MetroTile();
            this.Tile_Settings = new MetroFramework.Controls.MetroTile();
            this.Button_LaunchSettings = new System.Windows.Forms.Button();
            this.Tab_GamePreset = new MetroFramework.Controls.MetroTabPage();
            this.ListView_UserLog = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComboBox_GamePreset = new MetroFramework.Controls.MetroComboBox();
            this.Button_StartGamePreset = new System.Windows.Forms.Button();
            this.Tab_UserPreset = new MetroFramework.Controls.MetroTabPage();
            this.ComboBox_Ports = new MetroFramework.Controls.MetroComboBox();
            this.Label_PortErrorMessage = new System.Windows.Forms.Label();
            this.Label_Slogan = new MetroFramework.Controls.MetroLabel();
            this.TrackBar_Red = new MetroFramework.Controls.MetroTrackBar();
            this.TrackBar_Green = new MetroFramework.Controls.MetroTrackBar();
            this.TrackBar_Blue = new MetroFramework.Controls.MetroTrackBar();
            this.Label_Red = new MetroFramework.Controls.MetroLabel();
            this.Label_Green = new MetroFramework.Controls.MetroLabel();
            this.Label_Blue = new MetroFramework.Controls.MetroLabel();
            this.TabControl_Presets.SuspendLayout();
            this.Tab_Home.SuspendLayout();
            this.Tile_PresetsGenerator.SuspendLayout();
            this.Tile_Settings.SuspendLayout();
            this.Tab_GamePreset.SuspendLayout();
            this.Tab_UserPreset.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_Presets
            // 
            this.TabControl_Presets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_Presets.Controls.Add(this.Tab_Home);
            this.TabControl_Presets.Controls.Add(this.Tab_GamePreset);
            this.TabControl_Presets.Controls.Add(this.Tab_UserPreset);
            this.TabControl_Presets.Location = new System.Drawing.Point(0, 76);
            this.TabControl_Presets.Name = "TabControl_Presets";
            this.TabControl_Presets.SelectedIndex = 2;
            this.TabControl_Presets.Size = new System.Drawing.Size(335, 242);
            this.TabControl_Presets.TabIndex = 0;
            this.TabControl_Presets.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControl_Presets_Selecting);
            this.TabControl_Presets.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TabControl_Presets_KeyDown);
            // 
            // Tab_Home
            // 
            this.Tab_Home.Controls.Add(this.Tile_PresetsGenerator);
            this.Tab_Home.Controls.Add(this.Tile_Informations);
            this.Tab_Home.Controls.Add(this.Tile_Settings);
            this.Tab_Home.HorizontalScrollbarBarColor = true;
            this.Tab_Home.Location = new System.Drawing.Point(4, 35);
            this.Tab_Home.Name = "Tab_Home";
            this.Tab_Home.Size = new System.Drawing.Size(327, 203);
            this.Tab_Home.TabIndex = 2;
            this.Tab_Home.Text = "Home";
            this.Tab_Home.VerticalScrollbarBarColor = true;
            // 
            // Tile_PresetsGenerator
            // 
            this.Tile_PresetsGenerator.Controls.Add(this.Button_LaunchPresetsCreator);
            this.Tile_PresetsGenerator.Location = new System.Drawing.Point(3, 103);
            this.Tile_PresetsGenerator.Name = "Tile_PresetsGenerator";
            this.Tile_PresetsGenerator.Size = new System.Drawing.Size(182, 97);
            this.Tile_PresetsGenerator.TabIndex = 4;
            this.Tile_PresetsGenerator.Text = "Game Presets Creator";
            this.Tile_PresetsGenerator.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Tile_PresetsGenerator.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // Button_LaunchPresetsCreator
            // 
            this.Button_LaunchPresetsCreator.BackColor = System.Drawing.Color.Transparent;
            this.Button_LaunchPresetsCreator.BackgroundImage = global::GameColor.View.Properties.Resources.Launch_icon;
            this.Button_LaunchPresetsCreator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_LaunchPresetsCreator.FlatAppearance.BorderSize = 0;
            this.Button_LaunchPresetsCreator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_LaunchPresetsCreator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_LaunchPresetsCreator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_LaunchPresetsCreator.ForeColor = System.Drawing.Color.Transparent;
            this.Button_LaunchPresetsCreator.Location = new System.Drawing.Point(159, 1);
            this.Button_LaunchPresetsCreator.Name = "Button_LaunchPresetsCreator";
            this.Button_LaunchPresetsCreator.Size = new System.Drawing.Size(20, 20);
            this.Button_LaunchPresetsCreator.TabIndex = 0;
            this.Button_LaunchPresetsCreator.UseVisualStyleBackColor = false;
            // 
            // Tile_Informations
            // 
            this.Tile_Informations.Location = new System.Drawing.Point(191, 5);
            this.Tile_Informations.Name = "Tile_Informations";
            this.Tile_Informations.Size = new System.Drawing.Size(133, 195);
            this.Tile_Informations.TabIndex = 3;
            this.Tile_Informations.Text = "Informations";
            this.Tile_Informations.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Tile_Informations.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // Tile_Settings
            // 
            this.Tile_Settings.Controls.Add(this.Button_LaunchSettings);
            this.Tile_Settings.Location = new System.Drawing.Point(3, 5);
            this.Tile_Settings.Name = "Tile_Settings";
            this.Tile_Settings.Size = new System.Drawing.Size(182, 92);
            this.Tile_Settings.TabIndex = 2;
            this.Tile_Settings.Text = "Advanced Settings";
            this.Tile_Settings.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Tile_Settings.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Tile_Settings.Click += new System.EventHandler(this.Tile_Settings_Click);
            // 
            // Button_LaunchSettings
            // 
            this.Button_LaunchSettings.BackColor = System.Drawing.Color.Transparent;
            this.Button_LaunchSettings.BackgroundImage = global::GameColor.View.Properties.Resources.Launch_icon;
            this.Button_LaunchSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_LaunchSettings.FlatAppearance.BorderSize = 0;
            this.Button_LaunchSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_LaunchSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_LaunchSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_LaunchSettings.ForeColor = System.Drawing.Color.Transparent;
            this.Button_LaunchSettings.Location = new System.Drawing.Point(160, 1);
            this.Button_LaunchSettings.Name = "Button_LaunchSettings";
            this.Button_LaunchSettings.Size = new System.Drawing.Size(20, 20);
            this.Button_LaunchSettings.TabIndex = 0;
            this.Button_LaunchSettings.UseVisualStyleBackColor = false;
            this.Button_LaunchSettings.Click += new System.EventHandler(this.Tile_Settings_Click);
            // 
            // Tab_GamePreset
            // 
            this.Tab_GamePreset.Controls.Add(this.ListView_UserLog);
            this.Tab_GamePreset.Controls.Add(this.ComboBox_GamePreset);
            this.Tab_GamePreset.Controls.Add(this.Button_StartGamePreset);
            this.Tab_GamePreset.HorizontalScrollbarBarColor = true;
            this.Tab_GamePreset.Location = new System.Drawing.Point(4, 35);
            this.Tab_GamePreset.Name = "Tab_GamePreset";
            this.Tab_GamePreset.Size = new System.Drawing.Size(327, 203);
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
            this.ListView_UserLog.HideSelection = false;
            this.ListView_UserLog.LabelWrap = false;
            this.ListView_UserLog.Location = new System.Drawing.Point(7, 47);
            this.ListView_UserLog.MinimumSize = new System.Drawing.Size(312, 153);
            this.ListView_UserLog.Name = "ListView_UserLog";
            this.ListView_UserLog.Size = new System.Drawing.Size(312, 153);
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
            // Tab_UserPreset
            // 
            this.Tab_UserPreset.Controls.Add(this.Label_Blue);
            this.Tab_UserPreset.Controls.Add(this.Label_Green);
            this.Tab_UserPreset.Controls.Add(this.Label_Red);
            this.Tab_UserPreset.Controls.Add(this.TrackBar_Blue);
            this.Tab_UserPreset.Controls.Add(this.TrackBar_Green);
            this.Tab_UserPreset.Controls.Add(this.TrackBar_Red);
            this.Tab_UserPreset.HorizontalScrollbarBarColor = true;
            this.Tab_UserPreset.Location = new System.Drawing.Point(4, 35);
            this.Tab_UserPreset.Name = "Tab_UserPreset";
            this.Tab_UserPreset.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Tab_UserPreset.Size = new System.Drawing.Size(327, 203);
            this.Tab_UserPreset.TabIndex = 0;
            this.Tab_UserPreset.Text = "User Preset";
            this.Tab_UserPreset.VerticalScrollbarBarColor = true;
            // 
            // ComboBox_Ports
            // 
            this.ComboBox_Ports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Ports.DisplayMember = "Ports";
            this.ComboBox_Ports.FormattingEnabled = true;
            this.ComboBox_Ports.ItemHeight = 23;
            this.ComboBox_Ports.Location = new System.Drawing.Point(250, 28);
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
            this.Label_PortErrorMessage.Location = new System.Drawing.Point(250, 60);
            this.Label_PortErrorMessage.Name = "Label_PortErrorMessage";
            this.Label_PortErrorMessage.Size = new System.Drawing.Size(73, 13);
            this.Label_PortErrorMessage.TabIndex = 5;
            this.Label_PortErrorMessage.Text = "Select an port";
            // 
            // Label_Slogan
            // 
            this.Label_Slogan.AutoSize = true;
            this.Label_Slogan.BackColor = System.Drawing.Color.Transparent;
            this.Label_Slogan.Location = new System.Drawing.Point(24, 47);
            this.Label_Slogan.Name = "Label_Slogan";
            this.Label_Slogan.Size = new System.Drawing.Size(131, 19);
            this.Label_Slogan.TabIndex = 6;
            this.Label_Slogan.Text = "Smart Ambient Light";
            // 
            // TrackBar_Red
            // 
            this.TrackBar_Red.BackColor = System.Drawing.Color.Transparent;
            this.TrackBar_Red.Enabled = false;
            this.TrackBar_Red.Location = new System.Drawing.Point(55, 23);
            this.TrackBar_Red.Maximum = 255;
            this.TrackBar_Red.Name = "TrackBar_Red";
            this.TrackBar_Red.Size = new System.Drawing.Size(252, 23);
            this.TrackBar_Red.TabIndex = 5;
            this.TrackBar_Red.Text = "Red";
            this.TrackBar_Red.Value = 0;
            this.TrackBar_Red.ValueChanged += new System.EventHandler(this.TrackBar_Red_ValueChanged);
            // 
            // TrackBar_Green
            // 
            this.TrackBar_Green.BackColor = System.Drawing.Color.Transparent;
            this.TrackBar_Green.Enabled = false;
            this.TrackBar_Green.Location = new System.Drawing.Point(55, 63);
            this.TrackBar_Green.Maximum = 255;
            this.TrackBar_Green.Name = "TrackBar_Green";
            this.TrackBar_Green.Size = new System.Drawing.Size(252, 23);
            this.TrackBar_Green.TabIndex = 6;
            this.TrackBar_Green.Text = "Green";
            this.TrackBar_Green.Value = 0;
            this.TrackBar_Green.ValueChanged += new System.EventHandler(this.TrackBar_Green_ValueChanged);
            // 
            // TrackBar_Blue
            // 
            this.TrackBar_Blue.BackColor = System.Drawing.Color.Transparent;
            this.TrackBar_Blue.Enabled = false;
            this.TrackBar_Blue.Location = new System.Drawing.Point(55, 105);
            this.TrackBar_Blue.Maximum = 255;
            this.TrackBar_Blue.Name = "TrackBar_Blue";
            this.TrackBar_Blue.Size = new System.Drawing.Size(252, 23);
            this.TrackBar_Blue.TabIndex = 7;
            this.TrackBar_Blue.Text = "Blue";
            this.TrackBar_Blue.Value = 0;
            this.TrackBar_Blue.ValueChanged += new System.EventHandler(this.TrackBar_Blue_ValueChanged);
            // 
            // Label_Red
            // 
            this.Label_Red.AutoSize = true;
            this.Label_Red.BackColor = System.Drawing.Color.Transparent;
            this.Label_Red.Location = new System.Drawing.Point(3, 23);
            this.Label_Red.Name = "Label_Red";
            this.Label_Red.Size = new System.Drawing.Size(32, 19);
            this.Label_Red.TabIndex = 8;
            this.Label_Red.Text = "Red";
            // 
            // Label_Green
            // 
            this.Label_Green.AutoSize = true;
            this.Label_Green.BackColor = System.Drawing.Color.Transparent;
            this.Label_Green.Location = new System.Drawing.Point(3, 63);
            this.Label_Green.Name = "Label_Green";
            this.Label_Green.Size = new System.Drawing.Size(44, 19);
            this.Label_Green.TabIndex = 9;
            this.Label_Green.Text = "Green";
            // 
            // Label_Blue
            // 
            this.Label_Blue.AutoSize = true;
            this.Label_Blue.BackColor = System.Drawing.Color.Transparent;
            this.Label_Blue.Location = new System.Drawing.Point(3, 105);
            this.Label_Blue.Name = "Label_Blue";
            this.Label_Blue.Size = new System.Drawing.Size(34, 19);
            this.Label_Blue.TabIndex = 10;
            this.Label_Blue.Text = "Blue";
            // 
            // GameColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 318);
            this.Controls.Add(this.Label_Slogan);
            this.Controls.Add(this.Label_PortErrorMessage);
            this.Controls.Add(this.ComboBox_Ports);
            this.Controls.Add(this.TabControl_Presets);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(335, 298);
            this.Name = "GameColor";
            this.Text = "Game Color";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameColor_FormClosing);
            this.TabControl_Presets.ResumeLayout(false);
            this.Tab_Home.ResumeLayout(false);
            this.Tile_PresetsGenerator.ResumeLayout(false);
            this.Tile_Settings.ResumeLayout(false);
            this.Tab_GamePreset.ResumeLayout(false);
            this.Tab_UserPreset.ResumeLayout(false);
            this.Tab_UserPreset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControl_Presets;
        private MetroFramework.Controls.MetroTabPage Tab_UserPreset;
        private MetroFramework.Controls.MetroTabPage Tab_GamePreset;
        private System.Windows.Forms.Button Button_StartGamePreset;
        private MetroFramework.Controls.MetroComboBox ComboBox_GamePreset;
        private MetroFramework.Controls.MetroComboBox ComboBox_Ports;
        private System.Windows.Forms.Label Label_PortErrorMessage;
        private System.Windows.Forms.ListView ListView_UserLog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MetroFramework.Controls.MetroTabPage Tab_Home;
        private MetroFramework.Controls.MetroTile Tile_Settings;
        private MetroFramework.Controls.MetroLabel Label_Slogan;
        private MetroFramework.Controls.MetroTile Tile_Informations;
        private MetroFramework.Controls.MetroTile Tile_PresetsGenerator;
        private System.Windows.Forms.Button Button_LaunchSettings;
        private System.Windows.Forms.Button Button_LaunchPresetsCreator;
        private MetroFramework.Controls.MetroLabel Label_Blue;
        private MetroFramework.Controls.MetroLabel Label_Green;
        private MetroFramework.Controls.MetroLabel Label_Red;
        private MetroFramework.Controls.MetroTrackBar TrackBar_Blue;
        private MetroFramework.Controls.MetroTrackBar TrackBar_Green;
        private MetroFramework.Controls.MetroTrackBar TrackBar_Red;
    }
}