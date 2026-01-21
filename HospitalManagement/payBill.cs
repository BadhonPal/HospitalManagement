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
    public partial class payBill : Form
    {
        int b_id;
        private void billLoad()
        {


            using (SqlConnection con = new SqlConnection(badhon.constring))
            {
                con.Open();

                string query = @"
        SELECT * FROM [Bill]";

                SqlCommand cmd = new SqlCommand(query, con);


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.DataSource = dt;
            }
        }

        public payBill()
        {
            InitializeComponent();
            billLoad();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            b_id = Convert.ToInt32(
dataGridView1.Rows[e.RowIndex]
               .Cells["bill_id"]
               .Value);
        }

        private void payBill_Load(object sender, EventArgs e)
        {

        }

        private void btnpaid_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(badhon.constring))
            {
                con.Open();

                string query = $"UPDATE [Bill] SET  status = @status where bill_id = @bill_id ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@status", "paid");

                    cmd.Parameters.AddWithValue("@bill_id", b_id);

                    cmd.ExecuteNonQuery();

                }
                billLoad();
                MessageBox.Show(" paid successful");
            }

        }

        private void btnunpaid_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(badhon.constring))
            {
                con.Open();

              
                string query = $"UPDATE [Bill] SET  status = @status where bill_id = @bill_id ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@status", "Unpaid");

                    cmd.Parameters.AddWithValue("@bill_id", b_id);

                    cmd.ExecuteNonQuery();

                }
                billLoad();
                MessageBox.Show(" Unpaid");
            }
        }
    }
}
