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
    public partial class viewappoint : Form
    {
        int b_id;
        public viewappoint()
        {
            InitializeComponent();
        }
        int p_id;
       
        private void loadappointment()

        {

            string constring = "server=DESKTOP-IBGVO76\\SQLEXPRESS;Database=HMS;Trusted_connection=True;TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(constring))

            {

                con.Open();

                string query = @"

SELECT * FROM [book] WHERE patient_id = @p_id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@p_id", p_id);



                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }

        }
        public viewappoint(int pid)
        {
            InitializeComponent();
            p_id = pid;
            loadappointment();
        }

        private void viewappoint_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            b_id = Convert.ToInt32(
dataGridView1.Rows[e.RowIndex]
                .Cells["doctor_id"]
                .Value);
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(aurpita.constring))
            {
                con.Open();
                

                string query = @"DELETE FROM [book] WHERE book_id = @b_id";

                SqlCommand cmd = new SqlCommand(query, con);
                
                cmd.Parameters.AddWithValue("@b_id",b_id);
                




                cmd.ExecuteNonQuery();

                MessageBox.Show("delete Successfully!");
                loadappointment();


            }
        }
    }
}
