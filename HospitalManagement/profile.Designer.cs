namespace HospitalManagement
{
    partial class profile
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
            this.richtextaddre = new System.Windows.Forms.RichTextBox();
            this.txtbg = new System.Windows.Forms.ComboBox();
            this.rdbfemale = new System.Windows.Forms.RadioButton();
            this.rdbmale = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblbg = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.btupdate = new System.Windows.Forms.Button();
            this.lblprofiledesign = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richtextaddre
            // 
            this.richtextaddre.Location = new System.Drawing.Point(282, 376);
            this.richtextaddre.Name = "richtextaddre";
            this.richtextaddre.Size = new System.Drawing.Size(241, 106);
            this.richtextaddre.TabIndex = 29;
            this.richtextaddre.Text = "";
            // 
            // txtbg
            // 
            this.txtbg.FormattingEnabled = true;
            this.txtbg.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "O+",
            "O-",
            "A-",
            "B-"});
            this.txtbg.Location = new System.Drawing.Point(282, 323);
            this.txtbg.Name = "txtbg";
            this.txtbg.Size = new System.Drawing.Size(241, 28);
            this.txtbg.TabIndex = 28;
            // 
            // rdbfemale
            // 
            this.rdbfemale.AutoSize = true;
            this.rdbfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbfemale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbfemale.Location = new System.Drawing.Point(398, 280);
            this.rdbfemale.Name = "rdbfemale";
            this.rdbfemale.Size = new System.Drawing.Size(108, 29);
            this.rdbfemale.TabIndex = 27;
            this.rdbfemale.TabStop = true;
            this.rdbfemale.Text = "Female";
            this.rdbfemale.UseVisualStyleBackColor = true;
            // 
            // rdbmale
            // 
            this.rdbmale.AutoSize = true;
            this.rdbmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbmale.Location = new System.Drawing.Point(283, 280);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(84, 29);
            this.rdbmale.TabIndex = 26;
            this.rdbmale.TabStop = true;
            this.rdbmale.Text = "Male";
            this.rdbmale.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(283, 226);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 26);
            this.textBox3.TabIndex = 24;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(283, 175);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(241, 26);
            this.txtage.TabIndex = 23;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(283, 128);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(241, 26);
            this.txtname.TabIndex = 22;
            // 
            // lblbg
            // 
            this.lblbg.AutoSize = true;
            this.lblbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblbg.Location = new System.Drawing.Point(82, 326);
            this.lblbg.Name = "lblbg";
            this.lblbg.Size = new System.Drawing.Size(132, 25);
            this.lblbg.TabIndex = 21;
            this.lblbg.Text = "Blood Group";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblgender.Location = new System.Drawing.Point(82, 277);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(89, 25);
            this.lblgender.TabIndex = 19;
            this.lblgender.Text = "Gender ";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.BackColor = System.Drawing.Color.White;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblage.Location = new System.Drawing.Point(82, 176);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(57, 25);
            this.lblage.TabIndex = 18;
            this.lblage.Text = "Age ";
            this.lblage.Click += new System.EventHandler(this.lblage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(82, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Address ";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblemail.Location = new System.Drawing.Point(82, 225);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(65, 25);
            this.lblemail.TabIndex = 16;
            this.lblemail.Text = "Email";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.White;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblname.Location = new System.Drawing.Point(82, 127);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(68, 25);
            this.lblname.TabIndex = 15;
            this.lblname.Text = "Name";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // btupdate
            // 
            this.btupdate.BackColor = System.Drawing.Color.Teal;
            this.btupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btupdate.Location = new System.Drawing.Point(491, 540);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(171, 48);
            this.btupdate.TabIndex = 30;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = false;
            this.btupdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblprofiledesign
            // 
            this.lblprofiledesign.AutoSize = true;
            this.lblprofiledesign.BackColor = System.Drawing.Color.Teal;
            this.lblprofiledesign.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprofiledesign.Location = new System.Drawing.Point(259, 9);
            this.lblprofiledesign.Name = "lblprofiledesign";
            this.lblprofiledesign.Size = new System.Drawing.Size(187, 44);
            this.lblprofiledesign.TabIndex = 31;
            this.lblprofiledesign.Text = "Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(238, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(238, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(238, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 25);
            this.label7.TabIndex = 38;
            this.label7.Text = ":";
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 628);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblprofiledesign);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.richtextaddre);
            this.Controls.Add(this.txtbg);
            this.Controls.Add(this.rdbfemale);
            this.Controls.Add(this.rdbmale);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblbg);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblname);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "profile";
            this.Text = "profile";
            this.Load += new System.EventHandler(this.profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtextaddre;
        private System.Windows.Forms.ComboBox txtbg;
        private System.Windows.Forms.RadioButton rdbfemale;
        private System.Windows.Forms.RadioButton rdbmale;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblbg;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Label lblprofiledesign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}