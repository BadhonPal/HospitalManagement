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
    public partial class Patientdashboard : Form
    {
        public Patientdashboard()
        {
            InitializeComponent();
        }
        int pid;
        public Patientdashboard(int id)
        {  
            pid = id;
            
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Patientdashboard_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblprofile_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear(); // remove previous page

            profile wait = new profile(5); // child form
            wait.TopLevel = false;               // IMPORTANT
            wait.FormBorderStyle = FormBorderStyle.None;
            wait.Dock = DockStyle.Fill;

            panel2.Controls.Add(wait);
            wait.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear(); // remove previous page

            viewappoint wait = new viewappoint(pid); // child form
            wait.TopLevel = false;               // IMPORTANT
            wait.FormBorderStyle = FormBorderStyle.None;
            wait.Dock = DockStyle.Fill;

            panel2.Controls.Add(wait);
            wait.Show();
        }

        private void lblappoinment_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear(); // remove previous page

            appointment await = new appointment(pid); // child form
            await.TopLevel = false;               // IMPORTANT
            await.FormBorderStyle = FormBorderStyle.None;
            await.Dock = DockStyle.Fill;

            panel2.Controls.Add(await);
            await.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void lblpathist_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear(); // remove previous page

            prescription wait2 = new prescription(); // child form
            wait2.TopLevel = false;               // IMPORTANT
            wait2.FormBorderStyle = FormBorderStyle.None;
            wait2.Dock = DockStyle.Fill;

            panel2.Controls.Add(wait2);
            wait2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear(); // remove previous page

           payment wait1 = new payment(); // child form
            wait1.TopLevel = false;               // IMPORTANT
            wait1.FormBorderStyle = FormBorderStyle.None;
            wait1.Dock = DockStyle.Fill;

            panel2.Controls.Add(wait1);
            wait1.Show();
        }
    }
    }
