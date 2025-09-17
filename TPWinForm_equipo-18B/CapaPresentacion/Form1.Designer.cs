namespace CapaPresentacion
{
    partial class Form1
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnExitPrincipal = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navegaciónEntreVentanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admistrarCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblPrecioSeleccionado = new System.Windows.Forms.Label();
            this.btnEliminarImagen = new System.Windows.Forms.Button();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.btnListarUnaImagen = new System.Windows.Forms.Button();
            this.btnListarTodasImagenes = new System.Windows.Forms.Button();
            this.lblListarPor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(17, 161);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(985, 316);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(17, 507);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 37);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar Artículo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(177, 507);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(131, 66);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar Artículo y Imagen";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(1025, 161);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(315, 315);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 3;
            this.pbxArticulo.TabStop = false;
            this.pbxArticulo.Click += new System.EventHandler(this.pbxArticulo_Click);
            // 
            // btnExitPrincipal
            // 
            this.btnExitPrincipal.FlatAppearance.BorderSize = 3;
            this.btnExitPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitPrincipal.Location = new System.Drawing.Point(1124, 507);
            this.btnExitPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExitPrincipal.Name = "btnExitPrincipal";
            this.btnExitPrincipal.Size = new System.Drawing.Size(111, 34);
            this.btnExitPrincipal.TabIndex = 4;
            this.btnExitPrincipal.Text = "SALIR";
            this.btnExitPrincipal.UseVisualStyleBackColor = true;
            this.btnExitPrincipal.Click += new System.EventHandler(this.btnExitPrincipal_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(15, 109);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(81, 16);
            this.lblFiltro.TabIndex = 6;
            this.lblFiltro.Text = "Filtro rápido:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(113, 107);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(252, 22);
            this.txtFiltro.TabIndex = 7;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navegaciónEntreVentanasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1353, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // navegaciónEntreVentanasToolStripMenuItem
            // 
            this.navegaciónEntreVentanasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admistrarCategoríasToolStripMenuItem,
            this.administrarMarcaToolStripMenuItem});
            this.navegaciónEntreVentanasToolStripMenuItem.Name = "navegaciónEntreVentanasToolStripMenuItem";
            this.navegaciónEntreVentanasToolStripMenuItem.Size = new System.Drawing.Size(239, 29);
            this.navegaciónEntreVentanasToolStripMenuItem.Text = "Navegación entre ventanas";
            // 
            // admistrarCategoríasToolStripMenuItem
            // 
            this.admistrarCategoríasToolStripMenuItem.Name = "admistrarCategoríasToolStripMenuItem";
            this.admistrarCategoríasToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.admistrarCategoríasToolStripMenuItem.Text = "Admistrar Categoría";
            this.admistrarCategoríasToolStripMenuItem.Click += new System.EventHandler(this.admistrarCategoríasToolStripMenuItem_Click);
            // 
            // administrarMarcaToolStripMenuItem
            // 
            this.administrarMarcaToolStripMenuItem.Name = "administrarMarcaToolStripMenuItem";
            this.administrarMarcaToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.administrarMarcaToolStripMenuItem.Text = "Administrar Marca";
            this.administrarMarcaToolStripMenuItem.Click += new System.EventHandler(this.administrarMarcaToolStripMenuItem_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(341, 507);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 37);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eiminar Articulo";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblPrecioSeleccionado
            // 
            this.lblPrecioSeleccionado.AutoSize = true;
            this.lblPrecioSeleccionado.Location = new System.Drawing.Point(695, 141);
            this.lblPrecioSeleccionado.Name = "lblPrecioSeleccionado";
            this.lblPrecioSeleccionado.Size = new System.Drawing.Size(0, 16);
            this.lblPrecioSeleccionado.TabIndex = 11;
            // 
            // btnEliminarImagen
            // 
            this.btnEliminarImagen.Location = new System.Drawing.Point(872, 507);
            this.btnEliminarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarImagen.Name = "btnEliminarImagen";
            this.btnEliminarImagen.Size = new System.Drawing.Size(130, 37);
            this.btnEliminarImagen.TabIndex = 12;
            this.btnEliminarImagen.Text = "Eiminar Imagen";
            this.btnEliminarImagen.UseVisualStyleBackColor = true;
            this.btnEliminarImagen.Click += new System.EventHandler(this.btnEliminarImagen_Click);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(709, 507);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(130, 37);
            this.btnAgregarImagen.TabIndex = 13;
            this.btnAgregarImagen.Text = "Agregar Imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // btnListarUnaImagen
            // 
            this.btnListarUnaImagen.BackColor = System.Drawing.Color.Violet;
            this.btnListarUnaImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarUnaImagen.ForeColor = System.Drawing.Color.Navy;
            this.btnListarUnaImagen.Location = new System.Drawing.Point(701, 97);
            this.btnListarUnaImagen.Name = "btnListarUnaImagen";
            this.btnListarUnaImagen.Size = new System.Drawing.Size(125, 46);
            this.btnListarUnaImagen.TabIndex = 14;
            this.btnListarUnaImagen.Text = "Una Imagen";
            this.btnListarUnaImagen.UseVisualStyleBackColor = false;
            this.btnListarUnaImagen.Click += new System.EventHandler(this.btnListarUnaImagen_Click);
            // 
            // btnListarTodasImagenes
            // 
            this.btnListarTodasImagenes.BackColor = System.Drawing.Color.Violet;
            this.btnListarTodasImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTodasImagenes.ForeColor = System.Drawing.Color.Navy;
            this.btnListarTodasImagenes.Location = new System.Drawing.Point(858, 97);
            this.btnListarTodasImagenes.Name = "btnListarTodasImagenes";
            this.btnListarTodasImagenes.Size = new System.Drawing.Size(115, 46);
            this.btnListarTodasImagenes.TabIndex = 15;
            this.btnListarTodasImagenes.Text = "Todas las Imágenes";
            this.btnListarTodasImagenes.UseVisualStyleBackColor = false;
            this.btnListarTodasImagenes.Click += new System.EventHandler(this.btnListarTodasImagenes_Click);
            // 
            // lblListarPor
            // 
            this.lblListarPor.AutoSize = true;
            this.lblListarPor.BackColor = System.Drawing.Color.Turquoise;
            this.lblListarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarPor.Location = new System.Drawing.Point(764, 50);
            this.lblListarPor.Name = "lblListarPor";
            this.lblListarPor.Size = new System.Drawing.Size(160, 29);
            this.lblListarPor.TabIndex = 16;
            this.lblListarPor.Text = "LISTAR POR:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1353, 593);
            this.Controls.Add(this.lblListarPor);
            this.Controls.Add(this.btnListarTodasImagenes);
            this.Controls.Add(this.btnListarUnaImagen);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.btnEliminarImagen);
            this.Controls.Add(this.lblPrecioSeleccionado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnExitPrincipal);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú de Artículos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnExitPrincipal;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navegaciónEntreVentanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admistrarCategoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarMarcaToolStripMenuItem;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblPrecioSeleccionado;
        private System.Windows.Forms.Button btnEliminarImagen;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Button btnListarUnaImagen;
        private System.Windows.Forms.Button btnListarTodasImagenes;
        private System.Windows.Forms.Label lblListarPor;
    }
}

