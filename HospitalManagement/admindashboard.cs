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
    public partial class admindashboard : Form
    {
        void getdoctorcount() {
            string query = "SELECT COUNT(*) FROM Doctor";

            using (SqlConnection con = new SqlConnection(badhon.constring))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                lblDcount.Text = cmd.ExecuteScalar().ToString();
            }

        }


        void getpatientcount()
        {
            string query = "SELECT COUNT(*) FROM Patient";

            using (SqlConnection con = new SqlConnection(badhon.constring))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                lblPcount.Text = cmd.ExecuteScalar().ToString();
            }

        }

        void getnursecount()
        {
            string query = "SELECT COUNT(*) FROM nurse";

            using (SqlConnection con = new SqlConnection(badhon.constring))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                lblNcount.Text = cmd.ExecuteScalar().ToString();
            }

        }
        public admindashboard()
        {
            InitializeComponent();
            getdoctorcount();
            getpatientcount();
            getnursecount();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear(); 

            viewDocotor wait = new viewDocotor(panel3); 
            wait.TopLevel = false;              
            wait.FormBorderStyle = FormBorderStyle.None;
            wait.Dock = DockStyle.Fill;

            panel3.Controls.Add(wait);
            wait.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear(); 

            viewPatient w = new viewPatient(); 
            w.TopLevel = false;              
            w.FormBorderStyle = FormBorderStyle.None;
            w.Dock = DockStyle.Fill;

            panel3.Controls.Add(w);
            w.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Doctor_Click(object sender, EventArgs e)
        {

        }

        private void lblnurse_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear(); 

            viewNurse w = new viewNurse(panel3); 
            w.TopLevel = false;               
            w.FormBorderStyle = FormBorderStyle.None;
            w.Dock = DockStyle.Fill;

            panel3.Controls.Add(w);
            w.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            admindashboard ad = new admindashboard();
            ad.Show();
            this.Hide();
        }

        private void lblpayment_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear(); 

            payBill w = new payBill(); 
            w.TopLevel = false;               
            w.FormBorderStyle = FormBorderStyle.None;
            w.Dock = DockStyle.Fill;

            panel3.Controls.Add(w);
            w.Show();
        }

        private void lblDcount_Click(object sender, EventArgs e)
        {

        }

        private void lblPcount_Click(object sender, EventArgs e)
        {

        }
    }
}
