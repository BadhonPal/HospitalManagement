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
    public partial class appointment : Form
    {
        int did;
       
        private void LoadPatientsByDoctorFromAppointment()

        {

            string constring = "server=DESKTOP-IBGVO76\\SQLEXPRESS;Database=HMS;Trusted_connection=True;TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(constring))

            {

                con.Open();

                string query = @"

SELECT * FROM [doctor]";

                SqlCommand cmd = new SqlCommand(query, con);


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }

        }
        int p_id;
        public appointment(int pid)
        {
            InitializeComponent();
            LoadPatientsByDoctorFromAppointment();
            p_id = pid;
        }

        public appointment()
        {
            InitializeComponent();
            LoadPatientsByDoctorFromAppointment();
        }

        private void lblconfirm_Click(object sender, EventArgs e)
        {

        }

        private void appointment_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            did = Convert.ToInt32(
dataGridView1.Rows[e.RowIndex]
                .Cells["doctor_id"]
                .Value);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || did == 0) { MessageBox.Show("Enter  disease  name and Select Doctor!"); }
            else
            {

                using (SqlConnection con = new SqlConnection(aurpita.constring))
                {
                    con.Open();



                    string query = @"INSERT INTO [book] 
(patient_id,doctor_id,status,disease,date)
VALUES (@patient_id,@doctor_id,@status,@disease,@date)";

                    string date = DateTime.Now.ToString("yyyy-MM-dd");

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@patient_id", p_id);
                    cmd.Parameters.AddWithValue("@doctor_id", did);
                    cmd.Parameters.AddWithValue("@status", "pending");
                    cmd.Parameters.AddWithValue("@disease", textBox1.Text);
                    cmd.Parameters.AddWithValue("@date", date);




                    cmd.ExecuteNonQuery();

                   // MessageBox.Show("appointment confirmed");


                }
                using (SqlConnection con = new SqlConnection(aurpita.constring))
                {
                    con.Open();



                    string query = @"INSERT INTO [bill] 
(patient_id,doctor_id,status,amount)
VALUES (@patient_id,@doctor_id,@status,@amo)";

                   

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@patient_id", p_id);
                    cmd.Parameters.AddWithValue("@doctor_id", did);
                    cmd.Parameters.AddWithValue("@status", "pending");
                    cmd.Parameters.AddWithValue("@amo", 300);





                    cmd.ExecuteNonQuery();

                   


                }
                MessageBox.Show("Appointment Confirmed");
            }









        }

        }
    }

