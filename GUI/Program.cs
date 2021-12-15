using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        
        // create AirlineCoordinator variable to be used for all methods
        static AirlineCoordinator aCoord;

        // method for returning true or false to determine if flight is successfully deleted
        public static bool deleteFlight(int id)
        {
            if (aCoord.deleteFlight(id))
            {
            return true;
            }
            else
            {
            return false;
            }
        }

        // method for returning true or false to determine if customer is successfully deleted
        public static bool deleteCustomer(int id)
        {

        if (aCoord.deleteCustomer(id))
        {
            return true;
        }
        else
        {
            return false;
        }

        }

        // method for returning true or false to determine if booking is successfully deleted
        public static bool deleteBooking(int id)
        {
            if (aCoord.deleteBooking(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // method for printing all flights to GUI
        public static string viewFlights()
        {
            String s = aCoord.flightList();
            return s;

        }

        // method for printing a particular flight to GUI
        public static string viewParticularFlight(int flightNum)
        {
            string s=aCoord.particularFlight(flightNum);
                return s;
        }

        // method for printing all customers to GUI
        public static string viewCustomer()
        {
            string s=aCoord.customerList();
                return s;
        }

        // method for printing all bookings to GUI
        public static string viewBooking()
        {

            string s=aCoord.bookingList();
                return s;
        }

        // method for returning true or false to determine if flight is successfully added in the GUI
        public static bool addFlight(int fNum,int FNumSeat,string origin,string destination)
        {
                
            if (aCoord.addFlight(fNum, origin, destination, FNumSeat))
            {
            return true;
            }
            else
            {
            return false;
            }
        }

        // method for returning true or false to determine if customer is successfully added in the GUI
        public static bool addCustomer(string fname,string lname,string ph)
        {
            if (aCoord.addCustomer(fname, lname, ph))
            {
                    return true;
            }
            else
            {
                return false;
            }
        }

        // method for returning true or false to determine if booking is successfully added in the GUI
        public static bool addBooking(int customerId, int flightNum)
        {
            if (aCoord.addBooking(customerId, flightNum))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        // calls the main form and creates a AirlineCoordinator object
        static void Main()
        {
            aCoord = new AirlineCoordinator(100, 20, 30);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }

    }
}

