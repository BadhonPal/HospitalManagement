namespace HospitalManagement
{
    partial class payment
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
            this.lblpname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbldamount = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.textpid = new System.Windows.Forms.TextBox();
            this.textaccno = new System.Windows.Forms.TextBox();
            this.textdue = new System.Windows.Forms.TextBox();
            this.lblatopay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combopaymentoption1 = new System.Windows.Forms.ComboBox();
            this.textamounttopay = new System.Windows.Forms.TextBox();
            this.btconfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpname.Location = new System.Drawing.Point(96, 161);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(141, 25);
            this.lblpname.TabIndex = 0;
            this.lblpname.Text = "Patient Name";
            this.lblpname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(118, 76);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(106, 25);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "Patient ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Number";
            // 
            // lbldamount
            // 
            this.lbldamount.AutoSize = true;
            this.lbldamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldamount.Location = new System.Drawing.Point(106, 341);
            this.lbldamount.Name = "lbldamount";
            this.lbldamount.Size = new System.Drawing.Size(131, 25);
            this.lbldamount.TabIndex = 3;
            this.lbldamount.Text = "Due Amount";
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(271, 77);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(100, 26);
            this.txtpname.TabIndex = 4;
            // 
            // textpid
            // 
            this.textpid.Location = new System.Drawing.Point(271, 162);
            this.textpid.Name = "textpid";
            this.textpid.Size = new System.Drawing.Size(100, 26);
            this.textpid.TabIndex = 5;
            this.textpid.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textaccno
            // 
            this.textaccno.Location = new System.Drawing.Point(271, 251);
            this.textaccno.Name = "textaccno";
            this.textaccno.Size = new System.Drawing.Size(100, 26);
            this.textaccno.TabIndex = 6;
            // 
            // textdue
            // 
            this.textdue.Location = new System.Drawing.Point(282, 342);
            this.textdue.Name = "textdue";
            this.textdue.Size = new System.Drawing.Size(100, 26);
            this.textdue.TabIndex = 7;
            // 
            // lblatopay
            // 
            this.lblatopay.AutoSize = true;
            this.lblatopay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblatopay.Location = new System.Drawing.Point(76, 413);
            this.lblatopay.Name = "lblatopay";
            this.lblatopay.Size = new System.Drawing.Size(161, 25);
            this.lblatopay.TabIndex = 8;
            this.lblatopay.Text = "Amount To Pay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Payment Option:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // combopaymentoption1
            // 
            this.combopaymentoption1.FormattingEnabled = true;
            this.combopaymentoption1.Items.AddRange(new object[] {
            "Bkash",
            "Nogod",
            "Rocket"});
            this.combopaymentoption1.Location = new System.Drawing.Point(271, 483);
            this.combopaymentoption1.Name = "combopaymentoption1";
            this.combopaymentoption1.Size = new System.Drawing.Size(121, 28);
            this.combopaymentoption1.TabIndex = 11;
            // 
            // textamounttopay
            // 
            this.textamounttopay.Location = new System.Drawing.Point(282, 414);
            this.textamounttopay.Name = "textamounttopay";
            this.textamounttopay.Size = new System.Drawing.Size(100, 26);
            this.textamounttopay.TabIndex = 12;
            // 
            // btconfirm
            // 
            this.btconfirm.BackColor = System.Drawing.Color.Teal;
            this.btconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconfirm.Location = new System.Drawing.Point(442, 539);
            this.btconfirm.Name = "btconfirm";
            this.btconfirm.Size = new System.Drawing.Size(153, 46);
            this.btconfirm.TabIndex = 13;
            this.btconfirm.Text = "Confirm";
            this.btconfirm.UseVisualStyleBackColor = false;
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 597);
            this.Controls.Add(this.btconfirm);
            this.Controls.Add(this.textamounttopay);
            this.Controls.Add(this.combopaymentoption1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblatopay);
            this.Controls.Add(this.textdue);
            this.Controls.Add(this.textaccno);
            this.Controls.Add(this.textpid);
            this.Controls.Add(this.txtpname);
            this.Controls.Add(this.lbldamount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblpname);
            this.Name = "payment";
            this.Text = "payment";
            this.Load += new System.EventHandler(this.payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lbldamount;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.TextBox textpid;
        private System.Windows.Forms.TextBox textaccno;
        private System.Windows.Forms.TextBox textdue;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblatopay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combopaymentoption1;
        private System.Windows.Forms.TextBox textamounttopay;
        private System.Windows.Forms.Button btconfirm;
    }
}