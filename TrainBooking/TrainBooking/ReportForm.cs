using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainBooking
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();
            Report report = new Report();
            NCustomer.Text = report.TotalCustomer(connection).ToString();
            NCustomer.Enabled = false;

            TotalPrice.Text = report.TotalPrice(connection).ToString();
            TotalPrice.Enabled = false;


            // Create DataTables to hold data from each table
            DataTable table1 = new DataTable();

            // Retrieve the desired attributes from the Station table for "Source" column
            string sourceQuery = $"SELECT B.BookingID, T.TicketNumber, Tr.TrainID, SSource.Name AS SourceStation, SDest.Name AS DestinationStation, T.price AS Price FROM Booking B INNER JOIN BookingContains AS BC ON B.BookingId = BC.BookingID INNER JOIN Ticket T ON BC.TicketNumber = T.TicketNumber INNER JOIN Trip Tr ON T.TripID = Tr.TripID INNER JOIN Station SSource ON Tr.TripID = SSource.TripID AND SSource.station_type = 'Source' INNER JOIN Station SDest ON Tr.TripID = SDest.TripID AND SDest.station_type = 'Destination';";



            SqlDataAdapter sqlDaSource = new SqlDataAdapter(sourceQuery, connection);
            sqlDaSource.Fill(table1);


            // Set the merged DataTable as the DataSource of the DataGridView
            dataGridView1.DataSource = table1;
        }
    }
}
