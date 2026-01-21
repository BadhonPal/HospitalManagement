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
    public partial class Login : Form
    {
        bool isusername = true;
        bool ispassword = true;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbusername.Text == "") {
                isusername = false;
                lblemptyname.Visible = true;
            } else if (tbpassword.Text=="") {
                ispassword = false;
                lblemptypass.Visible = true;
            } else {
                string username = tbusername.Text;
                string inputPassword = tbpassword.Text;

                
                using (SqlConnection con = new SqlConnection(Global.constring))
                {
                    con.Open();

                    string query = @"SELECT user_id, password, role 
                     FROM [user] 
                     WHERE username = @username";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string dbUserId = reader["user_id"].ToString();
                        string dbPassword = reader["password"].ToString();
                        string dbRole = reader["role"].ToString();

                        if (dbPassword == inputPassword)
                        {

                            int did = Convert.ToInt32(dbUserId);
                            if (dbRole == "doctor")
                            {

                                nahid docForm = new nahid(did);
                                docForm.Show();
                                this.Hide();




                            } else if (dbRole == "admin") {

                                admindashboard ad = new admindashboard();
                                ad.Show();
                                this.Hide();
                            } else if (dbRole=="patient") {
                                Patientdashboard pd = new Patientdashboard(did);
                                pd.Show();
                                this.Hide();
                            }
                             else if (dbRole == "nurse")
                            {
                                nursedashboard nd = new nursedashboard(did);
                                nd.Show();
                                this.Hide();
                            }


                        }
                        else
                        {
                            lblwrongpass.Visible = true;

                        }

                    }
                    else
                    {
                        lblwronguser.Visible=true;
                    }

                }
            }

        }

        private void tbusername_TextChanged(object sender, EventArgs e)
        {
            lblwronguser.Visible = false;
            if (tbusername.Text!="") {
                isusername = true;
                lblemptyname.Visible = false;
            }
        }

        private void tbpassword_TextChanged(object sender, EventArgs e)
        {
            lblwrongpass.Visible = false;
            if (tbpassword.Text != "")
            {
                ispassword = true;
                lblemptypass.Visible = false;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            registration reg = new registration();
            reg.Show();
            this.Hide();
        }
    }
}
