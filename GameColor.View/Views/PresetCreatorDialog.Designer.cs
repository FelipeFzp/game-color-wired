namespace GameColor.View.Views
{
    partial class PresetCreatorDialog
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Loading...");
            this.Label_ChooseGameProcess = new MetroFramework.Controls.MetroLabel();
            this.Label_NameYourProfile = new MetroFramework.Controls.MetroLabel();
            this.TextBox_NameYourProfile = new MetroFramework.Controls.MetroTextBox();
            this.Label_Divider1 = new System.Windows.Forms.Label();
            this.Button_Apply = new MetroFramework.Controls.MetroButton();
            this.Button_Cancel = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Picture_GamePreview = new System.Windows.Forms.PictureBox();
            this.ListView_Processes = new System.Windows.Forms.ListView();
            this.ProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_GamePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_ChooseGameProcess
            // 
            this.Label_ChooseGameProcess.AutoSize = true;
            this.Label_ChooseGameProcess.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Label_ChooseGameProcess.Location = new System.Drawing.Point(283, 61);
            this.Label_ChooseGameProcess.Name = "Label_ChooseGameProcess";
            this.Label_ChooseGameProcess.Size = new System.Drawing.Size(167, 19);
            this.Label_ChooseGameProcess.TabIndex = 4;
            this.Label_ChooseGameProcess.Text = "Choose the game process";
            // 
            // Label_NameYourProfile
            // 
            this.Label_NameYourProfile.AutoSize = true;
            this.Label_NameYourProfile.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Label_NameYourProfile.Location = new System.Drawing.Point(23, 61);
            this.Label_NameYourProfile.Name = "Label_NameYourProfile";
            this.Label_NameYourProfile.Size = new System.Drawing.Size(119, 19);
            this.Label_NameYourProfile.TabIndex = 6;
            this.Label_NameYourProfile.Text = "Name your profile";
            // 
            // TextBox_NameYourProfile
            // 
            this.TextBox_NameYourProfile.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBox_NameYourProfile.Location = new System.Drawing.Point(23, 84);
            this.TextBox_NameYourProfile.Name = "TextBox_NameYourProfile";
            this.TextBox_NameYourProfile.Size = new System.Drawing.Size(205, 29);
            this.TextBox_NameYourProfile.TabIndex = 7;
            this.TextBox_NameYourProfile.Text = "Eg.: Stardew Valley";
            this.TextBox_NameYourProfile.Click += new System.EventHandler(this.TextBox_NameYourProfile_Click);
            this.TextBox_NameYourProfile.Leave += new System.EventHandler(this.TextBox_NameYourProfile_Leave);
            // 
            // Label_Divider1
            // 
            this.Label_Divider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label_Divider1.Location = new System.Drawing.Point(19, 199);
            this.Label_Divider1.Name = "Label_Divider1";
            this.Label_Divider1.Size = new System.Drawing.Size(781, 2);
            this.Label_Divider1.TabIndex = 11;
            // 
            // Button_Apply
            // 
            this.Button_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Apply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_Apply.Location = new System.Drawing.Point(718, 7);
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
            this.Button_Cancel.Location = new System.Drawing.Point(652, 7);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(56, 28);
            this.Button_Cancel.TabIndex = 1;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Button_Apply);
            this.panel1.Controls.Add(this.Button_Cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 723);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 35);
            this.panel1.TabIndex = 25;
            // 
            // Picture_GamePreview
            // 
            this.Picture_GamePreview.Location = new System.Drawing.Point(23, 220);
            this.Picture_GamePreview.MaximumSize = new System.Drawing.Size(768, 497);
            this.Picture_GamePreview.MinimumSize = new System.Drawing.Size(768, 497);
            this.Picture_GamePreview.Name = "Picture_GamePreview";
            this.Picture_GamePreview.Size = new System.Drawing.Size(768, 497);
            this.Picture_GamePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_GamePreview.TabIndex = 26;
            this.Picture_GamePreview.TabStop = false;
            // 
            // ListView_Processes
            // 
            this.ListView_Processes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcessName});
            this.ListView_Processes.Enabled = false;
            this.ListView_Processes.FullRowSelect = true;
            this.ListView_Processes.GridLines = true;
            this.ListView_Processes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListView_Processes.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.ListView_Processes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ListView_Processes.Location = new System.Drawing.Point(283, 84);
            this.ListView_Processes.MultiSelect = false;
            this.ListView_Processes.Name = "ListView_Processes";
            this.ListView_Processes.Size = new System.Drawing.Size(289, 97);
            this.ListView_Processes.TabIndex = 27;
            this.ListView_Processes.UseCompatibleStateImageBehavior = false;
            this.ListView_Processes.View = System.Windows.Forms.View.Details;
            this.ListView_Processes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ListView_Processes_ItemCheck);
            // 
            // ProcessName
            // 
            this.ProcessName.Text = "";
            this.ProcessName.Width = 285;
            // 
            // PresetCreatorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 778);
            this.Controls.Add(this.ListView_Processes);
            this.Controls.Add(this.Picture_GamePreview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Label_Divider1);
            this.Controls.Add(this.TextBox_NameYourProfile);
            this.Controls.Add(this.Label_NameYourProfile);
            this.Controls.Add(this.Label_ChooseGameProcess);
            this.Name = "PresetCreatorDialog";
            this.Text = "Game Preset Creator";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_GamePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Label_ChooseGameProcess;
        private MetroFramework.Controls.MetroLabel Label_NameYourProfile;
        private MetroFramework.Controls.MetroTextBox TextBox_NameYourProfile;
        private System.Windows.Forms.Label Label_Divider1;
        private MetroFramework.Controls.MetroButton Button_Apply;
        private MetroFramework.Controls.MetroButton Button_Cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Picture_GamePreview;
        private System.Windows.Forms.ListView ListView_Processes;
        private System.Windows.Forms.ColumnHeader ProcessName;
    }
}