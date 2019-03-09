namespace GameColor.View.Views
{
    partial class UpdaterDialog
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
            this.Panel_Browser = new System.Windows.Forms.Panel();
            this.Label_InstallInstructions = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // Panel_Browser
            // 
            this.Panel_Browser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Browser.Location = new System.Drawing.Point(11, 47);
            this.Panel_Browser.Name = "Panel_Browser";
            this.Panel_Browser.Size = new System.Drawing.Size(1021, 663);
            this.Panel_Browser.TabIndex = 2;
            // 
            // Label_InstallInstructions
            // 
            this.Label_InstallInstructions.AutoSize = true;
            this.Label_InstallInstructions.Location = new System.Drawing.Point(11, 13);
            this.Label_InstallInstructions.Name = "Label_InstallInstructions";
            this.Label_InstallInstructions.Size = new System.Drawing.Size(822, 19);
            this.Label_InstallInstructions.TabIndex = 3;
            this.Label_InstallInstructions.Text = "In order to install an update, select your version of the program, and download i" +
    "t to the program\'s folder which contains the executable file.";
            // 
            // UpdaterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 725);
            this.Controls.Add(this.Label_InstallInstructions);
            this.Controls.Add(this.Panel_Browser);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdaterDialog";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "Updater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Panel_Browser;
        private MetroFramework.Controls.MetroLabel Label_InstallInstructions;
    }
}