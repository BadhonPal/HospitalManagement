namespace HospitalManagement
{
    partial class registration
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblbg = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.rdbmale = new System.Windows.Forms.RadioButton();
            this.rdbfemale = new System.Windows.Forms.RadioButton();
            this.richtextaddre = new System.Windows.Forms.RichTextBox();
            this.btregister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtbg = new System.Windows.Forms.TextBox();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(98, 54);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(81, 25);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name :";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(483, 141);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(78, 25);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address :";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(98, 122);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(64, 25);
            this.lblage.TabIndex = 3;
            this.lblage.Text = "Age :";
            this.lblage.Click += new System.EventHandler(this.lblage_Click);
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(66, 191);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(96, 25);
            this.lblgender.TabIndex = 4;
            this.lblgender.Text = "Gender :";
            this.lblgender.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblbg
            // 
            this.lblbg.AutoSize = true;
            this.lblbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbg.Location = new System.Drawing.Point(17, 284);
            this.lblbg.Name = "lblbg";
            this.lblbg.Size = new System.Drawing.Size(145, 25);
            this.lblbg.TabIndex = 6;
            this.lblbg.Text = "Blood Group :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(194, 53);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(146, 26);
            this.txtname.TabIndex = 7;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(194, 109);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(146, 26);
            this.txtage.TabIndex = 8;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(576, 142);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(142, 26);
            this.txtemail.TabIndex = 9;
            // 
            // rdbmale
            // 
            this.rdbmale.AutoSize = true;
            this.rdbmale.Location = new System.Drawing.Point(194, 181);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(68, 24);
            this.rdbmale.TabIndex = 11;
            this.rdbmale.TabStop = true;
            this.rdbmale.Text = "Male";
            this.rdbmale.UseVisualStyleBackColor = true;
            // 
            // rdbfemale
            // 
            this.rdbfemale.AutoSize = true;
            this.rdbfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbfemale.Location = new System.Drawing.Point(268, 181);
            this.rdbfemale.Name = "rdbfemale";
            this.rdbfemale.Size = new System.Drawing.Size(87, 24);
            this.rdbfemale.TabIndex = 12;
            this.rdbfemale.TabStop = true;
            this.rdbfemale.Text = "Female";
            this.rdbfemale.UseVisualStyleBackColor = true;
            this.rdbfemale.CheckedChanged += new System.EventHandler(this.rdbfemale_CheckedChanged);
            // 
            // richtextaddre
            // 
            this.richtextaddre.Location = new System.Drawing.Point(194, 349);
            this.richtextaddre.Name = "richtextaddre";
            this.richtextaddre.Size = new System.Drawing.Size(212, 96);
            this.richtextaddre.TabIndex = 14;
            this.richtextaddre.Text = "";
            // 
            // btregister
            // 
            this.btregister.BackColor = System.Drawing.Color.Teal;
            this.btregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btregister.Location = new System.Drawing.Point(505, 399);
            this.btregister.Name = "btregister";
            this.btregister.Size = new System.Drawing.Size(137, 46);
            this.btregister.TabIndex = 15;
            this.btregister.Text = "Register";
            this.btregister.UseVisualStyleBackColor = false;
            this.btregister.Click += new System.EventHandler(this.btregister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Password :";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(572, 62);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(146, 26);
            this.txtpass.TabIndex = 17;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpid_TextChanged);
            // 
            // txtbg
            // 
            this.txtbg.Location = new System.Drawing.Point(194, 285);
            this.txtbg.Name = "txtbg";
            this.txtbg.Size = new System.Drawing.Size(146, 26);
            this.txtbg.TabIndex = 18;
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(572, 21);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(146, 26);
            this.txtuname.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "User Name :";
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalManagement.Properties.Resources.Media__25_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 546);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbg);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btregister);
            this.Controls.Add(this.richtextaddre);
            this.Controls.Add(this.rdbfemale);
            this.Controls.Add(this.rdbmale);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblbg);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblname);
            this.Name = "registration";
            this.Load += new System.EventHandler(this.registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblbg;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.RadioButton rdbmale;
        private System.Windows.Forms.RadioButton rdbfemale;
        private System.Windows.Forms.RichTextBox richtextaddre;
        private System.Windows.Forms.Button btregister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtbg;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.Label label2;
    }
}