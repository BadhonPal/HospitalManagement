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
            this.lbldamount = new System.Windows.Forms.Label();
            this.textdue = new System.Windows.Forms.TextBox();
            this.lblatopay = new System.Windows.Forms.Label();
            this.textamounttopay = new System.Windows.Forms.TextBox();
            this.btconfirm = new System.Windows.Forms.Button();
            this.lblpid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvbill = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldamount
            // 
            this.lbldamount.AutoSize = true;
            this.lbldamount.BackColor = System.Drawing.Color.SkyBlue;
            this.lbldamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldamount.Location = new System.Drawing.Point(347, 426);
            this.lbldamount.Name = "lbldamount";
            this.lbldamount.Size = new System.Drawing.Size(131, 25);
            this.lbldamount.TabIndex = 3;
            this.lbldamount.Text = "Due Amount";
            // 
            // textdue
            // 
            this.textdue.Location = new System.Drawing.Point(509, 427);
            this.textdue.Name = "textdue";
            this.textdue.Size = new System.Drawing.Size(121, 26);
            this.textdue.TabIndex = 7;
            // 
            // lblatopay
            // 
            this.lblatopay.AutoSize = true;
            this.lblatopay.BackColor = System.Drawing.Color.SkyBlue;
            this.lblatopay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblatopay.Location = new System.Drawing.Point(317, 476);
            this.lblatopay.Name = "lblatopay";
            this.lblatopay.Size = new System.Drawing.Size(161, 25);
            this.lblatopay.TabIndex = 8;
            this.lblatopay.Text = "Amount To Pay";
            // 
            // textamounttopay
            // 
            this.textamounttopay.Location = new System.Drawing.Point(509, 477);
            this.textamounttopay.Name = "textamounttopay";
            this.textamounttopay.Size = new System.Drawing.Size(121, 26);
            this.textamounttopay.TabIndex = 12;
            // 
            // btconfirm
            // 
            this.btconfirm.BackColor = System.Drawing.Color.Teal;
            this.btconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconfirm.Location = new System.Drawing.Point(369, 540);
            this.btconfirm.Name = "btconfirm";
            this.btconfirm.Size = new System.Drawing.Size(223, 45);
            this.btconfirm.TabIndex = 13;
            this.btconfirm.Text = "Give payment";
            this.btconfirm.UseVisualStyleBackColor = false;
            this.btconfirm.Click += new System.EventHandler(this.btconfirm_Click);
            // 
            // lblpid
            // 
            this.lblpid.AutoSize = true;
            this.lblpid.BackColor = System.Drawing.Color.SkyBlue;
            this.lblpid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpid.Location = new System.Drawing.Point(372, 372);
            this.lblpid.Name = "lblpid";
            this.lblpid.Size = new System.Drawing.Size(106, 25);
            this.lblpid.TabIndex = 14;
            this.lblpid.Text = "Patient ID";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtid.Location = new System.Drawing.Point(509, 372);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(121, 26);
            this.txtid.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Palace Script MT", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(180, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 70);
            this.button1.TabIndex = 16;
            this.button1.Text = "Payment";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvbill
            // 
            this.dgvbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbill.Location = new System.Drawing.Point(42, 107);
            this.dgvbill.Name = "dgvbill";
            this.dgvbill.RowHeadersWidth = 62;
            this.dgvbill.RowTemplate.Height = 28;
            this.dgvbill.Size = new System.Drawing.Size(436, 219);
            this.dgvbill.TabIndex = 17;
            this.dgvbill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbill_CellClick);
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 597);
            this.Controls.Add(this.dgvbill);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblpid);
            this.Controls.Add(this.btconfirm);
            this.Controls.Add(this.textamounttopay);
            this.Controls.Add(this.lblatopay);
            this.Controls.Add(this.textdue);
            this.Controls.Add(this.lbldamount);
            this.Name = "payment";
            this.Text = "payment";
            this.Load += new System.EventHandler(this.payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbldamount;
        private System.Windows.Forms.TextBox textdue;
        private System.Windows.Forms.Label lblatopay;
        private System.Windows.Forms.TextBox textamounttopay;
        private System.Windows.Forms.Button btconfirm;
        private System.Windows.Forms.Label lblpid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvbill;
    }
}