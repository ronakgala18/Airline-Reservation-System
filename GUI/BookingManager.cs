using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class BookingManager
    {
        private Booking[] bookingList;
        private CustomerManager cm;
        private FlightManager fm;

        // parameterized constructor for fm and cm
        public BookingManager(FlightManager fm, CustomerManager cm)
        {

            this.cm = cm;
            this.fm = fm;
        }

        // method for retrieving the number of bookings in text file
        public int getNumBooking()
        {
            // checks if file exists
            if (File.Exists("booking_database.txt"))
            {

                // retrieves line count number
                int lineCount = File.ReadLines("booking_database.txt").Count();
                return lineCount;
            }
            else
            {
                // if file doesn't exist, return 0
                return 0;
            }
        }
        
        // method for generating a random booking number when user creates booking
        public int generateBookingNum()
        {
            Random rnd = new Random();
            int num = rnd.Next(100000);
            return num;
        }

        // method for adding a booking and writing the information into the array and booking database text file
        public bool addBooking(int custID, int flightNum)
        {
            if (checkBooking(custID, flightNum))
            {
                return false;
            }

            if (fm.getFlight(flightNum).getAvailableSeats() == 0 && fm.getFlight(flightNum).addPassenger(cm.getCustomer(custID)))
            {
                return false;
            }

            StreamWriter outputFile = new StreamWriter("booking_database.txt", true);
            int bookingNum = generateBookingNum();
            string date = DateTime.Now.ToString(@"MM/dd/yyyy h:mm tt");
            Booking b = new Booking(date, bookingNum, cm.getCustomer(custID), fm.getFlight(flightNum));
            outputFile.WriteLine(b);
            outputFile.Close();
            return true;

        }

        // method for checking if the booking has already been made
        public bool checkBooking(int custID, int flightNum)
        {
            Booking[] bookings = loadBookingDatabase();
            if (bookings != null)
            {
                foreach (Booking b in bookings)
                    if (custID == b.getCustId() && flightNum == b.getFlightNum())
                    {
                        return true;
                    }
            }
            return false;
        }

        // method for updating the flight database text file when user adds a booking
        // writes the flight information to the text file
        public bool updateFlightDatabase(int cId, int fId)
        {
            Flight flight = fm.getFlight(fId);
            if (flight.addPassenger(cm.getCustomer(cId)))
            {
                string new1 = fId + "," + flight.getOrigin() + "," + flight.getDestination() + "," + flight.getNumPassengers() + "," + flight.getAvailableSeats();
                int lineNum = GetLineNumber(fId, "flight_database.txt");
                lineChanger(new1, "flight_database.txt", lineNum);
                return true;
            }
            else
            {
                return false;
            }
        }

        // method for updating the customer text file when user adds a booking
        // writes the customer information to the text file
        public bool updateCustomerDatabase(int cId)
        {
            Customer c = cm.getCustomer(cId);
            if (c.addBookin())
            {
                string new1 = cId + "," + c.getFirstName() + "," + c.getLastName() + "," + c.getPhone() + "," + c.getNumBookings();
                int lineNum = GetLineNumber(cId, "customer_database.txt");
                lineChanger(new1, "customer_database.txt", lineNum);
                return true;
            }
            else
            {
                return false;
            }
        }

        // method for retrieving the line number where the information gets updated
        public int GetLineNumber(int l, string filename)
        {
            int lineNum = 0;
            string line;
            string lineToFind = l.ToString();
            StreamReader file = new StreamReader(filename);
            while ((line = file.ReadLine()) != null)
            {
                lineNum++;
                if (line.Contains(lineToFind))
                {
                    file.Close();
                    return lineNum;
                }
            }
            file.Close();
            return -1;
        }

        // method for changing the information in the specific line number
        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        // method for retrieving the position of a booking in the array using the booking ID
        public int findBooking(int bId)
        {
            Booking[] list = loadBookingDatabase();
            if (list == null) { return -1; }
            for (int x = 0; x < list.Length; x++)
            {
                if (list[x].getBookingNumber() == bId)
                    return x;
            }
            return -1;
        }

        // method for checking if booking exists in the array
        public bool bookingExists(int bId)
        {
            int loc = findBooking(bId);
            if (loc == -1) { return false; }
            return true;
        }

        // method for retrieving particular booking based on booking id
        public Booking getBooking(int bId)
        {
            int loc = findBooking(bId);
            if (loc == -1) { return null; }
            bookingList = loadBookingDatabase();
            return bookingList[loc];
        }

        // method for retrieving a specific customer based on flight id
        public Customer[] getParticularCustomers(int fID)
        {
            Customer[] c = new Customer[100];
            Booking[] list = loadBookingDatabase();
            int count = 0;
            if (list == null)
            {
                return null;
            }
            for (int x = 0; x < list.Length; x++)
            {
                if (list[x].getFlightNum() == fID)
                {
                    c[count++] = list[x].getCustomer();
                }
            }
            return c;
        }

        // method for deleting a booking based on booking id
        public bool deleteBooking(int bId)
        {
            List<Booking> list = loadBookingDatabase().ToList();
            if (list == null) { return false; }
            int loc = findBooking(bId);
            if (loc == -1) { return false; }
            list.RemoveAt(loc);
            StreamWriter outputFile = new StreamWriter("Booking_database.txt");
            for (int x = 0; x < list.Count; x++)
            {
                Booking f = new Booking(list[x].getDate(), list[x].getBookingNumber(), list[x].getCustomer(), list[x].getFlight());
                outputFile.WriteLine(f);
            }
            outputFile.Close();

            return true;
        }

        // method for changing flight details such as number of seats available when user updates a booking
        public bool deleteFlightDatabase(int bId)
        {
            
            Booking b = getBooking(bId);
            if (b == null)
            {
                return false;
            }
            else
            {
                int fId = b.getFlightNum();
                int cId = b.getCustId();

                Flight flight = fm.getFlight(fId);
                if (flight.removePassenger(cId))
                {
                    string new1 = fId + "," + flight.getOrigin() + "," + flight.getDestination() + "," + flight.getNumPassengers() + "," + flight.getAvailableSeats();
                    int lineNum = GetLineNumber(fId, "flight_database.txt");
                    lineChanger(new1, "flight_database.txt", lineNum);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // method for changing customer details when user updates a booking
        public bool deleteCustomerDatabase(int bId)
        {
            Booking b = getBooking(bId);
            int cId = b.getCustId();
            Customer c = cm.getCustomer(cId);
            if (c.removeBooking())
            {
                string new1 = cId + "," + c.getFirstName() + "," + c.getLastName() + "," + c.getPhone() + "," + c.getNumBookings();
                int lineNum = GetLineNumber(cId, "customer_database.txt");
                lineChanger(new1, "customer_database.txt", lineNum);
                return true;
            }
            else
            {
                return false;
            }
        }

        // method for printing out the list of bookings that is written in the booking database text file
        public string getBookingList()
        {
            if (File.Exists("booking_database.txt"))
            {
                StreamReader input = new StreamReader("booking_database.txt", true);
                int lineCount = File.ReadLines("booking_database.txt").Count();
                string[] list;
                string s = "Booking List:";
                if (lineCount > 0)
                {
                    while (input.Peek() != -1)
                    {
                        list = input.ReadLine().Split(',');
                        s = s + "\r\n" + "\r\nDate: " + list[0] + "\r\nBooking Number:  " + list[1] + "\r\nCustomer Name: " + list[2] + "\r\nFlight Number: " + list[3];

                    }
                    input.Close();
                }
                input.Close();
                return s;
            }
            else
            {
                return "No booking exists";
            }
        }

        // method for retrieving all bookings from the booking database text file and returns it as an array
        public Booking[] loadBookingDatabase()
        {
            if (File.Exists("booking_database.txt"))
            {
                int lineCount = File.ReadLines("booking_database.txt").Count();
                StreamReader input = new StreamReader("booking_database.txt", true);
                Booking[] list = new Booking[lineCount];
                string[] fliList;
                int count = 0;
                char c = ',';
                if (lineCount > 0)
                {
                    while (input.Peek() != -1)
                    {
                        fliList = input.ReadLine().Split(c);
                        int cID = cm.findCustomer(fliList[2]);
                        Customer cust = cm.getCustomer(cID);
                        Flight fli = fm.getFlight(Convert.ToInt32(fliList[3]));
                        list[count++] = new Booking(fliList[0], Convert.ToInt32(fliList[1]), cust, fli);
                    }
                    input.Close();
                    return list;
                }
                else
                {
                    input.Close();
                    return null;

                }
            }
            else
            { 
                return null; 
            }
        }

    }
}
