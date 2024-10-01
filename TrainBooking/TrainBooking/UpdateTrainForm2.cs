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
    public partial class UpdateTrainForm2 : Form
    {
        public int TID { get; set; }
        public UpdateTrainForm2()
        {
            InitializeComponent();
            this.Load += Train_Load; 

        }
        private void Train_Load(object sender, EventArgs e)
        {
            UserAuthentication auth = new UserAuthentication();
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();
            Train train = new Train();
            train = auth.retrieveTrainData(connection, TID);
            TrainID.Text = train.TrainID.ToString();
            TrainName.Text = train.TrainName;
            TrainStatus.Text = train.TrainStatus;
            TrainCapacity.Text = train.Capacity.ToString();
            TrainID.Enabled = false;
        }

        private void UpdateTrain_Click(object sender, EventArgs e)
        {
            int trainID = UpdateTrainForm1.trainID;
            string name = TrainName.Text;
            string status = TrainStatus.Text;
       
            int capacity = Convert.ToInt32(TrainCapacity.Text);

            Admin admin = new Admin();
            admin.updateTrain(trainID, name, status, capacity);
        }

    }
}
