using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Management_System
{
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        private void txtBx22_TextChanged(object sender, EventArgs e)
        {
            if (txtBx22.Text != "")
            {
                int pid = Convert.ToInt32(txtBx22.Text);

                // Creating instance of SqlConnection 
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-8BRPT5F\\SQLEXPRESS; database = hospital; integrated security = True";
                SqlCommand cmd = new SqlCommand(); // Creating instance of SqlCommand 
                cmd.Connection = con; // set the connection to instance of SqlCommand


                //set the sql command ( Statement ) 
                cmd.CommandText = "select * from AddPatient inner join PatientMore on AddPatient.pid = PatientMore.pid and AddPatient.pid = " + pid + "";
                //cmd.CommandText = "select * from AddPatient inner join PatientMore on AddPatient.pid = PatientMore.pid and AddPatient.pid = " + pid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView11.DataSource = DS.Tables[0];


            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FirstPanel firstPanel = new FirstPanel();
            firstPanel.Show();
            this.Hide();
        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
