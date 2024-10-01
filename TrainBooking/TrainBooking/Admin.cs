using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TrainBooking
{
    public class Admin
    {
        private static Dictionary<string, string> StationLocations = new Dictionary<string, string>()
        {
            // Dictionary for Station : location Names
            {"Valentine",  "The Heartlands"},
            {"Rhodes",  "Scarlett Meadows"},
            {"Blackwater",  "Great Plains"},
            {"Saint Denis",  "Bayou Nwa"},
            {"Van Horn",  "Roanoke Ridge"},
            {"Annesburg",  "Roanoke Ridge"},
            {"Riggs Station",  "Big Valley"},
            {"Emerald Station",  "The Heartlands"},
            {"Bacchus Station",  "Cumberland Forest"}
        };

      public void addTrain(string trainName, string trainStatus, int capacity)
        {
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();
            SqlCommand command1 = new SqlCommand($"SELECT MAX(TrainID) FROM Train;", connection);
            int id = (int)command1.ExecuteScalar();
            id += 1;

            SqlCommand command = new SqlCommand($"INSERT INTO Train (TrainID,Name, Status, Capacity) VALUES ('{id}','{trainName}', '{trainStatus}', {capacity});", connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Train added successfully.");
            connection.Close();
            return;
        }

      public void updateTrain(int trainID , string name, string status, int capacity)
        {
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();
            string updateQuery = $"UPDATE Train SET Name = '{name}', Status = '{status}', Capacity = {capacity} WHERE TrainID = {trainID}";
            SqlCommand command = new SqlCommand(updateQuery, connection);

            command.ExecuteNonQuery();
            MessageBox.Show($"Train #{trainID} Has been Updated Successfully :)");
            connection.Close();
            return;

        }

        public void addTrip(Trip trip, string srcStation, string destStation)
        {
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();
          
            // Insert Trip Data to DB
            SqlCommand command = new SqlCommand($"INSERT INTO Trip (TrainID, DriverID, DepartureTime, ArrivalTime) VALUES ({trip.TrainID}, {trip.DriverID}, CONVERT(datetime, '{trip.departureT}'), CONVERT(datetime, '{trip.arrivalT}'));", connection);
            command.ExecuteNonQuery();

            // Getting the TripID By getting the biggest ID(the ID that Just added to the table) in Trip Table
            command = new SqlCommand($"SELECT MAX(TripID) FROM Trip;", connection);
            SqlDataReader TripIDReader = command.ExecuteReader();

            int tripID = 0;
            if (TripIDReader.HasRows)
            {
                // Read the first (and only) row of the result set (TripID)
                TripIDReader.Read();

                // Get the value of the first (and only) column (TripID)
                tripID = TripIDReader.GetInt32(0);

                TripIDReader.Close();

                // Storing Source Station Data in DB
                command = new SqlCommand($"INSERT INTO Station VALUES({tripID}, '{srcStation}', '{StationLocations[srcStation]}', 'Source')", connection);
                command.ExecuteNonQuery();

                // Storing Destination Station Data in DB
                command = new SqlCommand($"INSERT INTO Station VALUES({tripID}, '{destStation}', '{StationLocations[destStation]}', 'Destination')", connection);
                command.ExecuteNonQuery();
            }
            MessageBox.Show($"Trip #{tripID} Has been Added to System Successfully :)");
            connection.Close();
            return;
        }

        public void updateTrip(Trip trip, string srcStation, string destStation)
        {
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();

            // Updating Trip Data in DB
            SqlCommand command = new SqlCommand($"UPDATE Trip SET TrainID = {trip.TrainID}, DriverID = {trip.DriverID}, DepartureTime = CONVERT(datetime, '{trip.departureT}'),  ArrivalTime = CONVERT(datetime, '{trip.arrivalT}') WHERE TripID = {trip.TripID};", connection);
            command.ExecuteNonQuery();

            // Updating Source Station Data in DB
            command = new SqlCommand($"UPDATE Station SET Name = '{srcStation}', location = '{StationLocations[srcStation]}' WHERE Station_Type =  'Source' AND TripID = {trip.TripID}", connection);
            command.ExecuteNonQuery();

            // Updating Destination Station Data in DB
            command = new SqlCommand($"UPDATE Station SET Name = '{destStation}', location = '{StationLocations[destStation]}' WHERE Station_Type =  'Destination' AND TripID = {trip.TripID}", connection);
            command.ExecuteNonQuery();

            MessageBox.Show($"Trip #{trip.TripID} Has been Updated Successfully :)");
            connection.Close();
            return;
        }
      
    }
}
