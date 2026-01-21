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
    public partial class bedlist : Form
    {
        int w_id;

        public void getbed()
        {
            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();

                string query = @"
        SELECT * FROM [ward]";

                SqlCommand cmd = new SqlCommand(query, con);


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.DataSource = dt;
            }



        }

        public bedlist()
        {
            InitializeComponent();
            getbed();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            w_id = Convert.ToInt32(
dataGridView1.Rows[e.RowIndex]
               .Cells["ward_id"]
               .Value);
        }
    }
}
