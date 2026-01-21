namespace HospitalManagement
{
    partial class salary1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmonth = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbamount = new System.Windows.Forms.TextBox();
            this.tbmonth = new System.Windows.Forms.TextBox();
            this.dgvsalary = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(700, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(398, 55);
            this.label3.TabIndex = 29;
            this.label3.Text = "Request For Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(-47, -78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 55);
            this.label2.TabIndex = 28;
            this.label2.Text = "View All Salary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(713, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 41);
            this.label1.TabIndex = 27;
            this.label1.Text = "Amount";
            // 
            // lblmonth
            // 
            this.lblmonth.AutoSize = true;
            this.lblmonth.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonth.Location = new System.Drawing.Point(713, 203);
            this.lblmonth.Name = "lblmonth";
            this.lblmonth.Size = new System.Drawing.Size(119, 41);
            this.lblmonth.TabIndex = 26;
            this.lblmonth.Text = "Month";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(720, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 66);
            this.button1.TabIndex = 25;
            this.button1.Text = "Request for Salary";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbamount
            // 
            this.tbamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbamount.Location = new System.Drawing.Point(720, 358);
            this.tbamount.Name = "tbamount";
            this.tbamount.Size = new System.Drawing.Size(336, 44);
            this.tbamount.TabIndex = 24;
            // 
            // tbmonth
            // 
            this.tbmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmonth.Location = new System.Drawing.Point(720, 247);
            this.tbmonth.Name = "tbmonth";
            this.tbmonth.Size = new System.Drawing.Size(336, 44);
            this.tbmonth.TabIndex = 23;
            // 
            // dgvsalary
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsalary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvsalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsalary.Location = new System.Drawing.Point(64, 60);
            this.dgvsalary.Name = "dgvsalary";
            this.dgvsalary.RowHeadersWidth = 82;
            this.dgvsalary.RowTemplate.Height = 33;
            this.dgvsalary.Size = new System.Drawing.Size(618, 533);
            this.dgvsalary.TabIndex = 22;
            // 
            // salary1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 669);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmonth);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbamount);
            this.Controls.Add(this.tbmonth);
            this.Controls.Add(this.dgvsalary);
            this.Name = "salary1";
            this.Text = "salary1";
            this.Load += new System.EventHandler(this.salary1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmonth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbamount;
        private System.Windows.Forms.TextBox tbmonth;
        private System.Windows.Forms.DataGridView dgvsalary;
    }
}