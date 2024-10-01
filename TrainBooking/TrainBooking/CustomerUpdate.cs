using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrainBooking
{
    public partial class CustomerUpdate : Form
    {
        public CustomerUpdate()
        {
            InitializeComponent();
            this.Load += CustomerUpdate_Load; // Add the event handler to the Load event
        }

        private void CustomerUpdate_Load(object sender, EventArgs e)
        {
            // Your code to retrieve and assign values to textboxes
            int cID = Customer.cus.CustomerID;
            string cName = Customer.cus.Name;
            string cEmail = Customer.cus.Email;
            string cPassword = Customer.cus.Password;

            ID.Text = cID.ToString();
            this.name.Text = cName;
            Email.Text = cEmail;
            Password.Text = cPassword;

            ID.Enabled = false;
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();

            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();
            UserAuthentication auth = new UserAuthentication();

            string cEmail = Customer.cus.Email;

            string name = this.name.Text;
            string email = Email.Text;
            string password = Password.Text;
            int cID = Customer.cus.CustomerID;
            if (!auth.isValidEmail(email))
            {
                // Set the error message and icon for the Email TextBox
                errorProvider.SetError(Email, "Enter a valid Email");
            }
            else if (auth.IsEmailExist(connection, email) && email != cEmail)
            {
                // Set the error message and icon for the Email TextBox
                errorProvider.SetError(Email, "This Email is exist");
            }
            else if (string.IsNullOrEmpty(name))
            {
                errorProvider.SetError(this.name, "Name is required.");
            }
            else if (string.IsNullOrEmpty(password))
            {
                errorProvider.SetError(Password, "Password is required.");
            }
            else
            {
                // Clear the error message and icon for the Email TextBox
                errorProvider.SetError(Email, string.Empty);
                auth.updateCustomer(connection, cID, name, email, password);
                Customer.cus.UpdateDetails(name, email, password);
                MessageBox.Show("Updated!");
            }

        }
    }
}
