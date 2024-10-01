namespace TrainBooking
{
    partial class ReportForm
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
            this.NCustomer = new System.Windows.Forms.TextBox();
            this.numofpassenger = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NCustomer
            // 
            this.NCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NCustomer.Location = new System.Drawing.Point(459, 9);
            this.NCustomer.Name = "NCustomer";
            this.NCustomer.Size = new System.Drawing.Size(265, 34);
            this.NCustomer.TabIndex = 19;
            // 
            // numofpassenger
            // 
            this.numofpassenger.AutoSize = true;
            this.numofpassenger.BackColor = System.Drawing.SystemColors.Highlight;
            this.numofpassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numofpassenger.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numofpassenger.Location = new System.Drawing.Point(27, 9);
            this.numofpassenger.Name = "numofpassenger";
            this.numofpassenger.Size = new System.Drawing.Size(397, 29);
            this.numofpassenger.TabIndex = 17;
            this.numofpassenger.Text = "Number of Customers in the System";
            // 
            // TotalPrice
            // 
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TotalPrice.Location = new System.Drawing.Point(459, 63);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(265, 34);
            this.TotalPrice.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(29, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Total Price Gained";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(964, 444);
            this.dataGridView1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(432, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "Report";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(988, 726);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NCustomer);
            this.Controls.Add(this.numofpassenger);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NCustomer;
        private System.Windows.Forms.Label numofpassenger;
        private System.Windows.Forms.TextBox TotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}