using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnADDNEWPATIENT_Click(object sender, EventArgs e)
        {
            labelIndecat1.ForeColor = System.Drawing.Color.Red;
            labelIndecat2.ForeColor = System.Drawing.Color.Black;
            labelIndecat3.ForeColor = System.Drawing.Color.Black;
            labelIndecat4.ForeColor = System.Drawing.Color.Black;

            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

        }

        private void btnDIAGNOSIS_Click(object sender, EventArgs e)
        {
            labelIndecat2.ForeColor = System.Drawing.Color.Red;
            labelIndecat3.ForeColor = System.Drawing.Color.Black;
            labelIndecat4.ForeColor = System.Drawing.Color.Black;
            labelIndecat1.ForeColor = System.Drawing.Color.Black;

            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
 
        }

        private void btnFULLHISTORYPATIENT_Click(object sender, EventArgs e)
        {
            labelIndecat3.ForeColor = System.Drawing.Color.Red;
            labelIndecat4.ForeColor = System.Drawing.Color.Black;
            labelIndecat1.ForeColor = System.Drawing.Color.Black;
            labelIndecat2.ForeColor = System.Drawing.Color.Black;

            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-8BRPT5F\\SQLEXPRESS; database = hospital; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from AddPatient inner join PatientMore on AddPatient.pid = PatientMore.pid";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView2.DataSource = DS.Tables[0];

        }

        private void btnHOSPITALINFO_Click(object sender, EventArgs e)
        {
            labelIndecat4.ForeColor = System.Drawing.Color.Red;
            labelIndecat3.ForeColor = System.Drawing.Color.Black;
            labelIndecat2.ForeColor = System.Drawing.Color.Black;
            labelIndecat1.ForeColor = System.Drawing.Color.Black;

            panel4.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }
        private void btnEX_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            { 
            String name = txtName.Text;
            String address = txtAddress.Text;
            Int64 contact = Convert.ToInt64(txtContact.Text);
            int age = Convert.ToInt32(txtAge.Text);
            String gender = comboGender.Text;
            String blood = txtBlood.Text;
            String any = txtAny.Text;
            int pid = Convert.ToInt32(txtPid.Text);


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-8BRPT5F\\SQLEXPRESS; database = hospital; integrated security = True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into AddPatient values('" + name + "','" + address + "'," + contact + "," + age + ",'" + gender + "','" + blood + "','" + any + "'," + pid + ")";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid data format or invalid Pid");
            }


            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                errorProvider1.SetError(txtName, "Name is required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtName, string.Empty);
            }


            if (string.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                errorProvider2.SetError(txtAddress, "Address is required");
                return;
            }
            else
            {
                errorProvider2.SetError(txtAddress, string.Empty);
            }


            if (string.IsNullOrEmpty(txtContact.Text.Trim()))
            {
                errorProvider3.SetError(txtContact, "Contact is required");
                return;
            }
            else
            {
                errorProvider3.SetError(txtContact, string.Empty);
            }


            if (string.IsNullOrEmpty(txtAge.Text.Trim()))
            {
                errorProvider4.SetError(txtAge, "Age is required");
                return;
            }
            else
            {
                errorProvider4.SetError(txtAge, string.Empty);
            }

            if (string.IsNullOrEmpty(comboGender.Text.Trim()))
            {
                errorProvider5.SetError(comboGender, "Gender is required");
                return;
            }
            else
            {
                errorProvider5.SetError(comboGender, string.Empty);
            }

            if (string.IsNullOrEmpty(txtBlood.Text.Trim()))
            {
                errorProvider6.SetError(txtBlood, "Blood Group is required");
                return;
            }
            else
            {
                errorProvider6.SetError(txtBlood, string.Empty);
            }
            if (string.IsNullOrEmpty(txtAny.Text.Trim()))
            {
                errorProvider7.SetError(txtAny, "Is there any major disease");
                return;
            }
            else
            {
                errorProvider7.SetError(txtAny, string.Empty);
            }

            if (string.IsNullOrEmpty(txtPid.Text.Trim()))
            {
                errorProvider8.SetError(txtPid, "Pid is required");
                return;
            }
            else
            {
                errorProvider8.SetError(txtPid, string.Empty);
            }

            MessageBox.Show("Data Saved");

            txtName.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtAge.Clear();
            txtBlood.Clear();
            txtAny.Clear();
            txtPid.Clear();
            comboGender.ResetText();

       }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int pid = Convert.ToInt32(textBox1.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-8BRPT5F\\SQLEXPRESS; database = hospital; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from AddPatient where pid = " + pid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(textBox1.Text);
                String sympt = txtBxSymp.Text;
                String diag = txtBxDiag.Text;
                String medicine = txtBxMedi.Text;
                String ward = comboBxWard.Text;
                String wardType = comboBxWardType.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-8BRPT5F\\SQLEXPRESS; database = hospital; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into PatientMore values(" + pid + ",'" + sympt + "','" + diag + "','" + medicine + "','" + ward + "','" + wardType + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

            }
            catch(Exception)
            {
                MessageBox.Show("Any Field is empty 'OR' Data is in WRONG FORMAT.");
            }

            if (string.IsNullOrEmpty(txtBxSymp.Text.Trim()))
            {
                errorProvider9.SetError(txtBxSymp, "What are the syptoms");
                return;
            }
            else
            {
                errorProvider9.SetError(txtBxSymp, string.Empty);
            }


            if (string.IsNullOrEmpty(txtBxDiag.Text.Trim()))
            {
                errorProvider10.SetError(txtBxDiag, "Add Diagnosis");
                return;
            }
            else
            {
              errorProvider10.SetError(txtBxDiag, string.Empty);
            }

            if (string.IsNullOrEmpty(txtBxMedi.Text.Trim()))
            {
                errorProvider11.SetError(txtBxMedi, "Medicines");
                return;
            }
            else
            {
                errorProvider11.SetError(txtBxMedi, string.Empty);
            }

            if (string.IsNullOrEmpty(comboBxWard.Text.Trim()))
            {
                errorProvider12.SetError(comboBxWard, "Do you need ward");
                return;
            }
            else
            {
                errorProvider12.SetError(comboBxWard, string.Empty);
            }

            if (string.IsNullOrEmpty(comboBxWardType.Text.Trim()))
            {
                errorProvider13.SetError(comboBxWardType, "Ward Type");
                return;
            }
            else
            {
                errorProvider13.SetError(comboBxWardType, string.Empty);
            }



            MessageBox.Show("Data Saved");

            textBox1.Clear();
            txtBxSymp.Clear();
            txtBxDiag.Clear();
            txtBxMedi.Clear();
            comboBxWard.ResetText();
            comboBxWardType.ResetText();

        }

        private void btnEX_Click_1(object sender, EventArgs e)
        {
            FirstPanel firstPanel = new FirstPanel();
            firstPanel.Show();
            this.Hide();
        }
       

        private void txtBox12_TextChanged(object sender, EventArgs e)
        {

            if (txtBox12.Text != "")
            {
                int pid = Convert.ToInt32(txtBox12.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-8BRPT5F\\SQLEXPRESS; database = hospital; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from AddPatient inner join PatientMore on AddPatient.pid = PatientMore.pid and AddPatient.pid = " + pid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView3.DataSource = DS.Tables[0];

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(textBox1.Text);
                String sympt = txtBxSymp.Text;
                String diag = txtBxDiag.Text;
                String medicine = txtBxMedi.Text;
                String ward = comboBxWard.Text;
                String wardType = comboBxWardType.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-8BRPT5F\\SQLEXPRESS; database = hospital; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update PatientMore set Symptoms ='"+ sympt +"', Diagnosis = '"+ diag +"', Medicines ='"+ medicine +"', Ward ='"+ ward +"', Ward_Type='"+ wardType+"' where pid="+ pid +"";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

            }
            catch (Exception)
            {
                MessageBox.Show("Any Field is empty 'OR' Data is in WRONG FORMAT.");
            }
            MessageBox.Show("Data Updated");

            textBox1.Clear();
            txtBxSymp.Clear();
            txtBxDiag.Clear();
            txtBxMedi.Clear();
            comboBxWard.ResetText();
            comboBxWardType.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtName.Text;
                String address = txtAddress.Text;
                Int64 contact = Convert.ToInt64(txtContact.Text);
                int age = Convert.ToInt32(txtAge.Text);
                String gender = comboGender.Text;
                String blood = txtBlood.Text;
                String any = txtAny.Text;
                int pid = Convert.ToInt32(txtPid.Text);


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-8BRPT5F\\SQLEXPRESS; database = hospital; integrated security = True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update AddPatient set Name ='"+ name +"' ,Full_Address = '"+ address +"', Contact ="+ contact +", Age="+ age +", Gender='"+ gender +"',Blood_Group='"+ blood +"',Major_Disease='"+ any +"' where pid="+ pid +"";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data format or invalid Pid");
            }

            MessageBox.Show("Data Updated");

            txtName.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtAge.Clear();
            txtBlood.Clear();
            txtAny.Clear();
            txtPid.Clear();
            comboGender.ResetText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(txtPid.Text);


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-8BRPT5F\\SQLEXPRESS; database = hospital; integrated security = True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from AddPatient where pid = " + pid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data format or invalid Pid");
            }

            MessageBox.Show("Data Deleted");

            txtName.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtAge.Clear();
            txtBlood.Clear();
            txtAny.Clear();
            txtPid.Clear();
            comboGender.ResetText();
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex(@"^[0-9]{11}$");
            if (r.IsMatch(txtContact.Text))
            {
                txtContact.BackColor = System.Drawing.Color.White;
                //string[] row1 = new string[] { txtContact.Text }; 
            }
            else
            {
                txtContact.BackColor = System.Drawing.Color.Pink;
                //MessageBox.Show("Contact is invalid");
            }
        }

        
    }
    }

