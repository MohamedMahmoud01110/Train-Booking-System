namespace TrainBooking
{
    partial class AddTripForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTripForm));
            this.AddTrip = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lablel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DepartureTime = new System.Windows.Forms.DateTimePicker();
            this.ArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TrainID = new System.Windows.Forms.NumericUpDown();
            this.DriverID = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.SrcStation = new System.Windows.Forms.ComboBox();
            this.DestStation = new System.Windows.Forms.ComboBox();
            this.Depature_Arrival = new System.Windows.Forms.ErrorProvider(this.components);
            this.SrcEqDest = new System.Windows.Forms.ErrorProvider(this.components);
            this.TrainIDErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.DriverIDErr = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TrainID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriverID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Depature_Arrival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrcEqDest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainIDErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriverIDErr)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTrip
            // 
            this.AddTrip.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold);
            this.AddTrip.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AddTrip.Location = new System.Drawing.Point(249, 519);
            this.AddTrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddTrip.Name = "AddTrip";
            this.AddTrip.Size = new System.Drawing.Size(187, 49);
            this.AddTrip.TabIndex = 24;
            this.AddTrip.Text = "ADD";
            this.AddTrip.UseVisualStyleBackColor = true;
            this.AddTrip.Click += new System.EventHandler(this.AddTrip_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(67, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Depature Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(65, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "DriverID";
            // 
            // lablel
            // 
            this.lablel.AutoSize = true;
            this.lablel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lablel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lablel.Location = new System.Drawing.Point(67, 121);
            this.lablel.Name = "lablel";
            this.lablel.Size = new System.Drawing.Size(92, 29);
            this.lablel.TabIndex = 18;
            this.lablel.Text = "TrainID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 48);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add a Trip";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DepartureTime
            // 
            this.DepartureTime.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.DepartureTime.CustomFormat = "dd / MM / yyyy  hh:mm tt";
            this.DepartureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DepartureTime.Location = new System.Drawing.Point(300, 244);
            this.DepartureTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepartureTime.Name = "DepartureTime";
            this.DepartureTime.Size = new System.Drawing.Size(324, 34);
            this.DepartureTime.TabIndex = 25;
            this.DepartureTime.Value = new System.DateTime(2023, 5, 19, 9, 55, 39, 0);
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalTime.CustomFormat = "dd / MM / yyyy  hh:mm tt";
            this.ArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ArrivalTime.Location = new System.Drawing.Point(300, 311);
            this.ArrivalTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.Size = new System.Drawing.Size(324, 34);
            this.ArrivalTime.TabIndex = 27;
            this.ArrivalTime.Value = new System.DateTime(2023, 5, 20, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(67, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Arrival Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(67, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "Source Station";
            // 
            // TrainID
            // 
            this.TrainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TrainID.Location = new System.Drawing.Point(300, 114);
            this.TrainID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TrainID.Name = "TrainID";
            this.TrainID.Size = new System.Drawing.Size(324, 34);
            this.TrainID.TabIndex = 32;
            // 
            // DriverID
            // 
            this.DriverID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DriverID.Location = new System.Drawing.Point(300, 177);
            this.DriverID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DriverID.Name = "DriverID";
            this.DriverID.Size = new System.Drawing.Size(324, 34);
            this.DriverID.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(65, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 29);
            this.label8.TabIndex = 34;
            this.label8.Text = "Destination Station";
            // 
            // SrcStation
            // 
            this.SrcStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SrcStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.SrcStation.FormattingEnabled = true;
            this.SrcStation.Items.AddRange(new object[] {
            "Rhodes",
            "Valentine",
            "Van Horn",
            "Saint Denis",
            "Blackwater",
            "Annesburg",
            "Riggs Station",
            "Emerald Station",
            "Bacchus Station"});
            this.SrcStation.Location = new System.Drawing.Point(300, 379);
            this.SrcStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SrcStation.Name = "SrcStation";
            this.SrcStation.Size = new System.Drawing.Size(324, 34);
            this.SrcStation.TabIndex = 38;
            // 
            // DestStation
            // 
            this.DestStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DestStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.DestStation.FormattingEnabled = true;
            this.DestStation.Items.AddRange(new object[] {
            "Rhodes",
            "Valentine",
            "Van Horn",
            "Saint Denis",
            "Blackwater",
            "Annesburg",
            "Riggs Station",
            "Emerald Station",
            "Bacchus Station"});
            this.DestStation.Location = new System.Drawing.Point(300, 449);
            this.DestStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DestStation.Name = "DestStation";
            this.DestStation.Size = new System.Drawing.Size(324, 34);
            this.DestStation.TabIndex = 39;
            // 
            // Depature_Arrival
            // 
            this.Depature_Arrival.ContainerControl = this;
            // 
            // SrcEqDest
            // 
            this.SrcEqDest.ContainerControl = this;
            // 
            // TrainIDErr
            // 
            this.TrainIDErr.ContainerControl = this;
            // 
            // DriverIDErr
            // 
            this.DriverIDErr.ContainerControl = this;
            // 
            // AddTripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(693, 581);
            this.Controls.Add(this.DestStation);
            this.Controls.Add(this.SrcStation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DriverID);
            this.Controls.Add(this.TrainID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ArrivalTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DepartureTime);
            this.Controls.Add(this.AddTrip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lablel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddTripForm";
            this.Text = "Add Trip";
            ((System.ComponentModel.ISupportInitialize)(this.TrainID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriverID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Depature_Arrival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrcEqDest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainIDErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriverIDErr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTrip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lablel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DepartureTime;
        private System.Windows.Forms.DateTimePicker ArrivalTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown TrainID;
        private System.Windows.Forms.NumericUpDown DriverID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox SrcStation;
        private System.Windows.Forms.ComboBox DestStation;
        private System.Windows.Forms.ErrorProvider Depature_Arrival;
        private System.Windows.Forms.ErrorProvider SrcEqDest;
        private System.Windows.Forms.ErrorProvider TrainIDErr;
        private System.Windows.Forms.ErrorProvider DriverIDErr;
    }
}