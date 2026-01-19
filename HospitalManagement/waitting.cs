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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HospitalManagement
{
    public partial class waitting : Form
    {
        int patientId;
        String disease_pat;
        string constring = "server=localhost;Database=HMS;Trusted_connection=True;TrustServerCertificate=True;";

        
        private void LoadPatientsByDoctorFromAppointment(int doctorId)
        {
            string constring = "server=localhost;Database=HMS;Trusted_connection=True;TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();

                string query = @"
        SELECT DISTINCT
               p.patient_id,
               p.name,
               p.age
        FROM Book a
        JOIN Patient p ON a.patient_id = p.patient_id
        WHERE a.doctor_id = @doctorId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@doctorId", 1);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
        int did;
        Panel parentPanel;
        public waitting(int doctorid,Panel P)
        {
            InitializeComponent();
            LoadPatientsByDoctorFromAppointment(1);
            parentPanel = P;
        }


        public waitting()
        {
            InitializeComponent();
            LoadPatientsByDoctorFromAppointment(1); 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void waitting_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pid = Convert.ToInt32(
        dataGridView1.Rows[e.RowIndex]
                        .Cells["patient_id"]
                        .Value
    );
            patientId = pid;
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();

                string query = @"SELECT disease 
                     FROM [book] 
                     WHERE patient_id = @pid";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@pid", pid);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string disease = reader["disease"].ToString();
                   rtbdisease.Text = disease;
                    disease_pat = disease;
                }
            }


            }

        private void btntreatment_Click(object sender, EventArgs e)
        {
            parentPanel.Controls.Clear(); // remove previous page

            Treatment treat = new Treatment(patientId,did,disease_pat); // child form
            treat.TopLevel = false;               // IMPORTANT
            treat.FormBorderStyle = FormBorderStyle.None;
            treat.Dock = DockStyle.Fill;

            parentPanel.Controls.Add(treat);
            treat.Show();
        }
    }
}
