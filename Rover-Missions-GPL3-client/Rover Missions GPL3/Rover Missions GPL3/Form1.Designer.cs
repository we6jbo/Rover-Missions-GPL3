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
            this.RoverMissionsGPL3_web = new System.Windows.Forms.WebBrowser();
            this.openLicense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RoverMissionsGPL3_web
            // 
            this.RoverMissionsGPL3_web.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoverMissionsGPL3_web.Location = new System.Drawing.Point(0, 0);
            this.RoverMissionsGPL3_web.MinimumSize = new System.Drawing.Size(20, 20);
            this.RoverMissionsGPL3_web.Name = "RoverMissionsGPL3_web";
            this.RoverMissionsGPL3_web.Size = new System.Drawing.Size(1322, 847);
            this.RoverMissionsGPL3_web.TabIndex = 0;
            this.RoverMissionsGPL3_web.Url = new System.Uri("http://jeremiahonealts.com/RoverMissionsGPL3-web.php", System.UriKind.Absolute);
            // 
            // openLicense
            // 
            this.openLicense.Location = new System.Drawing.Point(1221, 812);
            this.openLicense.Name = "openLicense";
            this.openLicense.Size = new System.Drawing.Size(75, 23);
            this.openLicense.TabIndex = 1;
            this.openLicense.Text = "License";
            this.openLicense.UseVisualStyleBackColor = true;
            this.openLicense.Click += new System.EventHandler(this.openLicense_Click);
            // 
            // RoverMissionsGPL3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 847);
            this.Controls.Add(this.openLicense);
            this.Controls.Add(this.RoverMissionsGPL3_web);
            this.Name = "RoverMissionsGPL3";
            this.Text = "Rover Missions GPL3 - General Public License V3 ( https://www.gnu.org/licenses/gp" +
    "l-3.0.en.html)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser RoverMissionsGPL3_web;
        private System.Windows.Forms.Button openLicense;
    }
}

