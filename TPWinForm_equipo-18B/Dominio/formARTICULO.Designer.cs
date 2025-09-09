namespace Dominio
{
    partial class formARTICULO
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
            this.dgvARTICULOS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvARTICULOS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvARTICULOS
            // 
            this.dgvARTICULOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvARTICULOS.Location = new System.Drawing.Point(37, 29);
            this.dgvARTICULOS.Name = "dgvARTICULOS";
            this.dgvARTICULOS.RowHeadersWidth = 51;
            this.dgvARTICULOS.RowTemplate.Height = 24;
            this.dgvARTICULOS.Size = new System.Drawing.Size(1189, 474);
            this.dgvARTICULOS.TabIndex = 0;
            this.dgvARTICULOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // formARTICULO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 555);
            this.Controls.Add(this.dgvARTICULOS);
            this.Name = "formARTICULO";
            this.Text = "formARTICULO";
            this.Load += new System.EventHandler(this.formARTICULO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvARTICULOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvARTICULOS;
    }
}