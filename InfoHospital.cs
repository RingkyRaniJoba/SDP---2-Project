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
    public partial class InfoHospital : Form
    {
        public InfoHospital()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstPanel firstPanel = new FirstPanel();
            firstPanel.Show();
            this.Hide();
        }
    }
}
