using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class FlightManager
    {

        private int maxFlights;
        private Flight[] flightList;

        // parameterized constructor for maxFlights
        public FlightManager(int max)
        {
            maxFlights = max;
        }

        // method for retrieving number of flights in text file
        public int getNumFLight()
        {
            if (File.Exists("flight_database.txt"))
            {
                int lineCount = File.ReadLines("flight_database.txt").Count();
                return lineCount;
            }
            else
            {
                return 0;
            }
        }

        // method for creating a flight and writing the information into the array and flight database text file
        public bool addFlight(int fn, string origin, string destination, int maxSeats)
        {
            if (getNumFLight() > 0)
            {
                Flight[] list = loadFightDatabase();
                for (int x = 0; x < list.Length; x++)
                {
                    if (list[x].getFlightNumber() == fn)
                    {
                        return false;
                    }
                }
            }
            if (getNumFLight() >= maxFlights) { return false; }
            StreamWriter outputFile = new StreamWriter("flight_database.txt", true);
            Flight f = new Flight(fn, origin, destination, maxSeats, 0);
            outputFile.WriteLine(f);
            outputFile.Close();
            return true;
        }

        // method for retrieving the position of a flight in the array using the flight ID
        public int findFlight(int fid)
        {
            Flight[] list = loadFightDatabase();
            for (int x = 0; x < list.Length; x++)
            {
                if (list[x].getFlightNumber() == fid)
                    return x;
            }
            return -1;
        }

        // method for checking if the flight exists in the array
        public bool flightExists(int fid)
        {
            int loc = findFlight(fid);
            if (loc == -1) { return false; }
            return true;
        }

        // method for retrieving particular flight based on flight id
        public Flight getFlight(int fid)
        {
            int loc = findFlight(fid);
            if (loc == -1) { return null; }
            flightList = loadFightDatabase();
            return flightList[loc];
        }

        // method for deleting a flight through flight id
        public bool deleteFlight(int fid)
        {
            List<Flight> list = loadFightDatabase().ToList();
            int loc = findFlight(fid);
            if (loc == -1) { return false; }
            list.RemoveAt(loc);
            StreamWriter outputFile = new StreamWriter("flight_database.txt");
            for (int x = 0; x < list.Count; x++)
            {
                Flight f = new Flight(list[x].getFlightNumber(), list[x].getOrigin(), list[x].getDestination(), list[x].getAvailableSeats(), list[x].getNumPassengers());
                outputFile.WriteLine(f);
            }
            outputFile.Close();

            return true;
        }

        // method for printing out the list of customers that is written in the flight database text file
        public string getFlightList()
        {

            Flight[] list = loadFightDatabase();
            string s = "Flight List: ";
            if (list == null) { return "No Flight Added"; }
            for (int x = 0; x < list.Length; x++)
            {
                s = s + "\r\n\r\nFlight Number: " + list[x].getFlightNumber() + "\r\nDestination: From " + list[x].getOrigin() + " to " + list[x].getDestination();
            }
            return s;
        }

        // method for printing out the information of a particular flight
        // prints flight details and passenger list
        public string getList(int fId, Customer[] c)
        {
            string s = "Flight Details:";
            Flight f = getFlight(fId);
            if (c != null)
            {
                return s + "\r\n" + f.toString() + f.getPassengerList(c); ;
            }
            else if (f == null)
            {
                return "Flight does not exist.";
            }
            else
            {
                return s + "\r\n" + f.toString() + "\r\nNo passengers on flight";
            }

        }

        // method for retrieving all flights from the flight database text file and returns it as an array
        public Flight[] loadFightDatabase()
        {
            if (File.Exists("flight_database.txt"))
            {
                StreamReader input = new StreamReader("flight_database.txt", true);
                int lineCount = File.ReadLines("flight_database.txt").Count();
                Flight[] list = new Flight[lineCount];
                string[] fliList;
                int count = 0;
                while (input.Peek() != -1)
                {
                    char c = ',';
                    fliList = input.ReadLine().Split(c);
                    int availSeats;
                    int Width = 0;
                    if (Int32.TryParse(fliList[3], out availSeats))
                    {
                        Width = availSeats;
                    }
                    list[count++] = new Flight(Convert.ToInt32(fliList[0]),
                                                fliList[1],
                                                fliList[2],
                                                Convert.ToInt32(fliList[3]) + Convert.ToInt32(fliList[4]),
                                                Width);
                }
                input.Close();

                return list;
            }
            else return null;

        }
    }
}
