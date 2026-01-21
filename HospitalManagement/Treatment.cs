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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HospitalManagement
{
    public partial class Treatment : Form
    {


        public void showpretientinfo(int p_id) {
            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();

                string query = @"SELECT * 
                     FROM [patient] 
                     WHERE patient_id = @p_id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@p_id", p_id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblpid.Text = reader["patient_id"].ToString();
                    lblname.Text = reader["name"].ToString();
                    lblage.Text = reader["age"].ToString();
                    lblgender.Text = reader["gender"].ToString();
                    lblbg.Text = reader["blood_group"].ToString();
                    lbldiscount.Text = reader["discount"].ToString();
                    rtname.Text= "Name: " + reader["name"].ToString()+"     Age: " + reader["age"].ToString();





                }

            }

        }





        int pid;
        int did;
        
        string disease;
        public Treatment(int p_id,int d_id,String dis) { 
            InitializeComponent();
            showpretientinfo(p_id);
            pid = p_id;
            did = d_id;
            
            disease = dis;
            lbldisease.Text = disease;
            dgvbpriscribe.Visible = false;
        }
        public Treatment()
        {
            InitializeComponent();
        }

        private void Treatment_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cbdengue.Checked)
            {
                rtbtest.AppendText("• " + cbdengue.Text+"\n");
                cbdengue.Checked = false;

            }
            if (cbcbc.Checked)
            {
                rtbtest.AppendText("• " + cbcbc.Text + "\n");
                cbcbc.Checked = false;

            }
            if (cbmri.Checked)
            {
                rtbtest.AppendText("• " + cbmri.Text + "\n");
                cbmri.Checked = false;

            }
            if (cbxray.Checked)
            {
                rtbtest.AppendText("• " + cbxray.Text + "\n");
                cbxray.Checked = false;
            }
            if (cburine.Checked)
            {
                rtbtest.AppendText("• " + cburine.Text + "\n");
                cburine.Checked = false;

            }
            if (cbhiv.Checked)
            {
                rtbtest.AppendText("• " + cbhiv.Text + "\n");
                cbhiv.Checked = false;

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pres_id;
            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();

           
                string query = $"INSERT INTO prescription (doctor_id,patient_id,prescription_info,medicine,date) VALUES (@did,@pid,@pi,@med,@date); SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    cmd.Parameters.AddWithValue("@did", did);
                    cmd.Parameters.AddWithValue("@pid", pid);
                    cmd.Parameters.AddWithValue("@pi", rtbtest.Text);
                    cmd.Parameters.AddWithValue("@med", rtmed.Text);
                    cmd.Parameters.AddWithValue("@date", date);


                   // cmd.ExecuteNonQuery();
                    pres_id = Convert.ToInt32(cmd.ExecuteScalar());
                    
                }
            }
            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();


                string query = $"INSERT INTO [checkup] (doctor_id,patient_id,prescription_id,date,disease) VALUES (@did,@pid,@prid,@date,@dis)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    cmd.Parameters.AddWithValue("@did", did);
                    cmd.Parameters.AddWithValue("@pid", pid);
                    cmd.Parameters.AddWithValue("@prid", pres_id);
                    cmd.Parameters.AddWithValue("@dis", disease);


                    cmd.Parameters.AddWithValue("@date", date);


                    cmd.ExecuteNonQuery();
                    
                }
            }
            MessageBox.Show("Treatment Complete, prescription id :" + pres_id);

        }

        private void btnoldpiscribetion_Click(object sender, EventArgs e)
        {
            using ( SqlConnection con =new SqlConnection(Global.constring)) {
                con.Open();

                string query = @"SELECT prescribe_id,date 
                     FROM [prescription] 
                     WHERE patient_id = @p_id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@p_id", pid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvbpriscribe.Visible = true;
                dgvbpriscribe.EnableHeadersVisualStyles = false;
                dgvbpriscribe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvbpriscribe.AllowUserToAddRows= false;
                dgvbpriscribe.DataSource = dt;


            }

            if (btnoldpiscribetion.Text=="View Old Prescription") {
                dgvbpriscribe.Visible = true;
                btnoldpiscribetion.Text = "View Patient Details";
            }
            else
            {
                dgvbpriscribe.Visible = false;
                btnoldpiscribetion.Text = "View Old Prescription";
                rtbtest.Clear();
                rtmed.Clear();
            }

            

        }

        private void rtbtest_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtmed_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelpres_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvbpriscribe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int pres_id;

        private void dgvbpriscribe_CellClick(object sender, DataGridViewCellEventArgs e)
           
        { if (e.RowIndex >= 0)
            {
                pres_id = Convert.ToInt32(dgvbpriscribe.Rows[e.RowIndex].Cells["prescribe_id"].Value);
                using (SqlConnection con = new SqlConnection(Global.constring))
                {
                    con.Open();
                    string query = @"SELECT medicine,prescription_info 
                     FROM [prescription] 
                     WHERE prescribe_id = @pres_id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@pres_id", pres_id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        rtmed.Text = reader["medicine"].ToString();
                        rtbtest.Text = reader["prescription_info"].ToString();
                    }
                }
            }
        }
    }
}
