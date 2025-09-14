namespace CapaPresentacion
{
    partial class frmCategoria
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
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.btnAceptarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(210, 63);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(230, 22);
            this.txtNombreCategoria.TabIndex = 7;
            this.txtNombreCategoria.TextChanged += new System.EventHandler(this.txtNombreCategoria_TextChanged);
            this.txtNombreCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCategoria_KeyPress);
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Location = new System.Drawing.Point(85, 69);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(69, 16);
            this.lblNombreCategoria.TabIndex = 6;
            this.lblNombreCategoria.Text = "Categoría:";
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.Location = new System.Drawing.Point(310, 160);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(88, 40);
            this.btnCancelarCategoria.TabIndex = 9;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.UseVisualStyleBackColor = true;
            this.btnCancelarCategoria.Click += new System.EventHandler(this.btnCancelarCategoria_Click);
            // 
            // btnAceptarCategoria
            // 
            this.btnAceptarCategoria.Location = new System.Drawing.Point(106, 160);
            this.btnAceptarCategoria.Name = "btnAceptarCategoria";
            this.btnAceptarCategoria.Size = new System.Drawing.Size(88, 40);
            this.btnAceptarCategoria.TabIndex = 8;
            this.btnAceptarCategoria.Text = "Aceptar";
            this.btnAceptarCategoria.UseVisualStyleBackColor = true;
            this.btnAceptarCategoria.Click += new System.EventHandler(this.btnAceptarCategoria_Click);
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(519, 271);
            this.Controls.Add(this.btnCancelarCategoria);
            this.Controls.Add(this.btnAceptarCategoria);
            this.Controls.Add(this.txtNombreCategoria);
            this.Controls.Add(this.lblNombreCategoria);
            this.Name = "frmCategoria";
            this.Text = "Agregar Nueva Categoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.Button btnCancelarCategoria;
        private System.Windows.Forms.Button btnAceptarCategoria;
    }
}