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

           

            using (SqlConnection con = new SqlConnection(aurpita.constring))

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
        Panel parent;
        public viewappoint(int pid,Panel p)
        {
            InitializeComponent();
            p_id = pid;
            parent = p;
            loadappointment();
        }

        private void viewappoint_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.Controls.Clear(); 

            appointment a = new appointment(p_id); 
            a.TopLevel = false;               
            a.FormBorderStyle = FormBorderStyle.None;
            a.Dock = DockStyle.Fill;

            parent.Controls.Add(a);
            a.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            b_id = Convert.ToInt32(
dataGridView1.Rows[e.RowIndex]
                .Cells["book_id"]
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

                MessageBox.Show("Delete Successfully!");
                loadappointment();


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
