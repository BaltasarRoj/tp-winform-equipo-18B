using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCategoria : Form
    {
        private Categoria categoria;

        public frmCategoria()
        {
            InitializeComponent();
            Text = "Agregar Nueva categoría";
        }

        public frmCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar categoría";

            if (categoria != null)
                txtNombreCategoria.Text = categoria.Descripcion;
        }
        
        private void txtNombreCategoria_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAceptarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (categoria == null)
                {
                    categoria = new Categoria();
                }
                categoria.Descripcion = txtNombreCategoria.Text;

                if (string.IsNullOrWhiteSpace(categoria.Descripcion))
                {
                    MessageBox.Show("Inserte el nombre de la categoria");
                    return;
                }
                DialogResult confirmacion;
                if (categoria.Id != 0)
                    confirmacion = MessageBox.Show("¿Modificar categoría?");
                else
                    confirmacion = MessageBox.Show("¿Crear categoría?");

                if (confirmacion == DialogResult.No)
                    return;

                if (categoria.Id != 0)
                {
                    negocio.modificar(categoria);
                    Close();
                    MessageBox.Show("categoria modificada.");
                }
                else
                {
                    negocio.agregar(categoria);
                    Close();
                    MessageBox.Show("categoria agregada.");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
        }
    }
}
