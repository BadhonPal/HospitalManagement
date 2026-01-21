using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalManagement
{
    public partial class payment : Form
    {
        int b_id;
        void getbill() {

            

            using (SqlConnection con = new SqlConnection(Global.constring))

            {

                con.Open();

                string query = @"

SELECT * FROM [bill]";

                SqlCommand cmd = new SqlCommand(query, con);


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvbill.DataSource = dt;

            }
           
        }
        public payment()
        {
            InitializeComponent();
        }
        int p_id;
        public payment(int pid)
        {
            p_id = pid;
            InitializeComponent();
            getbill();
        }

        private void payment_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btconfirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Global.constring))
            {
                con.Open();


                string query = @"UPDATE [bill] 
SET status=@given
WHERE bill_id=@bill";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@given", "given");
                cmd.Parameters.AddWithValue("@bill", b_id);




                cmd.ExecuteNonQuery();

                MessageBox.Show(" Successfully updated!");


            }
            getbill();
        }

        private void dgvbill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            b_id = Convert.ToInt32(
dgvbill.Rows[e.RowIndex]
               .Cells["bill_id"]
               .Value);
         textdue.Text    =
dgvbill.Rows[e.RowIndex]
               .Cells["amount"]
               .Value.ToString();
          txtid.Text = 
dgvbill.Rows[e.RowIndex]
               .Cells["patient_id"]
               .Value.ToString ();
        }
    }
}
