using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainBooking
{

    public partial class UpdateTripForm2 : Form
    {
        public UpdateTripForm2()
        {
            InitializeComponent();
            this.Load += Form_Load;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Trip trip = new Trip();
            trip.retrieveTripData(UpdateTripForm1.tripID);

            TrainID.Value = trip.TrainID;
            DriverID.Value = trip.DriverID;
            DepartureTime.Value = DateTime.Parse(trip.departureT);
            ArrivalTime.Value = DateTime.Parse(trip.arrivalT);


            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();

            SqlCommand command = new SqlCommand($"SELECT Name FROM Station WHERE TripID = {trip.TripID} AND Station_Type = 'Source'", connection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read()) // Check if there is a row to read
            {
                SrcStation.Text = reader.GetString(0);
            }
            reader.Close();


            command = new SqlCommand($"SELECT Name FROM Station WHERE TripID = {trip.TripID} AND Station_Type = 'Destination'", connection);
            reader = command.ExecuteReader();
            if (reader.Read()) // Check if there is a row to read
            {
                DestStation.Text = reader.GetString(0);
            }
            reader.Close();

        }

        private void UpdateTrip_Click(object sender, EventArgs e)
        {
            int trainID = (int)TrainID.Value;
            int driverID = (int)DriverID.Value;
            DateTime departureT = DepartureTime.Value;
            DateTime arrivalT = ArrivalTime.Value;
            string srcName = SrcStation.Text;
            string destName = DestStation.Text;

            int errFlag = 0;

            if (departureT >= arrivalT)
            {
                Depature_Arrival.SetError(DepartureTime, "Depature Date must be lower than Arrival Time");
                MessageBox.Show("Depature Date must be lower than Arrival Time");
                ++errFlag;
            }
            else
            {
                Depature_Arrival.Clear();
                --errFlag;
            }

            if (srcName == destName)
            {
                SrcEqDest.SetError(SrcStation, "Source Station Cannot be the same as Destination Station");
                MessageBox.Show("Source Station Cannot be the same as Destination Station");
                ++errFlag;
            }
            else
            {
                SrcEqDest.Clear();
                --errFlag;
            }


            Trip trip = new Trip(departureT, arrivalT);
            trip.TripID = UpdateTripForm1.tripID;

            if (!trip.setTrainID(trainID))
            {
                TrainIDErr.SetError(TrainID, "This TrainID is not Exist, Try Another One.");
                MessageBox.Show("This TrainID is not Exist, Try Another One.");
                ++errFlag;
            }
            else
            {
                TrainIDErr.Clear();
                --errFlag;
            }

            if (!trip.setDriverID(driverID))
            {
                DriverIDErr.SetError(DriverID, "This DriverID is not Exist, Try Another One.");
                MessageBox.Show("This DriverID is not Exist, Try Another One.");
                ++errFlag;
            }
            else
            {
                DriverIDErr.Clear();
                --errFlag;
            }

            if (errFlag == -4)
            {
                Admin admin = new Admin();
                admin.updateTrip(trip, srcName, destName);
            }
        }
    }
}
