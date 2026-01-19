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
            this.SuspendLayout();
            // 
            // richtextaddre
            // 
            this.richtextaddre.Location = new System.Drawing.Point(255, 387);
            this.richtextaddre.Name = "richtextaddre";
            this.richtextaddre.Size = new System.Drawing.Size(212, 96);
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
            this.txtbg.Location = new System.Drawing.Point(255, 321);
            this.txtbg.Name = "txtbg";
            this.txtbg.Size = new System.Drawing.Size(146, 28);
            this.txtbg.TabIndex = 28;
            // 
            // rdbfemale
            // 
            this.rdbfemale.AutoSize = true;
            this.rdbfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbfemale.Location = new System.Drawing.Point(341, 264);
            this.rdbfemale.Name = "rdbfemale";
            this.rdbfemale.Size = new System.Drawing.Size(87, 24);
            this.rdbfemale.TabIndex = 27;
            this.rdbfemale.TabStop = true;
            this.rdbfemale.Text = "Female";
            this.rdbfemale.UseVisualStyleBackColor = true;
            // 
            // rdbmale
            // 
            this.rdbmale.AutoSize = true;
            this.rdbmale.Location = new System.Drawing.Point(255, 264);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(68, 24);
            this.rdbmale.TabIndex = 26;
            this.rdbmale.TabStop = true;
            this.rdbmale.Text = "Male";
            this.rdbmale.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(256, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 26);
            this.textBox3.TabIndex = 24;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(255, 120);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(146, 26);
            this.txtage.TabIndex = 23;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(255, 73);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(146, 26);
            this.txtname.TabIndex = 22;
            // 
            // lblbg
            // 
            this.lblbg.AutoSize = true;
            this.lblbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbg.Location = new System.Drawing.Point(78, 324);
            this.lblbg.Name = "lblbg";
            this.lblbg.Size = new System.Drawing.Size(145, 25);
            this.lblbg.TabIndex = 21;
            this.lblbg.Text = "Blood Group :";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(127, 262);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(96, 25);
            this.lblgender.TabIndex = 19;
            this.lblgender.Text = "Gender :";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(159, 133);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(64, 25);
            this.lblage.TabIndex = 18;
            this.lblage.Text = "Age :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Address :";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(142, 187);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(78, 25);
            this.lblemail.TabIndex = 16;
            this.lblemail.Text = "Email :";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(142, 74);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(81, 25);
            this.lblname.TabIndex = 15;
            this.lblname.Text = "Name :";
            // 
            // btupdate
            // 
            this.btupdate.BackColor = System.Drawing.Color.Teal;
            this.btupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btupdate.Location = new System.Drawing.Point(413, 560);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(103, 38);
            this.btupdate.TabIndex = 30;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = false;
            this.btupdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 628);
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
    }
}