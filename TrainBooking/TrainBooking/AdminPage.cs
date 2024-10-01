using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainBooking
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AddTrainLink_Click(object sender, EventArgs e)
        {
            AddTrainForm addTrainForm = new AddTrainForm();
            addTrainForm.ShowDialog();
        }

        private void AddTripLink_Click(object sender, EventArgs e)
        {
            AddTripForm addTripForm = new AddTripForm();
            addTripForm.ShowDialog();
        }

        private void UpdateTrainLink_Click(object sender, EventArgs e)
        {
            UpdateTrainForm1 updateTrainForm = new UpdateTrainForm1();
            updateTrainForm.ShowDialog();
        }

        private void UpdateTripLink_Click(object sender, EventArgs e)
        {
            UpdateTripForm1 updateTripForm = new UpdateTripForm1();
            updateTripForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();*/
            ReportForm2 reportForm2 = new ReportForm2();
            reportForm2.ShowDialog();
        }
    }
}
