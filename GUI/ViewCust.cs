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
    public partial class ViewCust : Form
    {
        public ViewCust(string s)
        {
            InitializeComponent();
            textBox1.Text = s;
        }

        private void ViewCust_Load(object sender, EventArgs e)
        {

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
    }
}
