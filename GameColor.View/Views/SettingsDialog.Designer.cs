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
            this.SuspendLayout();
            // 
            // Button_Apply
            // 
            this.Button_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Apply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_Apply.Location = new System.Drawing.Point(308, 277);
            this.Button_Apply.Name = "Button_Apply";
            this.Button_Apply.Size = new System.Drawing.Size(56, 23);
            this.Button_Apply.TabIndex = 0;
            this.Button_Apply.Text = "Apply";
            this.Button_Apply.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Button_Apply.Click += new System.EventHandler(this.Button_Apply_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(245, 277);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(56, 23);
            this.Button_Cancel.TabIndex = 1;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Toggle_InitializeWithWindows
            // 
            this.Toggle_InitializeWithWindows.AutoSize = true;
            this.Toggle_InitializeWithWindows.DisplayStatus = false;
            this.Toggle_InitializeWithWindows.Location = new System.Drawing.Point(23, 91);
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
            this.Label_StartWithWindows.Location = new System.Drawing.Point(19, 69);
            this.Label_StartWithWindows.Name = "Label_StartWithWindows";
            this.Label_StartWithWindows.Size = new System.Drawing.Size(189, 19);
            this.Label_StartWithWindows.TabIndex = 3;
            this.Label_StartWithWindows.Text = "Start with windows initialization";
            // 
            // CheckBox_Red
            // 
            this.CheckBox_Red.AutoSize = true;
            this.CheckBox_Red.Location = new System.Drawing.Point(23, 136);
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
            this.CheckBox_Green.Location = new System.Drawing.Point(72, 136);
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
            this.CheckBox_Blue.Location = new System.Drawing.Point(132, 136);
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
            this.metroLabel1.Location = new System.Drawing.Point(19, 113);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(154, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Turn on lights when open";
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 313);
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
    }
}