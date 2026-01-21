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
using System.Windows.Forms.DataVisualization.Charting;

namespace HospitalManagement
{
    public partial class dashboard : Form
    {

        int d_id;

        private void LoadPatientChart()
        {
            string conString = "server=localhost;Database=HMS;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string query = @"SELECT date, COUNT(patient_id) AS totalPatient
                         FROM book
                         WHERE doctor_id = @did
                         GROUP BY date
                         ORDER BY date";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@did", d_id);
                SqlDataReader dr = cmd.ExecuteReader();
               

                // Clear previous data
                chart1.Series.Clear();

                Series series = new Series("Total Patients");
                series.ChartType = SeriesChartType.Column; // Bar graph
                                                           // Use Line if you want: SeriesChartType.Line

                while (dr.Read())
                {
                    series.Points.AddXY(
                        Convert.ToDateTime(dr["date"]).ToShortDateString(),
                        Convert.ToInt32(dr["totalPatient"])
                    );
                }

                chart1.Series.Add(series);
            }
        }



        void getincome() {
            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();


                string query = @"SELECT SUM(amount) FROM bill WHERE doctor_id = @did";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    
                    cmd.Parameters.AddWithValue("@did", d_id);
                    


                    // cmd.ExecuteNonQuery();
                    lblti.Text = cmd.ExecuteScalar().ToString();

                }
            }
        }
        void waiting()
        {
            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();


                string query = @"SELECT COUNT(*) FROM book WHERE doctor_id = @did";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@did", d_id);



                   
                    lblwn.Text = cmd.ExecuteScalar().ToString();

                }
            }
        }
        void totaltreatment()
        {
            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();


                string query = @"SELECT COUNT(*) FROM checkup WHERE doctor_id = @did";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@did", d_id);




                    lbltt.Text = cmd.ExecuteScalar().ToString();

                }
            }
        }

        public dashboard()
        {
            InitializeComponent();
        }
        public dashboard(int did)
        {
            d_id = did;
            InitializeComponent();
            getincome();
            waiting();
            totaltreatment();
            LoadPatientChart();










        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void lblti_Click(object sender, EventArgs e)
        {

        }
    }
}
