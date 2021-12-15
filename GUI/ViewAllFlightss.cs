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
    public partial class ViewAllFlightss : Form
    {
        public ViewAllFlightss(string value)
        {
            InitializeComponent();
            textBox1.Text = value;
        }

        private void fMenu_Click(object sender, EventArgs e)
        {
            FlightMenu obj = new FlightMenu();
            obj.Location = this.Location;
            obj.StartPosition = FormStartPosition.Manual;
            obj.Show();

            this.Hide();
        }

        private void ViewAllFlightss_Load(object sender, EventArgs e)
        {

        }

        private void mMenu_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Location = this.Location;
            obj.StartPosition = FormStartPosition.Manual;
            obj.Show();

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
