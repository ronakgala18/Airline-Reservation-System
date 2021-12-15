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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void fMenu_Click(object sender, EventArgs e)
        {
            FlightMenu obj = new FlightMenu();
            obj.Location = this.Location;
            obj.StartPosition = FormStartPosition.Manual;
            obj.Show();

            this.Hide();
        }

        private void cMenu_Click(object sender, EventArgs e)
        {
            CustomerMenu obj = new CustomerMenu();
            obj.Location = this.Location;
            obj.StartPosition = FormStartPosition.Manual;
            obj.Show();

            this.Hide();
        }

        private void bMenu_Click(object sender, EventArgs e)
        {
            BookingMenu obj = new BookingMenu();
            obj.Location = this.Location;
            obj.StartPosition = FormStartPosition.Manual;
            obj.Show();

            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
