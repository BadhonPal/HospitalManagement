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

namespace HospitalManagement
{
    public partial class prescribetion : Form
    {
        void  priscription(int pid) {
            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();

                string query = @"SELECT prescribe_id,date 
                     FROM [prescription] 
                     WHERE patient_id = @p_id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@p_id", pid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.Visible = true;
                
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.DataSource = dt;


            }
        }
        public prescribetion(int p)
        {
            InitializeComponent();
            priscription(p);
        }
        public prescribetion()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void prescribetion_Load(object sender, EventArgs e)
        {

        }
    }
}
