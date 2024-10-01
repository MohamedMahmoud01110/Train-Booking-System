namespace TrainBooking
{
    partial class AddTrainForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.TrainStatus = new System.Windows.Forms.TextBox();
            this.TrainName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TrainCapacity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddTrain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 22F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(32, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 48);
            this.label4.TabIndex = 8;
            this.label4.Text = "Add a Train";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrainStatus
            // 
            this.TrainStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TrainStatus.Location = new System.Drawing.Point(179, 182);
            this.TrainStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TrainStatus.Name = "TrainStatus";
            this.TrainStatus.PasswordChar = '*';
            this.TrainStatus.Size = new System.Drawing.Size(316, 34);
            this.TrainStatus.TabIndex = 12;
            // 
            // TrainName
            // 
            this.TrainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TrainName.Location = new System.Drawing.Point(179, 121);
            this.TrainName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TrainName.Name = "TrainName";
            this.TrainName.Size = new System.Drawing.Size(316, 34);
            this.TrainName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(55, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(56, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // TrainCapacity
            // 
            this.TrainCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TrainCapacity.Location = new System.Drawing.Point(179, 247);
            this.TrainCapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TrainCapacity.Name = "TrainCapacity";
            this.TrainCapacity.Size = new System.Drawing.Size(316, 34);
            this.TrainCapacity.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(56, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Capacity";
            // 
            // AddTrain
            // 
            this.AddTrain.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold);
            this.AddTrain.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AddTrain.Location = new System.Drawing.Point(179, 325);
            this.AddTrain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddTrain.Name = "AddTrain";
            this.AddTrain.Size = new System.Drawing.Size(187, 49);
            this.AddTrain.TabIndex = 16;
            this.AddTrain.Text = "ADD";
            this.AddTrain.UseVisualStyleBackColor = true;
            this.AddTrain.Click += new System.EventHandler(this.AddTrain_Click);
            // 
            // AddTrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(597, 462);
            this.Controls.Add(this.AddTrain);
            this.Controls.Add(this.TrainCapacity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TrainStatus);
            this.Controls.Add(this.TrainName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddTrainForm";
            this.Text = "Add a Train";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TrainStatus;
        private System.Windows.Forms.TextBox TrainName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TrainCapacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddTrain;
    }
}