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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrainBooking
{
    public partial class AddTrainForm : Form
    {
        public AddTrainForm()
        {
            InitializeComponent();
        }

        private void AddTrain_Click(object sender, EventArgs e)
        {
            string name = TrainName.Text;
            string status = TrainStatus.Text;
            // Want Validation if its really a number
            int capacity = Convert.ToInt32(TrainCapacity.Text);

            Admin admin = new Admin();

            admin.addTrain(name, status, capacity);

            MessageBox.Show("Train Added successfully!");
        }

    }
}
