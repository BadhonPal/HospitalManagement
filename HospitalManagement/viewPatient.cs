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

    public partial class viewPatient : Form
    {
        int p_id;
        private void patientLoad()
        {
       

            using (SqlConnection con = new SqlConnection(badhon.constring))
            {
                con.Open();

                string query = @"
        SELECT * FROM [patient]";

                SqlCommand cmd = new SqlCommand(query, con);


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.DataSource = dt;
            }
        }

        public viewPatient()
        {
            InitializeComponent();
            patientLoad();
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewPatient_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            p_id = Convert.ToInt32(
dataGridView2.Rows[e.RowIndex]
               .Cells["patient_id"]
               .Value);

            txtname.Text = dataGridView2.Rows[e.RowIndex]
               .Cells["name"]
               .Value.ToString();
            txtemail.Text = dataGridView2.Rows[e.RowIndex]
                .Cells["email"]
                .Value.ToString();
            txtage.Text = dataGridView2.Rows[e.RowIndex]
               .Cells["age"]
               .Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            badhon.delete("patient", "patient_id", p_id);
            MessageBox.Show("successfully delete");
            patientLoad();
        }

        private void btnubdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(badhon.constring))
            {
                con.Open();

               
                string query = $"UPDATE [patient] SET name=@name, email=@email, age=@age WHERE patient_id = @p_id ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@p_id", p_id);
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtage.Text));
                    
                    cmd.ExecuteNonQuery();

                }
                patientLoad();
                MessageBox.Show(" update successful");
            }
        }
    }
}
