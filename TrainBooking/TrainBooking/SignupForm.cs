using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrainBooking
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }
        private void Sign_upButton_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();

            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();

            UserAuthentication signup = new UserAuthentication();

            string type = Type.Text;
            string name = this.name.Text;
            string email = Email.Text;
            string password = Password.Text;

            if (!signup.isValidEmail(email))
            {
                // Set the error message and icon for the Email TextBox
                errorProvider.SetError(Email, "Enter a valid Email");
            }
            else if (signup.IsEmailExist(connection, email))
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

                if (type == "Customer")
                {
                    signup.customerRegister(connection, name, email, password);
                    MessageBox.Show("Signup is successful!");
                }
                else
                {
                    signup.adminRegister(connection, name, email, password);
                    MessageBox.Show("Signup is successful!");
                }
            }

            connection.Close();
        }
    }
}
