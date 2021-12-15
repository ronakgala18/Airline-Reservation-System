using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class Booking
    {
        private string date;
        private int bookingNum;
        private Customer customer;
        private Flight flight;

        // Parameterized constructor for date, bookingNum, customer, and flight
        public Booking(string date, int bookingNum, Customer customer, Flight flight)
        {
            this.date = date;
            this.bookingNum = bookingNum;
            this.customer = customer;
            this.flight = flight;
        }

        public int getBookingNumber()
        {
            return bookingNum;
        }

        public string getDate()
        {
            return date;
        }
        public Flight getFlight()
        {
            return flight;
        }
        public Customer getCustomer()
        {
            return customer;
        }
        public string getFullName()
        {

            return customer.getFullName();
        }
        public int getFlightNum()
        {
            return flight.getFlightNumber();
        }
        public int getCustId()
        {
            return customer.getId();
        }

        // ToString method to write information to booking database text file
        public override string ToString()
        {
            string s = date + "," + bookingNum + "," + customer.getFullName() + "," + flight.getFlightNumber();
            return s;
        }

        // toString method to output booking information in the program
        public string toString()
        {
            string s = "Booking Number: " + bookingNum;
            s += "\nBooking Date: " + date;
            s += "\nCustomer Name:" + customer.getFullName();
            s += "\nFlight Number: " + flight.getFlightNumber();
            return s;

        }

    }
}
