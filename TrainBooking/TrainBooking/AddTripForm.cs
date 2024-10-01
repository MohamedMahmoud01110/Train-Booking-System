using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TrainBooking
{
    public partial class AddTripForm : Form
    {
        public AddTripForm()
        {
            InitializeComponent();
        }

        private void AddTrip_Click(object sender, EventArgs e)
        {
            int trainID = (int)TrainID.Value;
            int driverID = (int)DriverID.Value;
            DateTime departureT = DepartureTime.Value;
            DateTime arrivalT = ArrivalTime.Value;
            string srcName = SrcStation.Text;
            string destName = DestStation.Text;

            int errFlag = 0;

            if (departureT >= arrivalT){
                Depature_Arrival.SetError(DepartureTime, "Depature Date must be lower than Arrival Time");
                MessageBox.Show("Depature Date must be lower than Arrival Time");
                ++errFlag;
            } else {
                Depature_Arrival.Clear();
                --errFlag;
            }

            if (srcName == destName) {
                SrcEqDest.SetError(SrcStation, "Source Station Cannot be the same as Destination Station");
                MessageBox.Show("Source Station Cannot be the same as Destination Station");
                ++errFlag;
            } else {
                SrcEqDest.Clear();
                --errFlag;
            }
            

            Trip trip = new Trip(departureT, arrivalT);

            if (!trip.setTrainID(trainID))
            {
                TrainIDErr.SetError(TrainID, "This TrainID is not Exist, Try Another One.");
                MessageBox.Show("This TrainID is not Exist, Try Another One.");
                ++errFlag;
            } else { 
                TrainIDErr.Clear();
                --errFlag;
            }

            if (!trip.setDriverID(driverID))
            {
                DriverIDErr.SetError(DriverID, "This DriverID is not Exist, Try Another One.");
                MessageBox.Show("This DriverID is not Exist, Try Another One.");
                ++errFlag;
            } else {
                DriverIDErr.Clear();
                --errFlag;
            }
            
            if (errFlag == -4)
            {
                Admin admin = new Admin();
                admin.addTrip(trip, srcName, destName);
            }
        }
    }
}
