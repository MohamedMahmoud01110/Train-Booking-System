using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrainBooking
{
    public class Booking
    {
        public int AddBooking(SqlConnection connection, int PassengerID, int TicketNumber, DateTime BookingDate)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Booking] (PassengerID, BookingDate) VALUES ({PassengerID}, Convert(DateTime, '{BookingDate.ToShortDateString() + " " + BookingDate.ToShortTimeString()}'));", connection);
            command.ExecuteNonQuery();

            command = new SqlCommand("SELECT MAX(BookingId) From Booking", connection);
            int BookingID = (int)command.ExecuteScalar();
            return BookingID;
        }

        public void AddTicket(SqlConnection connection, int PassngerID, int TripID, string TypeTicket, decimal price,int seatNumber = 1)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Ticket] (PassengerID, TripID, seatNumber ,ticketType, price) VALUES (" + PassngerID + "," + TripID + "," + seatNumber + ",'" + TypeTicket + "'," + price + ")", connection);
            command.ExecuteNonQuery();
        }
        public int UpdateSeatNumber(SqlConnection connection, int TripID)
        {
            int seat = 0;
            SqlCommand command = new SqlCommand($"SELECT MAX(seatNumber) FROM Ticket WHERE TripID = {TripID}", connection);
            try
            {
                seat = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (System.InvalidCastException)
            {
                return seat;
            }
            return seat;  
        }
        public void UpdateTicket(SqlConnection connection, int PassngerID, int TripID, int seatNumber, int LastTicket)
        {
            SqlCommand command = new SqlCommand("UPDATE [Ticket] SET seatNumber = "+ (seatNumber + 1) +" where PassengerID = "+PassngerID+" and TripID = "+TripID+" and TicketNumber = "+LastTicket+";", connection);
            command.ExecuteNonQuery();
        }

        public void DeleteBooking(SqlConnection connection, int BookingID, int TicketNumber)
        {
           // SqlCommand command = new SqlCommand($"DELETE FROM BookingContains WHERE BookingID = {BookingID} AND TicketNumber = {TicketNumber} ;", connection);

            SqlCommand command = new SqlCommand($"DELETE FROM Booking WHERE BookingId = {BookingID} AND BookingId NOT IN (SELECT BookingID FROM BookingContains WHERE BookingID = {BookingID}) ;", connection);
            command.ExecuteNonQuery();
        }

        public void DeleteTicket(SqlConnection connection, int TicketNumber)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Ticket WHERE TicketNumber = " + TicketNumber + ";", connection);
            command.ExecuteNonQuery();
        }
        public int getTicketNumber(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("Select MAX(TicketNumber) FROM Ticket", connection);
            int TicketNum = Convert.ToInt32(command.ExecuteScalar());
            return TicketNum;
        }

        public void AddTicketToBook(SqlConnection connection, int BookingID, int TicketID)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO BookingContains VALUES({BookingID}, {TicketID})", connection);
            command.ExecuteNonQuery();
        }
    }
}
