namespace TrainBooking
{
    partial class ShowTripsFrom
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
            this.tripBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainBookingDataSet1 = new TrainBooking.TrainBookingDataSet1();
            this.tripTableAdapter = new TrainBooking.TrainBookingDataSet1TableAdapters.TripTableAdapter();
            this.trainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainTableAdapter = new TrainBooking.TrainBookingDataSet1TableAdapters.TrainTableAdapter();
            this.trainBookingDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Booking = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TripID = new System.Windows.Forms.TextBox();
            this.stationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trainBookingDataSet2 = new TrainBooking.TrainBookingDataSet2();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationTableAdapter = new TrainBooking.TrainBookingDataSet2TableAdapters.StationTableAdapter();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBookingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBookingDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBookingDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tripBindingSource
            // 
            this.tripBindingSource.DataMember = "Trip";
            this.tripBindingSource.DataSource = this.trainBookingDataSet1;
            // 
            // trainBookingDataSet1
            // 
            this.trainBookingDataSet1.DataSetName = "TrainBookingDataSet1";
            this.trainBookingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tripTableAdapter
            // 
            this.tripTableAdapter.ClearBeforeFill = true;
            // 
            // trainBindingSource
            // 
            this.trainBindingSource.DataMember = "Train";
            this.trainBindingSource.DataSource = this.trainBookingDataSet1;
            // 
            // trainTableAdapter
            // 
            this.trainTableAdapter.ClearBeforeFill = true;
            // 
            // trainBookingDataSet1BindingSource
            // 
            this.trainBookingDataSet1BindingSource.DataSource = this.trainBookingDataSet1;
            this.trainBookingDataSet1BindingSource.Position = 0;
            // 
            // Booking
            // 
            this.Booking.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold);
            this.Booking.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Booking.Location = new System.Drawing.Point(447, 474);
            this.Booking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Booking.Name = "Booking";
            this.Booking.Size = new System.Drawing.Size(187, 49);
            this.Booking.TabIndex = 61;
            this.Booking.Text = "Book";
            this.Booking.UseVisualStyleBackColor = true;
            this.Booking.Click += new System.EventHandler(this.Booking_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(295, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 74;
            this.label2.Text = "TripID";
            // 
            // TripID
            // 
            this.TripID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TripID.Location = new System.Drawing.Point(447, 393);
            this.TripID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TripID.Name = "TripID";
            this.TripID.Size = new System.Drawing.Size(419, 34);
            this.TripID.TabIndex = 83;
            // 
            // stationBindingSource1
            // 
            this.stationBindingSource1.DataMember = "Station";
            this.stationBindingSource1.DataSource = this.trainBookingDataSet2;
            // 
            // trainBookingDataSet2
            // 
            this.trainBookingDataSet2.DataSetName = "TrainBookingDataSet2";
            this.trainBookingDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataMember = "Station";
            this.stationBindingSource.DataSource = this.trainBookingDataSet2;
            // 
            // stationTableAdapter
            // 
            this.stationTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(0, 1);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(1140, 353);
            this.dataGridView4.TabIndex = 84;
            // 
            // ShowTripsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1152, 535);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.TripID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Booking);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShowTripsFrom";
            this.Text = "ShowTripsFrom";
            this.Load += new System.EventHandler(this.ShowTripsFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBookingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBookingDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBookingDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TrainBookingDataSet1 trainBookingDataSet1;
        private System.Windows.Forms.BindingSource tripBindingSource;
        private TrainBookingDataSet1TableAdapters.TripTableAdapter tripTableAdapter;
        private System.Windows.Forms.BindingSource trainBindingSource;
        private TrainBookingDataSet1TableAdapters.TrainTableAdapter trainTableAdapter;
        private System.Windows.Forms.BindingSource trainBookingDataSet1BindingSource;
        private TrainBookingDataSet2 trainBookingDataSet2;
        private System.Windows.Forms.BindingSource stationBindingSource;
        private TrainBookingDataSet2TableAdapters.StationTableAdapter stationTableAdapter;
        private System.Windows.Forms.BindingSource stationBindingSource1;
        private System.Windows.Forms.Button Booking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TripID;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}