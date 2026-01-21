namespace HospitalManagement
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblemptyname = new System.Windows.Forms.Label();
            this.lblemptypass = new System.Windows.Forms.Label();
            this.lblwronguser = new System.Windows.Forms.Label();
            this.lblwrongpass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::HospitalManagement.Properties.Resources.nahidprofilr;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1249, 764);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(813, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // tbusername
            // 
            this.tbusername.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbusername.Location = new System.Drawing.Point(810, 249);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(369, 48);
            this.tbusername.TabIndex = 2;
            this.tbusername.TextChanged += new System.EventHandler(this.tbusername_TextChanged);
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbpassword.Location = new System.Drawing.Point(810, 388);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(369, 48);
            this.tbpassword.TabIndex = 3;
            this.tbpassword.TextChanged += new System.EventHandler(this.tbpassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(813, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(862, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(843, 631);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Are you a new Patient ?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(924, 666);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sign up";
            // 
            // lblemptyname
            // 
            this.lblemptyname.AutoSize = true;
            this.lblemptyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemptyname.ForeColor = System.Drawing.Color.Red;
            this.lblemptyname.Location = new System.Drawing.Point(843, 300);
            this.lblemptyname.Name = "lblemptyname";
            this.lblemptyname.Size = new System.Drawing.Size(336, 29);
            this.lblemptyname.TabIndex = 8;
            this.lblemptyname.Text = "*Username can not be Empty !";
            this.lblemptyname.Visible = false;
            // 
            // lblemptypass
            // 
            this.lblemptypass.AutoSize = true;
            this.lblemptypass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemptypass.ForeColor = System.Drawing.Color.Red;
            this.lblemptypass.Location = new System.Drawing.Point(844, 438);
            this.lblemptypass.Name = "lblemptypass";
            this.lblemptypass.Size = new System.Drawing.Size(332, 29);
            this.lblemptypass.TabIndex = 9;
            this.lblemptypass.Text = "*Password can not be Empty !";
            this.lblemptypass.Visible = false;
            // 
            // lblwronguser
            // 
            this.lblwronguser.AutoSize = true;
            this.lblwronguser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwronguser.ForeColor = System.Drawing.Color.Red;
            this.lblwronguser.Location = new System.Drawing.Point(981, 300);
            this.lblwronguser.Name = "lblwronguser";
            this.lblwronguser.Size = new System.Drawing.Size(195, 29);
            this.lblwronguser.TabIndex = 10;
            this.lblwronguser.Text = "User Not Found !";
            this.lblwronguser.Visible = false;
            // 
            // lblwrongpass
            // 
            this.lblwrongpass.AutoSize = true;
            this.lblwrongpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwrongpass.ForeColor = System.Drawing.Color.Red;
            this.lblwrongpass.Location = new System.Drawing.Point(967, 439);
            this.lblwrongpass.Name = "lblwrongpass";
            this.lblwrongpass.Size = new System.Drawing.Size(209, 29);
            this.lblwrongpass.TabIndex = 11;
            this.lblwrongpass.Text = "Wrong Password !";
            this.lblwrongpass.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 764);
            this.Controls.Add(this.lblwrongpass);
            this.Controls.Add(this.lblwronguser);
            this.Controls.Add(this.lblemptypass);
            this.Controls.Add(this.lblemptyname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblemptyname;
        private System.Windows.Forms.Label lblemptypass;
        private System.Windows.Forms.Label lblwronguser;
        private System.Windows.Forms.Label lblwrongpass;
    }
}