using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class CustomerManager
    {
        private int maxCustomer;
        private Customer[] customerList;

        // parameterized constructor for maxCustomer
        public CustomerManager(int max)
        {
            maxCustomer = max;

        }

        // method for retrieving number of customer in text file
        public int getNumCust()
        {
            if (File.Exists("customer_database.txt"))
            {
                int lineCount = File.ReadLines("customer_database.txt").Count();
                return lineCount;
            }
            else
            {
                return 0;
            }
        }

        // method for generating a random customer id when user creates a customer
        public int generateCustID()
        {
            Random rnd = new Random();
            int num = rnd.Next(10000);
            return num;
        }

        // method for creating a customer and writing the information into the array and customer database text file
        public bool addCustomer(string fname, string lname, string ph)
        {
            Customer[] list = loadCustomerDatabase();
            if (list != null)
            {
                for (int x = 0; x < list.Length; x++)
                {
                    if ((list[x].getFirstName() == fname) && (list[x].getLastName() == lname) && (list[x].getPhone() == ph))
                    {
                        return false;
                    }
                }
            }
            if (getNumCust() >= maxCustomer) { return false; }
            int cId = generateCustID();
            StreamWriter outputFile = new StreamWriter("customer_database.txt", true);
            Customer c = new Customer(cId, fname, lname, ph, 0);
            outputFile.WriteLine(c);
            outputFile.Close();
            return true;
        }

        // method for retrieving the position of a customer in the array using the customer ID
        public int findCustomer(int cId)
        {
            if (File.Exists("customer_database.txt"))
            {
                Customer[] list = loadCustomerDatabase();
                for (int x = 0; x < list.Length; x++)
                {
                    if (list[x].getId() == cId)
                        return x;
                }
            }
            return -1;
        }

        // method for retrieving the position of a booking in the array using the customer name
        public int findCustomer(string name)
        {
            if (File.Exists("customer_database.txt"))
            {
                Customer[] list = loadCustomerDatabase();
                for (int x = 0; x < list.Length; x++)
                {
                    if (list[x].getFullName() == name)
                        return list[x].getId();
                }
            }
            return -1;
        }

        // method for checking if the customer exists in the array
        public bool CustomerExists(int cId)
        {
            int loc = findCustomer(cId);
            if (loc == -1) { return false; }
            return true;
        }

        // method for retrieving particular customer based on customer id
        public Customer getCustomer(int cId)
        {

            customerList = loadCustomerDatabase();
            int loc = findCustomer(cId);
            if (loc == -1) { return null; }
            return customerList[loc];
        }

        // method for deleting a customer through their customer id
        public bool deleteCustomer(int cId)
        {

            List<Customer> list = loadCustomerDatabase().ToList();
            int loc = findCustomer(cId);
            if (loc == -1 || list==null) { return false; }
            list.RemoveAt(loc);
            StreamWriter outputFile = new StreamWriter("customer_database.txt");
            for (int x = 0; x < list.Count; x++)
            {
                Customer f = new Customer(list[x].getId(), list[x].getFirstName(), list[x].getLastName(), list[x].getPhone(), list[x].getNumBookings());
                outputFile.WriteLine(f);
            }
            outputFile.Close();

            return true;
        }

        // method for printing out the list of customers that is written in the customer database text file
        public string getCustomerList()
        {
            if (File.Exists("customer_database.txt"))
            {
                Customer[] list = loadCustomerDatabase();
                string s = "Customer List:";
                for (int x = 0; x < list.Length; x++)
                {
                    s += "\r\n\r\nCustomer ID: " + list[x].getId() + "\r\nName: " + list[x].getFirstName() + " " + list[x].getLastName() + "\r\nPhone Number: " + list[x].getPhone();
                }
                return s;
            }
            else
            {
                return "No Customer exists";
            }
        }

        // method for retrieving all customers from the customer database text file and returns it as an array
        public static Customer[] loadCustomerDatabase()
        {
            if (File.Exists("customer_database.txt"))
            {
                StreamReader input = new StreamReader("customer_database.txt", true);
                int lineCount = File.ReadLines("customer_database.txt").Count();
                Customer[] list = new Customer[lineCount];
                string[] CusList;
                int count = 0;
                while (input.Peek() != -1)
                {
                    CusList = input.ReadLine().Split(',');
                    list[count++] = new Customer(Convert.ToInt32(CusList[0]), CusList[1], CusList[2], CusList[3], Convert.ToInt32(CusList[4]));
                }
                input.Close();
                return list;
            }
            else
            {
                return null;
            }
        }
    }
}
