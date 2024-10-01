using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainBooking
{
    public partial class ShowTicketForm : Form
    {
        public int TicketNum { get; set; }
        public int LastTicket;
        public ShowTicketForm()
        {
            InitializeComponent();
            LastTicket = BookingForm.LastTicket;
        }

        private void ShowTicketForm_Load(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();

            // Create DataTables to hold data from each table
            DataTable table1 = new DataTable();

            // Retrieve the desired attributes from the Station table for "Source" column
            string sourceQuery = $"SELECT * From Ticket Where TicketNumber > {LastTicket}";



            SqlDataAdapter sqlDaSource = new SqlDataAdapter(sourceQuery, connection);
            sqlDaSource.Fill(table1);


            // Set the merged DataTable as the DataSource of the DataGridView
            dataGridView1.DataSource = table1;
        }

    }
}
