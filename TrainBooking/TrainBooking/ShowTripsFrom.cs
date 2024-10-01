using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrainBooking
{
    public partial class ShowTripsFrom : Form
    {
        public DateTime DTime { get; set; }
        public DateTime ATime { get; set; }
        public string SStaion { get; set; }
        public string DStation { get; set; }
        public string TicketType { get; set; }

        public int NumofSeats { get; set; }

        public static int LastTicket { get; set; }

        public ShowTripsFrom()
        {
            InitializeComponent();
        }

        public static int intializeLastTicket()
        {
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();

            SqlCommand command = new SqlCommand("SELECT MAX(TicketNumber) FROM Ticket", connection);

            LastTicket = Convert.ToInt32(command.ExecuteScalar());

            return LastTicket;
        }

        private void ShowTripsFrom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainBookingDataSet2.Station' table. You can move, or remove it, as needed.
            this.stationTableAdapter.Fill(this.trainBookingDataSet2.Station);
            // TODO: This line of code loads data into the 'trainBookingDataSet1.Train' table. You can move, or remove it, as needed.
            this.trainTableAdapter.Fill(this.trainBookingDataSet1.Train);
            // TODO: This line of code loads data into the 'trainBookingDataSet1.Trip' table. You can move, or remove it, as needed.
            this.tripTableAdapter.Fill(this.trainBookingDataSet1.Trip);

            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();

            // Create DataTables to hold data from each table
            DataTable table1 = new DataTable();

            // Retrieve the desired attributes from the Station table for "Source" column
            string sourceQuery = "SELECT Trip.TripID, Driver.Name as DriverName, Trip.DepartureTime, Trip.ArrivalTime, SourceStation.Name AS Source, DestinationStation.Name AS Destination FROM Trip JOIN Station AS SourceStation ON Trip.TripID = SourceStation.TripID AND SourceStation.station_type = 'Source' JOIN Station AS DestinationStation ON Trip.TripID = DestinationStation.TripID AND DestinationStation.station_type = 'Destination' JOIN Driver ON Trip.DriverID = Driver.DriverID WHERE SourceStation.Name = '" + SStaion + "' AND DestinationStation.Name = '" + DStation + "'";



            SqlDataAdapter sqlDaSource = new SqlDataAdapter(sourceQuery, connection);
            sqlDaSource.Fill(table1);


            // Set the merged DataTable as the DataSource of the DataGridView
            dataGridView4.DataSource = table1;

        }

        private void Booking_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();

            Booking Bk = new Booking();
            /* DateTime departureTime = DTime;*/
            /*DateTime arrivalTime = ATime;*/
            int PassengerID = Customer.cus.CustomerID;
            int TicketNumber = Bk.getTicketNumber(connection) + 1;
            int TrainCapacity = 0;
            int tripID = int.Parse(TripID.Text);

            SqlCommand command = new SqlCommand($"SELECT Capacity From Train WHERE TrainID = (SELECT TrainID FROM Trip WHERE TripID = {tripID})", connection);
            TrainCapacity = (int)command.ExecuteScalar();
            
            DateTime currentDateTime = DateTime.Now;
            int seatNumber = Bk.UpdateSeatNumber(connection, tripID);
            string Type = TicketType;
            int TicketID = 0;

            if (TrainCapacity >= seatNumber + NumofSeats)
            {
                if (Type == "VIP Ticket")
                {
                    decimal price = 520;

                    int BookingID = Bk.AddBooking(connection, PassengerID, TicketNumber, currentDateTime);
                    for (int i = 0; i < this.NumofSeats; i++)
                    {
                        Bk.AddTicket(connection, PassengerID, tripID, Type, price);
                        seatNumber = Bk.UpdateSeatNumber(connection, tripID);
                        Bk.UpdateTicket(connection, PassengerID, tripID, seatNumber, intializeLastTicket());
                        TicketID = Bk.getTicketNumber(connection);
                        Bk.AddTicketToBook(connection, BookingID, TicketID);
                    }
                    Trip.UpdateNumOfPassenger(tripID, NumofSeats);
                }
                else if (Type == "Economic Ticket")
                {
                    decimal price = 260;

                    int BookingID = Bk.AddBooking(connection, PassengerID, TicketNumber, currentDateTime);
                    for (int i = 0; i < this.NumofSeats; i++)
                    {
                        Bk.AddTicket(connection, PassengerID, tripID, Type, price);
                        seatNumber = Bk.UpdateSeatNumber(connection, tripID);
                        Bk.UpdateTicket(connection, PassengerID, tripID, seatNumber, intializeLastTicket());
                        TicketID = Bk.getTicketNumber(connection);
                        Bk.AddTicketToBook(connection, BookingID, TicketID);
                    }
                }
                MessageBox.Show("The Booking is done!");
                ShowTicketForm TicketForm = new ShowTicketForm();
                TicketForm.TicketNum = TicketNumber;
                TicketForm.ShowDialog();
            }
            else
            {
                MessageBox.Show($"The Train Has {TrainCapacity - seatNumber} Seats only");
            }
        }

    }
}
