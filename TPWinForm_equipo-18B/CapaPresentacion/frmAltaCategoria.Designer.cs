namespace CapaPresentacion
{
    partial class frmAltaCategoria
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
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelarCategoria.Location = new System.Drawing.Point(404, 481);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(86, 53);
            this.btnCancelarCategoria.TabIndex = 7;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.UseVisualStyleBackColor = true;
            this.btnCancelarCategoria.Click += new System.EventHandler(this.btnCancelarCategoria_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(94, 481);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(86, 51);
            this.btnAgregarCategoria.TabIndex = 6;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategorias.Location = new System.Drawing.Point(94, 41);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(396, 398);
            this.dgvCategorias.TabIndex = 8;
            this.dgvCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificarCategoria.Location = new System.Drawing.Point(198, 481);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(86, 51);
            this.btnModificarCategoria.TabIndex = 9;
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(303, 481);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(86, 51);
            this.btnEliminarCategoria.TabIndex = 10;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // frmAltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(579, 599);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btnCancelarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Categoría";
            this.Load += new System.EventHandler(this.frmAltaCategoria_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
    }
}