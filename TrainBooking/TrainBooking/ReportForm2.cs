using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace TrainBooking
{
    public partial class ReportForm2 : Form
    {
        public ReportForm2()
        {
            InitializeComponent();
        }

        private void ReportForm2_Load(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();
            Report report = new Report();

            // Retrieve data using JOINs
            string query = @"
        SELECT
            BC.BookingID, 
            U.UserID,
            B.BookingDate,
            BC.TicketNumber, 
            T.price AS Price,
            SSource.Name,
            
            SDest.Location,
            Tr.TripID,
            Tr.DepartureTime,
            Tr.ArrivalTime
        FROM BookingContains BC JOIN Booking B ON B.BookingId = BC.BookingID
        JOIN [User] U ON B.PassengerId = U.UserID
        JOIN Ticket T ON BC.TicketNumber = T.TicketNumber
        JOIN Trip Tr ON T.TripID = Tr.TripID
        JOIN Station SSource ON Tr.TripID = SSource.TripID AND SSource.station_type = 'Source'
        JOIN Station SDest ON Tr.TripID = SDest.TripID AND SDest.station_type = 'Destination'";

            /*string SStation = $"SELECT S.Name, D.Name From Station S JOIN Station D ON S.TripID = D.TripID";*/
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Set the data source for the ReportViewer control
            ReportDataSource reportDataSourceBooking = new ReportDataSource("DataSet1", dataTable);
            ReportDataSource reportDataSourceBookingContains = new ReportDataSource("DataSet2", dataTable);
            ReportDataSource reportDataSourceDriver = new ReportDataSource("DataSet3", dataTable);
            ReportDataSource reportDataSourceStation = new ReportDataSource("DataSet4", dataTable);
            ReportDataSource reportDataSourceTicket = new ReportDataSource("DataSet5", dataTable);
            ReportDataSource reportDataSourceTrain = new ReportDataSource("DataSet6", dataTable);
            ReportDataSource reportDataSourceTrip = new ReportDataSource("DataSet7", dataTable);
            ReportDataSource reportDataSourceUser = new ReportDataSource("DataSet8", dataTable);
            reportViewer1.LocalReport.DataSources.Clear();
            string directory = Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName;
            string dir = Directory.GetParent(directory).FullName;
            reportViewer1.LocalReport.ReportPath = $@"{dir}\Report.rdlc";
            reportViewer1.LocalReport.DataSources.Add(reportDataSourceBooking);
            reportViewer1.LocalReport.DataSources.Add(reportDataSourceBookingContains);
            reportViewer1.LocalReport.DataSources.Add(reportDataSourceDriver);
            reportViewer1.LocalReport.DataSources.Add(reportDataSourceStation);
            reportViewer1.LocalReport.DataSources.Add(reportDataSourceTicket);
            reportViewer1.LocalReport.DataSources.Add(reportDataSourceTrain);
            reportViewer1.LocalReport.DataSources.Add(reportDataSourceTrip);
            reportViewer1.LocalReport.DataSources.Add(reportDataSourceUser);

            this.reportViewer1.RefreshReport();
        }


        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void load_Click(object sender, EventArgs e)
        {

        }
    }
}
/*Dep, Arrival
source, dest,
passengerID, name
bookingID, Ticket, price*/

/*SELECT
            BC.BookingID, 
            U.UserID,
            U.Name,
            B.BookindDate,
            BC.TicketNumber, 
            T.price AS Price
            SSource.Name AS SourceStation,
            SDest.Name AS DestinationStation,
            Tr.DepartureTime,
            Tr.ArrivalTime,
        FROM BookingContains BC JOIN Booking B ON B.BookingId = BC.BookingID
        JOIN [User] U ON B.PassengerId = U.UserID
        JOIN Ticket T ON BC.TicketNumber = T.TicketNumber
        JOIN Trip Tr ON T.TripID = Tr.TripID
        JOIN Station SSource ON Tr.TripID = SSource.TripID AND SSource.station_type = 'Source'
        JOIN Station SDest ON Tr.TripID = SDest.TripID AND SDest.station_type = 'Destination'"*/