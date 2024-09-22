using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Hospital_Management_System
{
    public partial class FirstPanel : Form
    {
        public FirstPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Form1 form = new Form1();
            form.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserPanel form1 = new UserPanel();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InfoHospital form1 = new InfoHospital();
            form1.Show();
            this.Hide();
        }
    }
}
