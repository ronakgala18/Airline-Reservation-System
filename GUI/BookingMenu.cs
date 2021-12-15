using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class BookingMenu : Form
    {
        public BookingMenu()
        {
            InitializeComponent();
        }

        // Switches to the form where user can add a booking
        private void addBooking_Click(object sender, EventArgs e)
        {
            AddBookings af = new AddBookings(Program.viewCustomer(),Program.viewFlights());
            af.Location = this.Location;
            af.StartPosition = FormStartPosition.Manual;
            af.Show();
            this.Hide();
        }

        // Switches to the form where user accesses the main menu
        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu af = new MainMenu();
            af.Location = this.Location;
            af.StartPosition = FormStartPosition.Manual;
            af.Show();
            this.Hide();
        }

        // Switches to the form where user can view bookings
        private void viewBooking_Click(object sender, EventArgs e)
        {
            ViewBookings af = new ViewBookings(Program.viewBooking());
            af.Location = this.Location;
            af.StartPosition = FormStartPosition.Manual;
            af.Show();
            this.Hide();
        }

        // Switches to the form where user can delete a booking
        private void deleteBooking_Click(object sender, EventArgs e)
        {
            DeleteBookings af = new DeleteBookings(Program.viewBooking());
            af.Location = this.Location;
            af.StartPosition = FormStartPosition.Manual;
            af.Show();
            this.Hide();
        }

        // button that exits the whole program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
