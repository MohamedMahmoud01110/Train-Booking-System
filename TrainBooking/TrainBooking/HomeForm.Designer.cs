namespace TrainBooking
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.Sign_upLink = new System.Windows.Forms.Label();
            this.LogInLink = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sign_upLink
            // 
            this.Sign_upLink.AutoSize = true;
            this.Sign_upLink.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Sign_upLink.Font = new System.Drawing.Font("Microsoft Tai Le", 14.8F, System.Drawing.FontStyle.Bold);
            this.Sign_upLink.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Sign_upLink.Location = new System.Drawing.Point(193, 298);
            this.Sign_upLink.Name = "Sign_upLink";
            this.Sign_upLink.Padding = new System.Windows.Forms.Padding(21, 12, 21, 12);
            this.Sign_upLink.Size = new System.Drawing.Size(149, 57);
            this.Sign_upLink.TabIndex = 5;
            this.Sign_upLink.Text = "Sign-up";
            this.Sign_upLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sign_upLink.Click += new System.EventHandler(this.Sign_upLink_Click);
            // 
            // LogInLink
            // 
            this.LogInLink.AutoSize = true;
            this.LogInLink.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogInLink.Font = new System.Drawing.Font("Microsoft Tai Le", 14.8F, System.Drawing.FontStyle.Bold);
            this.LogInLink.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LogInLink.Location = new System.Drawing.Point(582, 298);
            this.LogInLink.Name = "LogInLink";
            this.LogInLink.Padding = new System.Windows.Forms.Padding(30, 12, 30, 12);
            this.LogInLink.Size = new System.Drawing.Size(150, 57);
            this.LogInLink.TabIndex = 6;
            this.LogInLink.Text = "Log-in";
            this.LogInLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogInLink.Click += new System.EventHandler(this.LogInLink_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(226, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(436, 43);
            this.label4.TabIndex = 7;
            this.label4.Text = "Welcome To Train Booking";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(901, 598);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LogInLink);
            this.Controls.Add(this.Sign_upLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HomeForm";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Sign_upLink;
        private System.Windows.Forms.Label LogInLink;
        private System.Windows.Forms.Label label4;
    }
}