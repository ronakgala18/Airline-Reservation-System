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
    public partial class AddFlight : Form
    {
        public AddFlight()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fMenu_Click(object sender, EventArgs e)
        {
            FlightMenu obj = new FlightMenu();
            obj.Location = this.Location;
            obj.StartPosition = FormStartPosition.Manual;
            obj.Show();
            this.Hide();
        }

        private void fSubmit_Click(object sender, EventArgs e)
        {
            int choice;
            bool isNum = int.TryParse(fNumText.Text, out choice);
            int choice2;
            bool isNum2 = int.TryParse(fNumSeatText.Text, out choice2);
            if (!string.IsNullOrWhiteSpace(fNumText.Text) 
                && !string.IsNullOrWhiteSpace(fNumSeatText.Text)
                && !string.IsNullOrWhiteSpace(fOriginText.Text)
                && !string.IsNullOrWhiteSpace(fDestination.Text) &&isNum && isNum2)
            {
                int fNum = choice;
                int max = choice2;
                string origin = fOriginText.Text;
                string destination = fDestination.Text;
                fNumText.Text = "";
                fNumSeatText.Text = "";
                fOriginText.Text = "";
                fDestination.Text = "";
                if (Program.addFlight(fNum, max, origin, destination))
                {
                    label5.Text = "Flight Added Successfully";
                }
                else
                {
                    label5.Text = "Flight Not added";
                }
                    
            }
            else
            {
                MessageBox mb = new MessageBox();
                mb.Show();

            }
        }

        private void AddFlight_Load(object sender, EventArgs e)
        {

        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu af = new MainMenu();
            af.Location = this.Location;
            af.StartPosition = FormStartPosition.Manual;
            af.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fNumSeatText_TextChanged(object sender, EventArgs e)
        {

        }

        private void fNumSeatsLabel_Click(object sender, EventArgs e)
        {

        }

        private void fNumLabel_Click(object sender, EventArgs e)
        {

        }

        private void fNumText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
