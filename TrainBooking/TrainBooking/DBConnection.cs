using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace TrainBooking
{
    public class DBConnection
    {
        public SqlConnection ConnectToDatabase()
        {
            string fileName = "TrainBooking.mdf";
            string directory = Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName;
            string dir = Directory.GetParent(directory).FullName;
            /*MessageBox.Show(dir);*/
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dir}\{fileName};Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to DB is failed: " + ex.Message);
            }
            return connection;
        }
    }
}
