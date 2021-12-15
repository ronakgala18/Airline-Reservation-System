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
    public partial class DeleteCust : Form
    {
        public DeleteCust(string s )
        {
            InitializeComponent();
            textBox1.Text = s;
        }

        private void DeleteCust_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                int cId = getValidInput(textBox2.Text);
                textBox2.Text = "";
                if (Program.deleteCustomer(cId))
                {
                    label4.Text = "Customer deletion completed.";
                }
                else
                {
                    label4.Text = "Customer deletion failed. ";
                    label4.Text += "Might have a booked flight.";
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

        private void cMenu_Click(object sender, EventArgs e)
        {
            CustomerMenu obj = new CustomerMenu();
            obj.Location = this.Location;
            obj.StartPosition = FormStartPosition.Manual;
            obj.Show();
            this.Hide();
        }

        private void mMenu_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Location = this.Location;
            mm.StartPosition = FormStartPosition.Manual;
            mm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
