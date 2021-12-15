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
    public partial class AddBookings : Form
    {

        public AddBookings(string c,string f)
        {
            InitializeComponent();
            // initializes value of textbox
            textBox1.Text = c;
            textBox2.Text = f;
        }

        private void l1_Click(object sender, EventArgs e)
        {

        }

        // Submit button
        private void bSubmit_Click(object sender, EventArgs e)
        {
            int choice;

            // input validation to check if user enters a number
            bool isNum = int.TryParse(cId.Text, out choice);
            int choice2;
            bool isNum2 = int.TryParse(fNum.Text, out choice2);

            // checks user input if null or empty
            if (!string.IsNullOrWhiteSpace(cId.Text)
                   && !string.IsNullOrWhiteSpace(fNum.Text)
                   && isNum 
                   && isNum2
                   )
            {

                int custID = choice;
                int flightNum = choice2;

                // initializes value of textbox to null
                cId.Text = "";
                fNum.Text = "";

                // checks if booking is added succesfully 
                if (Program.addBooking(custID,flightNum))
                {
                    label5.Text = "Booking Added Successfully";
                }
                else
                {
                    label5.Text = "Booking Not added";
                }

            }
            // error message when user inputs nothing
            else
            {
                MessageBox mb = new MessageBox();
                mb.Show();

            }
        }

        // switches the form to booking menu
        private void bMenu_Click(object sender, EventArgs e)
        {
            BookingMenu af = new BookingMenu();
            af.Location = this.Location;
            af.StartPosition = FormStartPosition.Manual;
            af.Show();
            this.Hide();
        }

        // switches the form to main menu
        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu af = new MainMenu();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void l2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
