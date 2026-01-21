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
    public partial class prescription : Form
    {
        int p_id;

        private void LoadPrescriptions()
        {
            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();

                string query = @"SELECT prescribe_id, doctor_id, prescription_info, medicine, date 
                                 FROM [prescription] 
                                 WHERE patient_id = @p_id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@p_id", p_id);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.DataSource = dt;
            }
        }

        public prescription()
        {
            InitializeComponent();
        }

        public prescription(int patientId)
        {
            InitializeComponent();
            p_id = patientId;
            LoadPrescriptions();
        }

        private void prescription_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            lblPrescriptionInfo.Text = dataGridView1.Rows[e.RowIndex].Cells["prescription_info"].Value?.ToString() ?? "";
            lblMedicine.Text = dataGridView1.Rows[e.RowIndex].Cells["medicine"].Value?.ToString() ?? "";
            lblDate.Text = dataGridView1.Rows[e.RowIndex].Cells["date"].Value?.ToString() ?? "";
        }
    }
}
