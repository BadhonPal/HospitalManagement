namespace HospitalManagement
{
    partial class payBill
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnunpaid = new System.Windows.Forms.Button();
            this.btnpaid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(723, 240);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnunpaid
            // 
            this.btnunpaid.BackColor = System.Drawing.Color.Red;
            this.btnunpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnunpaid.ForeColor = System.Drawing.Color.White;
            this.btnunpaid.Location = new System.Drawing.Point(226, 358);
            this.btnunpaid.Name = "btnunpaid";
            this.btnunpaid.Size = new System.Drawing.Size(129, 39);
            this.btnunpaid.TabIndex = 1;
            this.btnunpaid.Text = "Unpaid";
            this.btnunpaid.UseVisualStyleBackColor = false;
            this.btnunpaid.Click += new System.EventHandler(this.btnunpaid_Click);
            // 
            // btnpaid
            // 
            this.btnpaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpaid.ForeColor = System.Drawing.Color.White;
            this.btnpaid.Location = new System.Drawing.Point(505, 358);
            this.btnpaid.Name = "btnpaid";
            this.btnpaid.Size = new System.Drawing.Size(118, 40);
            this.btnpaid.TabIndex = 2;
            this.btnpaid.Text = "Paid";
            this.btnpaid.UseVisualStyleBackColor = false;
            this.btnpaid.Click += new System.EventHandler(this.btnpaid_Click);
            // 
            // payBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 506);
            this.Controls.Add(this.btnpaid);
            this.Controls.Add(this.btnunpaid);
            this.Controls.Add(this.dataGridView1);
            this.Name = "payBill";
            this.Text = "payBill";
            this.Load += new System.EventHandler(this.payBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnunpaid;
        private System.Windows.Forms.Button btnpaid;
    }
}