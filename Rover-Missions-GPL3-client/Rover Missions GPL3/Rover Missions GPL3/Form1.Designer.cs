namespace Rover_Missions_GPL3
{
    partial class RoverMissionsGPL3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoverMissionsGPL3));
            this.openLicense = new System.Windows.Forms.Button();
            this.thewebcontrols = new System.Windows.Forms.WebBrowser();
            this.theWebbrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // openLicense
            // 
            this.openLicense.Location = new System.Drawing.Point(374, 84);
            this.openLicense.Name = "openLicense";
            this.openLicense.Size = new System.Drawing.Size(75, 23);
            this.openLicense.TabIndex = 1;
            this.openLicense.Text = "License";
            this.openLicense.UseVisualStyleBackColor = true;
            this.openLicense.Click += new System.EventHandler(this.openLicense_Click);
            // 
            // thewebcontrols
            // 
            this.thewebcontrols.Location = new System.Drawing.Point(-1, 31);
            this.thewebcontrols.MinimumSize = new System.Drawing.Size(20, 20);
            this.thewebcontrols.Name = "thewebcontrols";
            this.thewebcontrols.ScrollBarsEnabled = false;
            this.thewebcontrols.Size = new System.Drawing.Size(450, 136);
            this.thewebcontrols.TabIndex = 2;
            this.thewebcontrols.Url = new System.Uri("http://jeremiahonealts.com/RoverMissionsGPL3-controls.php", System.UriKind.Absolute);
            // 
            // theWebbrowser
            // 
            this.theWebbrowser.Location = new System.Drawing.Point(-1, 153);
            this.theWebbrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.theWebbrowser.Name = "theWebbrowser";
            this.theWebbrowser.ScrollBarsEnabled = false;
            this.theWebbrowser.Size = new System.Drawing.Size(450, 355);
            this.theWebbrowser.TabIndex = 3;
            this.theWebbrowser.Url = new System.Uri("http://jeremiahonealts.com/RoverMissionsGPL3-screen.php", System.UriKind.Absolute);
            // 
            // RoverMissionsGPL3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(469, 517);
            this.Controls.Add(this.theWebbrowser);
            this.Controls.Add(this.openLicense);
            this.Controls.Add(this.thewebcontrols);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoverMissionsGPL3";
            this.Text = "Rover Missions GPL3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button openLicense;
        private System.Windows.Forms.WebBrowser thewebcontrols;
        private System.Windows.Forms.WebBrowser theWebbrowser;
    }
}

