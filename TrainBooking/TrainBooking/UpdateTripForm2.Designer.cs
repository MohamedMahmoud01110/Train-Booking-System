using System;

namespace TrainBooking
{
    partial class UpdateTripForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTripForm2));
            this.DestStation = new System.Windows.Forms.ComboBox();
            this.SrcStation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DriverID = new System.Windows.Forms.NumericUpDown();
            this.TrainID = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DepartureTime = new System.Windows.Forms.DateTimePicker();
            this.UpdateTrip = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lablel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.TrainIDErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.DriverIDErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.Depature_Arrival = new System.Windows.Forms.ErrorProvider(this.components);
            this.SrcEqDest = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DriverID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainIDErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriverIDErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Depature_Arrival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrcEqDest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.DestStation.Location = new System.Drawing.Point(219, 368);
            this.DestStation.Margin = new System.Windows.Forms.Padding(2);
            this.DestStation.Name = "DestStation";
            this.DestStation.Size = new System.Drawing.Size(248, 30);
            this.DestStation.TabIndex = 57;
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
            this.SrcStation.Location = new System.Drawing.Point(219, 310);
            this.SrcStation.Margin = new System.Windows.Forms.Padding(2);
            this.SrcStation.Name = "SrcStation";
            this.SrcStation.Size = new System.Drawing.Size(248, 30);
            this.SrcStation.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(43, 369);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 24);
            this.label8.TabIndex = 53;
            this.label8.Text = "Destination Station";
            // 
            // DriverID
            // 
            this.DriverID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DriverID.Location = new System.Drawing.Point(219, 145);
            this.DriverID.Margin = new System.Windows.Forms.Padding(2);
            this.DriverID.Name = "DriverID";
            this.DriverID.Size = new System.Drawing.Size(247, 29);
            this.DriverID.TabIndex = 52;
            // 
            // TrainID
            // 
            this.TrainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TrainID.Location = new System.Drawing.Point(219, 95);
            this.TrainID.Margin = new System.Windows.Forms.Padding(2);
            this.TrainID.Name = "TrainID";
            this.TrainID.Size = new System.Drawing.Size(247, 29);
            this.TrainID.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(44, 310);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 24);
            this.label6.TabIndex = 48;
            this.label6.Text = "Source Station";
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.CustomFormat = "dd / MM / yyyy   hh:mm tt";
            this.ArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ArrivalTime.Location = new System.Drawing.Point(219, 254);
            this.ArrivalTime.Margin = new System.Windows.Forms.Padding(2);
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.Size = new System.Drawing.Size(248, 29);
            this.ArrivalTime.TabIndex = 47;
            this.ArrivalTime.Value = new System.DateTime(2023, 5, 19, 9, 55, 39, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(44, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 46;
            this.label5.Text = "Arrival Time";
            // 
            // DepartureTime
            // 
            this.DepartureTime.CustomFormat = "dd / MM / yyyy   hh:mm tt";
            this.DepartureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DepartureTime.Location = new System.Drawing.Point(219, 200);
            this.DepartureTime.Margin = new System.Windows.Forms.Padding(2);
            this.DepartureTime.Name = "DepartureTime";
            this.DepartureTime.Size = new System.Drawing.Size(248, 29);
            this.DepartureTime.TabIndex = 45;
            this.DepartureTime.Value = new System.DateTime(2023, 5, 19, 9, 55, 39, 0);
            // 
            // UpdateTrip
            // 
            this.UpdateTrip.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold);
            this.UpdateTrip.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UpdateTrip.Location = new System.Drawing.Point(186, 438);
            this.UpdateTrip.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateTrip.Name = "UpdateTrip";
            this.UpdateTrip.Size = new System.Drawing.Size(140, 40);
            this.UpdateTrip.TabIndex = 44;
            this.UpdateTrip.Text = "UPDATE";
            this.UpdateTrip.UseVisualStyleBackColor = true;
            this.UpdateTrip.Click += new System.EventHandler(this.UpdateTrip_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(44, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 43;
            this.label4.Text = "Depature Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(43, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 42;
            this.label3.Text = "DriverID";
            // 
            // lablel
            // 
            this.lablel.AutoSize = true;
            this.lablel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lablel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lablel.Location = new System.Drawing.Point(44, 99);
            this.lablel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lablel.Name = "lablel";
            this.lablel.Size = new System.Drawing.Size(70, 24);
            this.lablel.TabIndex = 41;
            this.lablel.Text = "TrainID";
            // 
            // Title
            // 
            this.Title.AutoEllipsis = true;
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft Tai Le", 22F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Location = new System.Drawing.Point(16, 21);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(205, 44);
            this.Title.TabIndex = 40;
            this.Title.Text = "Update Trip " + UpdateTripForm1.tripID.ToString();
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.UseCompatibleTextRendering = true;
            // 
            // TrainIDErr
            // 
            this.TrainIDErr.ContainerControl = this;
            // 
            // DriverIDErr
            // 
            this.DriverIDErr.ContainerControl = this;
            // 
            // Depature_Arrival
            // 
            this.Depature_Arrival.ContainerControl = this;
            // 
            // SrcEqDest
            // 
            this.SrcEqDest.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UpdateTripForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(523, 487);
            this.Controls.Add(this.DestStation);
            this.Controls.Add(this.SrcStation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DriverID);
            this.Controls.Add(this.TrainID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ArrivalTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DepartureTime);
            this.Controls.Add(this.UpdateTrip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lablel);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateTripForm2";
            this.Text = "Update a Trip";
            ((System.ComponentModel.ISupportInitialize)(this.DriverID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainIDErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriverIDErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Depature_Arrival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrcEqDest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DestStation;
        private System.Windows.Forms.ComboBox SrcStation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown DriverID;
        private System.Windows.Forms.NumericUpDown TrainID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DepartureTime;
        private System.Windows.Forms.Button UpdateTrip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lablel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DateTimePicker ArrivalTime;
        private System.Windows.Forms.ErrorProvider TrainIDErr;
        private System.Windows.Forms.ErrorProvider DriverIDErr;
        private System.Windows.Forms.ErrorProvider Depature_Arrival;
        private System.Windows.Forms.ErrorProvider SrcEqDest;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}