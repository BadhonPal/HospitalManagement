using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class nahid : Form
    {
        int did;
        public nahid(int id) {
            InitializeComponent();
             did=id;
            MessageBox.Show("Doctor ID: " + did);

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
            panelfill.Controls.Clear(); // remove previous page

            Form1 ordersForm = new Form1(); // child form
            ordersForm.TopLevel = false;               // IMPORTANT
            ordersForm.FormBorderStyle = FormBorderStyle.None;
            ordersForm.Dock = DockStyle.Fill;

            panelfill.Controls.Add(ordersForm);
            ordersForm.Show();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
    }
}
