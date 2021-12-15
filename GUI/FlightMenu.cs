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
    public partial class FlightMenu : Form
    {
        public FlightMenu()
        {
            InitializeComponent();
        }

        private void fMenu_Click(object sender, EventArgs e)
        {

        }

        private void addFlight_Click(object sender, EventArgs e)
        {
            AddFlight af = new AddFlight();
            af.Location = this.Location;
            af.StartPosition = FormStartPosition.Manual;
            af.Show();
            this.Hide();
        }

        private void viewAllFlight_Click(object sender, EventArgs e)
        {
            ViewAllFlightss vf = new ViewAllFlightss(Program.viewFlights());
            vf.Location = this.Location;
            vf.StartPosition = FormStartPosition.Manual;
            vf.Show();
            this.Hide();

        }

        private void FlightMenu_Load(object sender, EventArgs e)
        {
        }

        private void deleteFlight_Click(object sender, EventArgs e)
        {
            DeleteFlightss df = new DeleteFlightss(Program.viewFlights());
            df.Location = this.Location;
            df.StartPosition = FormStartPosition.Manual;
            df.Show();
            this.Hide();
        }

        private void viewParticularflight_Click(object sender, EventArgs e)
        {
            ParticularFlight df = new ParticularFlight(Program.viewFlights());
            df.Location = this.Location;
            df.StartPosition = FormStartPosition.Manual;
            df.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Location = this.Location;
            mm.StartPosition = FormStartPosition.Manual;
            mm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
