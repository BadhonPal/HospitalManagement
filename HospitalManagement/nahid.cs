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
    public partial class nahid : Form
    {
        int did;
        string name;
        void getname(int id)
        {
            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();


                string query = $"SELECT name FROM [doctor] WHERE doctor_id=@did";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@did", id);



                    // cmd.ExecuteNonQuery();
                    name = cmd.ExecuteScalar().ToString();
                    lbldoctorname.Text = name;

                }
            }
        }
        void godashboard(int d_id) {
            panelfill.Controls.Clear(); 

            dashboard dash = new dashboard(d_id);
            dash.TopLevel = false;              
            dash.FormBorderStyle = FormBorderStyle.None;
            dash.Dock = DockStyle.Fill;

            panelfill.Controls.Add(dash);
            dash.Show();
        }
        public nahid(int id) {
            InitializeComponent();
             did=id;
            godashboard(id);
            getname(id);


            //MessageBox.Show("Doctor ID: " + did);

        }
        public nahid()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nahid n = new nahid(did);
            n.Show();
            this.Hide();
        }

        private void panelfill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nahid_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            panelfill.Controls.Clear(); // remove previous page

            waitting wait = new waitting(did,panelfill); // child form
            wait.TopLevel = false;               // IMPORTANT
            wait.FormBorderStyle = FormBorderStyle.None;
            wait.Dock = DockStyle.Fill;

            panelfill.Controls.Add(wait);
            wait.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbloldpatient_Click(object sender, EventArgs e)
        {
            panelfill.Controls.Clear(); // remove previous page

            oldPatient op = new oldPatient(did, panelfill); // child form
            op.TopLevel = false;               // IMPORTANT
            op.FormBorderStyle = FormBorderStyle.None;
            op.Dock = DockStyle.Fill;

            panelfill.Controls.Add(op);
            op.Show();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login li = new Login();
            li.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            godashboard(did);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panelfill.Controls.Clear(); // remove previous page

            doctorprofile op = new doctorprofile(did); // child form
            op.TopLevel = false;               // IMPORTANT
            op.FormBorderStyle = FormBorderStyle.None;
            op.Dock = DockStyle.Fill;

            panelfill.Controls.Add(op);
            op.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panelfill.Controls.Clear(); // remove previous page

            salary1 op = new salary1(did); // child form
            op.TopLevel = false;               // IMPORTANT
            op.FormBorderStyle = FormBorderStyle.None;
            op.Dock = DockStyle.Fill;

            panelfill.Controls.Add(op);
            op.Show();

        }

        private void panelsidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
