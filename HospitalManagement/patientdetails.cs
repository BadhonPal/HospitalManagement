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
    public partial class patientdetails : Form
    {
        public void getpatient(int p_id) {
            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();

                string query = @"SELECT * 
             FROM [patient] 
             WHERE patient_id = @p_id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@p_id", p_id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    
                    lbname.Text = reader["name"].ToString();
                    lblage.Text = reader["age"].ToString();
                    lblgender.Text = reader["gender"].ToString();
                    lblbg.Text = reader["blood_group"].ToString();
                   





                }

            }


        }
        public patientdetails()
        {
            InitializeComponent();

        }
        int p_id;
        public patientdetails(int pid)
        {
            InitializeComponent();
            p_id = pid;
            getpatient(pid);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
