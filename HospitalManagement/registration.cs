using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalManagement
{
    public partial class registration : Form
    {
        int u_id;
        public registration()
        {
            InitializeComponent();
        }

        private void lblage_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btregister_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(aurpita.constring))
            {
                con.Open();


                string query = $"INSERT INTO [user] (username,password,role) VALUES (@uname,@pass,@role); SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
               
                   
                    cmd.Parameters.AddWithValue("@uname", txtuname.Text);
                    cmd.Parameters.AddWithValue("@pass", txtpass.Text);
                    cmd.Parameters.AddWithValue("@role", "patient");
                    



                    u_id = Convert.ToInt32(cmd.ExecuteScalar());

                }
            }
            Login lg= new Login();
            lg.Show();
            this.Hide();





            using (SqlConnection con = new SqlConnection(aurpita.constring))
            {
               
                string gen;
                if (rdbmale.Checked)
                {
                    gen = "male";
                }
                else 
                {
                    gen = "female";
                }
                
                if (txtname.Text == "" || txtage.Text == "" || txtemail.Text == "" || txtbg.Text== "" || richtextaddre.Text=="" || gen == "")
                {
                    MessageBox.Show(" fill all text box");
                }

                else {
                    con.Open();
                    
                    int age = Convert.ToInt32(txtage.Text);

                    string query = @"INSERT INTO [patient] 
(patient_id, name, email, age, gender, blood_group, address)
VALUES (@patient_id, @name, @mail, @age, @gender,@blood_group,@address)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@patient_id", u_id);
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@mail", txtemail.Text);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@gender", gen);
                    cmd.Parameters.AddWithValue("@blood_group",txtbg.Text);
                    cmd.Parameters.AddWithValue("@address", richtextaddre.Text);




                    cmd.ExecuteNonQuery();

                    MessageBox.Show("patient Added Successfully!");
                }

            }
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void rdbfemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtpid_TextChanged(object sender, EventArgs e)
        {

        }

        private void registration_Load(object sender, EventArgs e)
        {

        }
    }
}
