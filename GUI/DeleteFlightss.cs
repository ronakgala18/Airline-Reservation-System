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
    public partial class DeleteFlightss : Form
    {
        public DeleteFlightss(string s)
        {
            InitializeComponent();
            textBox1.Text = s;
        }

        private void DeleteFlightss_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                int fId = getValidInput(textBox2.Text);
                textBox2.Text = "";
                if (Program.deleteFlight(fId))
                {
                    label4.Text = "Flight deleted successfully.";
                }
                else
                {
                    label4.Text = "Flight deletion failed.";
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

        private void mMenu_Click(object sender, EventArgs e)
        {
            MainMenu af = new MainMenu();
            af.Location = this.Location;
            af.StartPosition = FormStartPosition.Manual;
            af.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
