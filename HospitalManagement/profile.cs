using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HospitalManagement
{
    public partial class profile : Form
    {

        bool isedit = false;
        int p_id;
        public void showpretientinfo(int pid)
        {
            using (SqlConnection con = new SqlConnection(aurpita.constring))
            {
                con.Open();

                string query = @"SELECT *
              FROM [patient]
              WHERE patient_id = 5";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@p_id", pid);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                   // .Text = reader["patient_id"].ToString();
                    txtname.Text = reader["name"].ToString();
                    txtage.Text = reader["age"].ToString();
                    richtextaddre.Text = reader["address"].ToString();
                    textBox3.Text=reader["email"].ToString();
                    string gender= reader["gender"].ToString();
                    string bg= reader["blood_group"].ToString();

                    if (gender == "male")
                    {
                        rdbmale.Checked = true;
                    }
                    else { 
                        rdbfemale.Checked = true;
                    }
                    txtbg.Text = bg;
                    //.Text = reader["gender"].ToString();
                    //.Text = reader["blood_group"].ToString();
                    // lbldiscount.Text = reader["discount"].ToString();
                    //rtname.Text = "Name: " + reader["name"].ToString() + "     Age: " + reader["age"].ToString();





                }

            }

        }

        public profile(int id)
        {
            InitializeComponent();
            p_id = id;
            showpretientinfo( id);
        }
        public profile()
        {
            InitializeComponent();
            showpretientinfo(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(aurpita.constring))
            {
                con.Open();
               
                int age = Convert.ToInt32(txtage.Text);
                string gen;
                if (rdbmale.Checked)
                {
                    gen = "male";
                }
                else
                {
                    gen = "female";
                }

string query = @"UPDATE [patient] 
SET name=@name,
email=@mail,
age=@age,
gender=@gender,
blood_group=@blood_group,
address=@address
WHERE patient_id=@patient_id";
                                     

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@patient_id", p_id);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@mail", textBox3.Text);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@gender", gen);
                cmd.Parameters.AddWithValue("@blood_group",txtbg.Text );
                cmd.Parameters.AddWithValue("@address", richtextaddre.Text);




                cmd.ExecuteNonQuery();

                MessageBox.Show(" Successfully updated!");


            }
        }

        private void profile_Load(object sender, EventArgs e)
        {

        }
    }
}
