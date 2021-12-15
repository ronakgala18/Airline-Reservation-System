using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string phone;
        private int bookings;

        // parameterized constructor for customerId, firstName, lastName, phone, and bookings
        public Customer(int cId, string fname, string lname, string ph, int booking)
        {
            bookings = booking;
            customerId = cId;
            firstName = fname;
            lastName = lname;
            phone = ph;
        }
        public int getId() { return customerId; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getFullName() { return firstName + lastName; }
        public string getPhone() { return phone; }
        public int getNumBookings() { return bookings; }
        public bool addBookin()
        {
            bookings++;
            return true;
        }
        public bool removeBooking()
        {
            bookings--;
            return true;
        }

        // ToString method to write information to customer database text file
        public override string ToString()
        {
            string s = customerId + "," + firstName + "," + lastName + "," + phone + "," + bookings;
            return s;
        }

        // toString method to output booking information in the program
        public string toString()
        {
            string s = "Customer " + customerId;
            s = s + "\nName: " + firstName + " " + lastName;
            s = s + "\nPhone: " + phone;
            s = s + "\nBookings: " + bookings;

            return s;
        }

    }
}
