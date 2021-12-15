using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class AirlineCoordinator
    {
        FlightManager flManager;
        CustomerManager custManager;
        BookingManager bookingManager;

        // parameterized constructor
        public AirlineCoordinator(int custIdSeed, int maxCust, int maxFlights)
        {
            flManager = new FlightManager(maxFlights);
            custManager = new CustomerManager(maxCust);
            bookingManager = new BookingManager(flManager, custManager);
        }

        // method for returning true or false to determine if flight is successfully added
        public bool addFlight(int flightNo, string origin, string destination, int maxSeats)
        {
            return flManager.addFlight(flightNo, origin, destination, maxSeats);
        }

        // method for printing all flights
        public string flightList()
        {
            return flManager.getFlightList();
        }

        // method for printing a particular flight through flight ID
        public string particularFlight(int fID)
        {
            if (!flManager.flightExists(fID))
            {
                return "Flight not found.";
            }
            else
            {
                return flManager.getList(fID, bookingManager.getParticularCustomers(fID));

            }
        }

        // method for deleting a flight through flight ID
        public bool deleteFlight(int fid)
        {
            if (!flManager.flightExists(fid))
            {
                return false;
            }
            else if(flManager.getFlight(fid).getNumPassengers() > 0) { return false; }
            return flManager.deleteFlight(fid);
        }

        // method for returning true or false to determine if customer is successfully added
        public bool addCustomer(string fname, string lname, string ph)
        {
            return custManager.addCustomer(fname, lname, ph);
        }

        // method for printing all customers
        public string customerList()
        {
            return custManager.getCustomerList();
        }

        // method for deleting a customer through customer ID
        public bool deleteCustomer(int cId)
        {
            if (!custManager.CustomerExists(cId))
            {
                return false;
            }
            else if (custManager.getCustomer(cId).getNumBookings() > 0) { return false; }
            return custManager.deleteCustomer(cId);
        }

        // method for returning true or false to determine if booking is successfully added
        public bool addBooking(int custID, int flightNum)
        {
            if(!custManager.CustomerExists(custID) && !flManager.flightExists(flightNum))
            {
                return false;
            }
            if (bookingManager.addBooking(custID, flightNum))
            {
                if (bookingManager.updateFlightDatabase(custID, flightNum) && bookingManager.updateCustomerDatabase(custID))
                {
                    return true;
                }
                else return false;
            }
            else
                return false;
        }

        // method for printing all bookings
        public string bookingList()
        {
            return bookingManager.getBookingList();
        }

        // method for deleting a booking through booking ID
        public bool deleteBooking(int bId)
        {

            if (bookingManager.deleteFlightDatabase(bId) && bookingManager.deleteCustomerDatabase(bId))
            {
                if (bookingManager.deleteBooking(bId))
                {
                    return true;
                }
                else return false;
            }
            else
                return false;
        }
    }
}
