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
using System.Xml.Linq;

namespace HospitalManagement
{
    public partial class DoctorRg : Form
    {
        int u_id;
        string qua;
        public DoctorRg()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DoctorRg_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();


                string query = $"INSERT INTO [user] (username,password,role) VALUES (@uname,@pass,@role); SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@uname", txtusername.Text);
                    cmd.Parameters.AddWithValue("@pass", txtpassword.Text);
                    cmd.Parameters.AddWithValue("@role", "doctor");



                    u_id = Convert.ToInt32(cmd.ExecuteScalar());

                }
            }



            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                string gen;
                if (rbmale.Checked)
                {
                    gen = "male";
                }
                else if (rbmale.Checked)
                {
                    gen = "female";
                }
                else { gen = ""; }

                if (txtname.Text == "" || txtage.Text == "" || txtemail.Text == "" || gen == "" || qua == "" || txtspecialist.Text == "")
                {
                    MessageBox.Show(" show all the text box");
                }
                else
                {

                    con.Open();
                    
                    int age = Convert.ToInt32(txtage.Text);

                    if (cbmbbs.Checked)
                        qua += "MBBS,";

                    if (cbfcps.Checked)
                        qua += "FCPS,";

                    if (cbfcpr.Checked)
                        qua += "FCPR,";

                    if (cbphd.Checked)
                        qua += "PhD,";


                    string query = @"INSERT INTO [Doctor] 
(doctor_id, name, email, age, gender, qualification, availability, specialist)
VALUES (@doctor_id, @name, @mail, @age, @gender, @qual, @avail, @spec)";



                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@doctor_id", u_id);
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@mail", txtemail.Text);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@gender", gen);
                    cmd.Parameters.AddWithValue("@qual", qua);
                    cmd.Parameters.AddWithValue("@avail", "available");
                    cmd.Parameters.AddWithValue("@spec", txtspecialist.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Doctor Added Successfully!");

                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtname.Text = "";
            txtemail.Text = "";
            txtage.Text = "";
            txtpassword.Text = "";
            rbmale.Checked = false;
            rbfemale.Checked = false;
            cbfcps.Checked = false;
            cbfcpr.Checked = false;
            cbmbbs.Checked = false;
            cbphd.Checked = false;
            txtspecialist.Text = "";

        }
    }
}
