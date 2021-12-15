using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class Flight
    {
        private int flightNumber;
        private string origin;
        private string destination;
        private int maxSeats;
        private int numPassengers;
        private Customer[] passengers;
        private Customer[] passengers1;

        public Flight(int fn, string or, string dest, int mSeats, int numPass)
        {
            maxSeats = mSeats;
            flightNumber = fn;
            origin = or;
            destination = dest;
            numPassengers = numPass;
            passengers = new Customer[maxSeats];
        }

        public int getFlightNumber() { return flightNumber; }
        public string getOrigin() { return origin; }
        public string getDestination() { return destination; }
        public int getMaxSeats() { return maxSeats; }
        public int getNumPassengers() { return numPassengers; }

        public bool addPassenger(Customer c)
        {
            if (numPassengers >= maxSeats) { return false; }
            passengers[numPassengers] = c;
            numPassengers++;
            return true;
        }


        public int findPassenger(int custId)
        {
            passengers1 = CustomerManager.loadCustomerDatabase();
            for (int x = 0; x < maxSeats; x++)
            {
                if (passengers1[x].getId() == custId)
                    return x;
            }
            return -1;
        }

        public bool removePassenger(int custId)
        {
            passengers1 = CustomerManager.loadCustomerDatabase();
            int loc = findPassenger(custId);
            if (loc == -1) return false;
            passengers1[loc] = passengers1[numPassengers - 1];
            numPassengers--;
            return true;
        }

        public string getPassengerList(Customer[] c)
        {
            passengers = c;
            string s = "\nPassengers on Flight: " + flightNumber;
            for (int x = 0; x < numPassengers; x++)
            {
                s = s + "\n" + passengers[x].getFirstName() + " " + passengers[x].getLastName();
            }
            return s;
        }
        public int getAvailableSeats()
        {
            return (maxSeats - numPassengers);
        }
        public override string ToString()
        {
            string s = flightNumber+ "," + origin + "," + destination + "," + numPassengers + "," + getAvailableSeats();
            return s;

        }
        public string toString()
        {
            string s = "Flight Number: " + flightNumber;
            s = s + "\nOrigin: " + origin;
            s = s + "\nDestination: " + destination;
            s = s + "\nNumber of Passengers: " + numPassengers;
            s = s + "\nAvailable seats: " + (maxSeats - numPassengers);
            return s;
        }
    }
}
