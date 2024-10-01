using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrainBooking
{
    public class Train
    {

        public int TrainID;
        public string TrainName;
        public string TrainStatus;
        public int Capacity;


        public Train(int trainID, string trainName, string trainStatus, int capacity)
        {
            TrainID = trainID;
            TrainName = trainName;
            TrainStatus = trainStatus;
            Capacity = capacity;
        }
        public Train() { }

        public Train GetTrain()
        {
            return this;
        }
        public static bool validateID(SqlConnection connection, int ID)
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [Train] WHERE TrainID = @ID", connection);
            command.Parameters.AddWithValue("@ID", ID);

            int count = (int)command.ExecuteScalar();
            return count == 1;
        }
    }

}


