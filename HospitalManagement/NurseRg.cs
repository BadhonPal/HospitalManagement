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
    public partial class NurseRg : Form
    {
        public NurseRg()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
            using (SqlConnection con = new SqlConnection(badhon.constring))
            {
                string gen;
                if (rbmale.Checked)
                {
                    gen = "male";
                }
                else if(rbfemale.Checked)
                {
                    gen = "female";
                }

                else
                {
                    gen = "";
                }
                if (txtname.Text == "" || txtage.Text == "" || txtemail.Text == "" || gen == "" || rcbaddress.Text == "")
                {
                    MessageBox.Show(" show all the text box");
                }

                else
                {
                    con.Open();
                    int nid = Convert.ToInt32(txtid.Text);
                    int age = Convert.ToInt32(txtage.Text);


                    string query = @"INSERT INTO [nurse] 
(nurse_id, name, email, age, gender, address)
VALUES (@nurse_id, @name, @mail, @age, @gender, @address )";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@nurse_id", nid);
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@mail", txtemail.Text);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@gender", gen);

                    cmd.Parameters.AddWithValue("@address", rcbaddress.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("nurse Added Successfully!");

                }
            }
        }

        private void NurseRg_Load(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
           
            txtid.Text="";
            txtname.Text="";
            txtemail.Text = "";
            txtage.Text = "";
            txtpassword.Text = "";        
            rbmale.Checked = false;
            rbfemale.Checked = false;        
            rcbaddress.Text = "";  

       }

        private void rcbaddresss_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

