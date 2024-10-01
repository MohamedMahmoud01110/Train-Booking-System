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
using TrainBooking;

namespace TrainBooking
{
    public partial class CustomerHomeForm : Form
    {
        public CustomerHomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookingForm homeCustomer = new BookingForm();
            homeCustomer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerUpdate customerUpdate = new CustomerUpdate();
            customerUpdate.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ListBookingForm listBopking = new ListBookingForm();
            listBopking.ShowDialog();
        }
    }
}

