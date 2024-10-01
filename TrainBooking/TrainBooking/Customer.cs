using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainBooking
{
    public class Customer
    {
        public static Customer cus;
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Customer(int customerID, string name, string email, string password)
        {
            CustomerID = customerID;
            Name = name;
            Email = email;
            Password = password;
            cus = this;
        }

        public Customer()
        {
        }

        public void UpdateDetails(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            cus.Name = name;
            cus.Email = email;
            cus.Password = password;
        }

        public static void InitializeCus(int id, string name, string email, string password)
        {
            cus = new Customer(id, name, email, password);
        }
    }
}
