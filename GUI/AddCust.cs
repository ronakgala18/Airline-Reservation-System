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
    public partial class AddCust : Form
    {
        public AddCust()
        {
            InitializeComponent();
        }

        private void cMenu_Click(object sender, EventArgs e)
        {
            CustomerMenu obj = new CustomerMenu();
            obj.Location = this.Location;
            obj.StartPosition = FormStartPosition.Manual;
            obj.Show();
            this.Hide();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Location = this.Location;
            mm.StartPosition = FormStartPosition.Manual;
            mm.Show();
            this.Hide();
        }

        private void cSubmit_Click(object sender, EventArgs e)
        {

                if (!string.IsNullOrWhiteSpace(fName.Text)
                    && !string.IsNullOrWhiteSpace(lName.Text)
                    && !string.IsNullOrWhiteSpace(fNumber.Text)
                    )
                {

                    string first = fName.Text;
                    string last = lName.Text;
                    string phone = fNumber.Text;
                    fName.Text = "";
                    lName.Text = "";
                    fNumber.Text = "";
                    if (Program.addCustomer(first,last,phone))
                    {
                        label5.Text = "Customer Added Successfully";
                    }
                    else
                    {
                        label5.Text = "Customer Not added";
                    }

                }
                else
                {
                    MessageBox mb = new MessageBox();
                    mb.Show();

                }

        }

        private void AddCust_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
