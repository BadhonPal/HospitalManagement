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
    public partial class assignedtask : Form
    {
        int n_id;
        int t_id;
        int p_id;
        private Panel panel;
        public void gettask( int n_id) {
            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();

                string query = @"SELECT * 
         FROM [task] 
         WHERE nurse_id = @n_id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@n_id", n_id);

               
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt=new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource=dt;


                

            }



        }



        public assignedtask(int nid, Panel p)
        {
            n_id = nid;
            InitializeComponent();
            gettask(nid);
            panel = p;
        }
        public assignedtask(  Panel parent)
        {
            InitializeComponent();
            panel= parent;
        }


        public assignedtask()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear(); 

           patientdetails  wait = new patientdetails(p_id); 
            wait.TopLevel = false;               
            wait.FormBorderStyle = FormBorderStyle.None;
            wait.Dock = DockStyle.Fill;

            panel.Controls.Add(wait);
            wait.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t_id=Convert.ToInt32(dataGridView1.Rows[e.RowIndex]
               .Cells["task_id"]
               .Value);
            p_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex]
               .Cells["patient_id"]
               .Value);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();

                
                string query = $"UPDATE [task] SET status = @status WHERE task_id = @t_id ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@t_id", t_id);
                    cmd.Parameters.AddWithValue("@status", "Accepted");
                    cmd.ExecuteNonQuery();
                }
            }
            gettask(n_id);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();

                
                string query = $"UPDATE [task] SET status = @status WHERE task_id = @t_id ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@t_id", t_id);
                    cmd.Parameters.AddWithValue("@status", "Completed");
                    cmd.ExecuteNonQuery();
                }
            }
            gettask(n_id);
        }
    }
}
