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
    public partial class doctorprofile : Form
    {
        int d_id;
        public void showdoctorinfo(int did)
        {
            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();

                string query = @"SELECT * 
                     FROM [doctor] 
                     WHERE doctor_id = @d_id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@d_id", did);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                   
                    lblname.Text = reader["name"].ToString();
                    tbname.Text = reader["name"].ToString();

                    lblage.Text = reader["age"].ToString();
                    tbage.Text = reader["age"].ToString();
                    lblgender.Text = reader["gender"].ToString();
                    if (reader["gender"].ToString()=="male") { rbmale.Checked = true; } else {
                        rbfemale.Checked = true;
                    }
                        lblmail.Text = reader["email"].ToString();
                    tbmail.Text = reader["email"].ToString();

                    lblqualification.Text = reader["qualification"].ToString();
                    tbqua.Text = reader["qualification"].ToString();
                    lblavailable.Text = reader["availability"].ToString();
                    tbavail.Text = reader["availability"].ToString();
                    lblspacialist.Text = reader["specialist"].ToString();
                    tbspacialist.Text = reader["specialist"].ToString();





                }

            }

        }






        public doctorprofile()
        {
            InitializeComponent();
        }
        public doctorprofile(int docid)
        {
            InitializeComponent();
            d_id = docid;
            showdoctorinfo(docid);
            tbname.Visible = false;
            tbage.Visible = false;
            tbmail.Visible = false;
            tbqua.Visible = false;
            tbavail.Visible = false;
            tbspacialist.Visible = false;
            rbmale.Visible = false;
            rbfemale.Visible = false;

        }

        private void doctorprofile_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (btnsave.Text == "Save")
            {
                tbname.Visible = false;
                tbage.Visible = false;
                tbmail.Visible = false;
                tbqua.Visible = false;
                tbavail.Visible = false;
                tbspacialist.Visible = false;
                rbmale.Visible = false;
                rbfemale.Visible = false;
                btnsave.Text = "Edit";
                lblname.Visible = true;
                lblmail.Visible = true;
                lblqualification.Visible = true;
                lblavailable.Visible = true;
                lblspacialist.Visible = true;
                lblage.Visible = true;
                btnsave.BackColor= Color.DarkGreen;


            }
            else { 
                lblname.Visible= false;
                lblage.Visible = false;
                lblmail.Visible = false;
                lblqualification.Visible = false;
                lblavailable.Visible = false;
                lblspacialist.Visible = false;
                tbname.Visible = true;
                tbage.Visible = true;
                tbmail.Visible = true;
                tbqua.Visible = true;
                tbavail.Visible = true;
                tbspacialist.Visible = true;
                rbmale.Visible = true;
                rbfemale.Visible = true;
                btnsave.Text = "Save";
                btnsave.BackColor = Color.Navy;
            }
        }
    }
}
