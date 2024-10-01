using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainBooking
{
    public class Report
    {
        public decimal TotalPrice(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("Select SUM(price) from Ticket", connection);
            decimal total = Convert.ToDecimal(command.ExecuteScalar());
            return total;
        }
        public int TotalCustomer(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("SELECT MAX(UserID) FROM [User]", connection);
            int total = Convert.ToInt32(command.ExecuteScalar());
            return total;
        }

    }
}
