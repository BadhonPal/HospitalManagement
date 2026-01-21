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
    public partial class nursedashboard : Form
    {
        public nursedashboard()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear(); // remove previous page

            assignedtask wait = new assignedtask(1, panel2); // child form
            wait.TopLevel = false;               // IMPORTANT
            wait.FormBorderStyle = FormBorderStyle.None;
            wait.Dock = DockStyle.Fill;

            panel2.Controls.Add(wait);
            wait.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear(); // remove previous page

            bedlist wait12 = new bedlist(); // child form
            wait12.TopLevel = false;               // IMPORTANT
            wait12.FormBorderStyle = FormBorderStyle.None;
            wait12.Dock = DockStyle.Fill;

            panel2.Controls.Add(wait12);
            wait12.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

            panel2.Controls.Clear(); // remove previous page

            billpay wait123 = new billpay(); // child form
            wait123.TopLevel = false;               // IMPORTANT
            wait123.FormBorderStyle = FormBorderStyle.None;
            wait123.Dock = DockStyle.Fill;

            panel2.Controls.Add(wait123);
            wait123.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
