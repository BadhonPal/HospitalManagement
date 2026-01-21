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
    public partial class viewDocotor : Form
    {
        private Panel panel;
        int d_id;
        private void docotorLoad()
        {
            
            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();

                string query = @"
        SELECT * FROM [doctor]";

                SqlCommand cmd = new SqlCommand(query, con);
      

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.DataSource = dt;
            }
        }
        public viewDocotor(Panel parent) {
            InitializeComponent();
            docotorLoad();
            panel = parent;
        }
        public viewDocotor()
        {
            InitializeComponent();
            docotorLoad();
        }

        private void btnubdate_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();

                // Build query safely
                string query = $"UPDATE [doctor] SET name=@name, email=@email, age=@age, specialist=@specialist WHERE doctor_id = @d_id ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@d_id", d_id);
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtage.Text));
                    cmd.Parameters.AddWithValue("@specialist", txtspecialist.Text);
                    cmd.ExecuteNonQuery();

                }
                docotorLoad();
                MessageBox.Show(" update successful");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d_id = Convert.ToInt32(
dataGridView2.Rows[e.RowIndex]
                .Cells["doctor_id"]
                .Value);
            txtname.Text= dataGridView2.Rows[e.RowIndex]
                .Cells["name"]
                .Value.ToString();
            txtemail.Text = dataGridView2.Rows[e.RowIndex]
                .Cells["email"]
                .Value.ToString();
            txtage.Text = dataGridView2.Rows[e.RowIndex]
               .Cells["age"]
               .Value.ToString();
            txtspecialist.Text = dataGridView2.Rows[e.RowIndex]
                .Cells["specialist"]
                .Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Global.delete("doctor","doctor_id",d_id);
            MessageBox.Show("successfully delete");
            docotorLoad();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear(); 

            DoctorRg await = new DoctorRg(); 
            await.TopLevel = false;               
            await.FormBorderStyle = FormBorderStyle.None;
            await.Dock = DockStyle.Fill;

            panel.Controls.Add(await);
            await.Show();
        }

        private void txtspecialist_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
