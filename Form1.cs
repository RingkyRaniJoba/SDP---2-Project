using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lmh(object sender, EventArgs e)
        {
            String username = txtUserName.Text;
            String pass = txtPassword.Text;

            if (username == "hms" && pass == "pass")
            {
                //MessageBox.Show("you have entered right username and password");
                this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show();
            
            }
            else
            {
                MessageBox.Show("wrong user id or password");
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
