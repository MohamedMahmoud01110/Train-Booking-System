using System;
using System.Windows.Forms;

namespace TrainBooking
{
    public partial class BookingForm : Form
    {
        public static int LastTicket;
        public BookingForm()
        {
            InitializeComponent();
            LastTicket = ShowTripsFrom.intializeLastTicket();
        }


        private void ShowTrips_Click(object sender, EventArgs e)
        {

            ShowTripsFrom showTripsFrom = new ShowTripsFrom();
            showTripsFrom.DTime = DepatureTime.Value;
            showTripsFrom.ATime = ArrivalTime.Value;
            showTripsFrom.SStaion = SrcStation.Text;
            showTripsFrom.DStation = DestStation.Text;
            showTripsFrom.TicketType = TicketType.Text;
            showTripsFrom.NumofSeats = (int) NumofSeats.Value;

            int errFlag = 0;

            if (DepatureTime.Value >= ArrivalTime.Value)
            {
                Departure_Arrival.SetError(DepatureTime, "Depature Date must be lower than Arrival Time");
                MessageBox.Show("Depature Date must be lower than Arrival Time");
                ++errFlag;
            }
            else
            {
                Departure_Arrival.Clear();
                --errFlag;
            }

            if (SrcStation.Text == DestStation.Text)
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

            if (TicketType.Text == "")
            {
                TypeErr.SetError(TicketType, "Please Choose the Ticket Type");
                MessageBox.Show("Please Choose the Ticket Type");
                ++errFlag;
            }
            else
            {
                TypeErr.Clear();
                --errFlag;
            }

            if (errFlag == -3)
            {
                showTripsFrom.ShowDialog();
            }
        }
    }
}

