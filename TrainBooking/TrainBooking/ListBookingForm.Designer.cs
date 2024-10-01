namespace TrainBooking
{
    partial class ListBookingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BookingID = new System.Windows.Forms.NumericUpDown();
            this.TicketID = new System.Windows.Forms.NumericUpDown();
            this.TicketErr = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookingID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketErr)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(341, 516);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 74);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel Booking";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(132, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(622, 322);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(140, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Booking ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(140, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ticket ID";
            // 
            // BookingID
            // 
            this.BookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.BookingID.Location = new System.Drawing.Point(301, 392);
            this.BookingID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.BookingID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BookingID.Name = "BookingID";
            this.BookingID.Size = new System.Drawing.Size(336, 33);
            this.BookingID.TabIndex = 8;
            this.BookingID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TicketID
            // 
            this.TicketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.TicketID.Location = new System.Drawing.Point(301, 456);
            this.TicketID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TicketID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TicketID.Name = "TicketID";
            this.TicketID.Size = new System.Drawing.Size(336, 33);
            this.TicketID.TabIndex = 9;
            this.TicketID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TicketErr
            // 
            this.TicketErr.ContainerControl = this;
            // 
            // ListBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(892, 602);
            this.Controls.Add(this.TicketID);
            this.Controls.Add(this.BookingID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Name = "ListBookingForm";
            this.Text = "ListBopking";
            this.Load += new System.EventHandler(this.ListBopking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookingID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketErr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown BookingID;
        private System.Windows.Forms.NumericUpDown TicketID;
        private System.Windows.Forms.ErrorProvider TicketErr;
    }
}