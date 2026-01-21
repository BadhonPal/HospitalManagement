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
    public partial class viewNurse : Form
    {
        private Panel panel1;
        int n_id;
        private void LoadPatientsByDoctorFromAppointment()
        {
            
            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();

                string query = @"
        SELECT * FROM [nurse]";

                SqlCommand cmd = new SqlCommand(query, con);


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.DataSource = dt;
            }
        }
        public viewNurse(Panel parent)
        {
            InitializeComponent();
            LoadPatientsByDoctorFromAppointment();
            panel1 = parent;
        }

        public viewNurse()
        {
            InitializeComponent();
            LoadPatientsByDoctorFromAppointment();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            n_id = Convert.ToInt32(
dataGridView1.Rows[e.RowIndex]
               .Cells["nurse_id"]
               .Value);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n_id = Convert.ToInt32(
dataGridView1.Rows[e.RowIndex]
              .Cells["nurse_id"]
              .Value);
            txtname.Text = dataGridView1.Rows[e.RowIndex]
               .Cells["name"]
               .Value.ToString();
            txtemail.Text = dataGridView1.Rows[e.RowIndex]
                .Cells["email"]
                .Value.ToString();
            txtage.Text = dataGridView1.Rows[e.RowIndex]
               .Cells["age"]
               .Value.ToString();
            rcbaddresss.Text = dataGridView1.Rows[e.RowIndex]
               .Cells["address"]
               .Value.ToString();
        }

        private void btnnurse_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); // remove previous page

            NurseRg await1 = new NurseRg(); // child form
            await1.TopLevel = false;               // IMPORTANT
            await1.FormBorderStyle = FormBorderStyle.None;
            await1.Dock = DockStyle.Fill;

            panel1.Controls.Add(await1);
            await1.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Global.delete("nurse", "nurse_id", n_id);
            MessageBox.Show("successfully delete");
            LoadPatientsByDoctorFromAppointment();
        }

        private void btnubdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();

                // Build query safely
                string query = $"UPDATE [nurse] SET name=@name, email=@email, age=@age, address= @address WHERE nurse_id = @n_id ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@n_id", n_id);
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtage.Text));
                    cmd.Parameters.AddWithValue("@address", rcbaddresss.Text);
                    cmd.ExecuteNonQuery();
                   
                }
                LoadPatientsByDoctorFromAppointment();
                MessageBox.Show(" update successful");
            }
        }
    }
}
