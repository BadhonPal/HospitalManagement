namespace HospitalManagement
{
    partial class prescription
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
            this.dataGridViewprescription = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprescription)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewprescription
            // 
            this.dataGridViewprescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewprescription.Location = new System.Drawing.Point(191, 81);
            this.dataGridViewprescription.Name = "dataGridViewprescription";
            this.dataGridViewprescription.RowHeadersWidth = 62;
            this.dataGridViewprescription.RowTemplate.Height = 28;
            this.dataGridViewprescription.Size = new System.Drawing.Size(627, 389);
            this.dataGridViewprescription.TabIndex = 0;
            // 
            // prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 660);
            this.Controls.Add(this.dataGridViewprescription);
            this.Name = "prescription";
            this.Text = "prescription";
            this.Load += new System.EventHandler(this.prescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprescription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewprescription;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}