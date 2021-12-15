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
    public partial class CustomerMenu : Form
    {
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                MainMenu mm = new MainMenu();
                mm.Location = this.Location;
                mm.StartPosition = FormStartPosition.Manual;
                mm.Show();
                this.Hide();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            AddCust af = new AddCust();
            af.Location = this.Location;
            af.StartPosition = FormStartPosition.Manual;
            af.Show();
            this.Hide();
        }

        private void viewCustomer_Click(object sender, EventArgs e)
        {

            ViewCust vf = new ViewCust(Program.viewCustomer());
            vf.Location = this.Location;
            vf.StartPosition = FormStartPosition.Manual;
            vf.Show();
            this.Hide();


        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {

            DeleteCust df = new DeleteCust(Program.viewCustomer());
            df.Location = this.Location;
            df.StartPosition = FormStartPosition.Manual;
            df.Show();
            this.Hide();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
