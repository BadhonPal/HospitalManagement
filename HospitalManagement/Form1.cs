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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string username = tbname.Text;
            string inputPassword = tbpass.Text;

            string constring = "server=localhost;Database=HMS;Trusted_connection=True;TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(constring))
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
                        MessageBox.Show("✅ Login Successful");
                        if (dbRole == "doctor")
                        {
                           
                            nahid docForm = new nahid(Convert.ToInt32(dbUserId));
                            docForm.Show();
                            this.Hide();




                        }


                    }
                    else
                    {
                        MessageBox.Show("❌ Password Not Matched");
                    }
                    
                }
                else
                {
                    MessageBox.Show("❌ User not found");
                }
                
            }


        }

        private void tbpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
