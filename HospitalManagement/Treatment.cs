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
                rtbtest.AppendText("• " + cbhiv.Text + "\n");
                cbhiv.Checked = false;

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
