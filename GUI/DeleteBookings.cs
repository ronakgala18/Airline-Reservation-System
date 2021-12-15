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
    public partial class DeleteBookings : Form
    {
        public DeleteBookings(string value)
        {
            InitializeComponent();
            textBox1.Text = value;
        }

        private void bMenu_Click(object sender, EventArgs e)
        {
            BookingMenu af = new BookingMenu();
            af.Location = this.Location;
            af.StartPosition = FormStartPosition.Manual;
            af.Show();
            this.Hide();
        }

        private void mMenu_Click(object sender, EventArgs e)
        {
            MainMenu af = new MainMenu();
            af.Location = this.Location;
            af.StartPosition = FormStartPosition.Manual;
            af.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                int fId = getValidInput(textBox2.Text);
                textBox2.Text = "";
                if (Program.deleteBooking(fId))
                {
                    label4.Text = "Booking deleted successfully.";
                }
                else
                {
                    label4.Text = "Booking deletion failed.";
                }
            }
        }
        public static int getValidInput(string x)
        {
            int choice;
            if (!int.TryParse(x, out choice))
            {
                MessageBox mb = new MessageBox();
                mb.Show();
            }
            return choice;
        }

        private void DeleteBookings_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
