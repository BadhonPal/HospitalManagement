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

namespace HospitalManagement
{
    public partial class registration : Form
    {
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
                int pid = Convert.ToInt32(txtpid.Text);
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

                string query = @"INSERT INTO [patient] 
(patient_id, name, email, age, gender, blood_group, address)
VALUES (@patient_id, @name, @mail, @age, @gender,@blood_group,@address)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@patient_id", pid);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@mail", txtemail.Text);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@gender", gen);
                cmd.Parameters.AddWithValue("@blood_group", "O+");
                cmd.Parameters.AddWithValue("@address",richtextaddre.Text);
              



                cmd.ExecuteNonQuery();

                MessageBox.Show("patient Added Successfully!");


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
    }
}
