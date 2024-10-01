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
    public partial class UpdateTripForm1 : Form
    {
        public static int tripID = 0;
        public UpdateTripForm1()
        {
            InitializeComponent();
        }

        private void SendTripID_Click(object sender, EventArgs e)
        {
            tripID = (int) nTripID.Value;

            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();

            SqlCommand command = new SqlCommand($"SELECT COUNT(TripID) FROM Trip WHERE TripID = {tripID};", connection);
            int count = (int)command.ExecuteScalar();
            if (count == 1)
            {
                tripIDErr.Clear();
                UpdateTripForm2 form2 = new UpdateTripForm2();
                form2.ShowDialog();  
            }
            else
            {
                tripIDErr.SetError(nTripID, "No Trip With this ID, Try Again");
                MessageBox.Show("No Trip With this ID, Try Again.");
            }
        }
    }
}
