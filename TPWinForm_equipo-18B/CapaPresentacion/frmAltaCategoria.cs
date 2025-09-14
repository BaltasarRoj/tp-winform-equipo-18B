using Dominio;
using Negocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmAltaCategoria : Form
    {
        private Categoria categoria = null;
        public frmAltaCategoria()
        {
            InitializeComponent();
        }
        public frmAltaCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
        }

        

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaCategoria_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAltaCategoria_Load_1(object sender, EventArgs e)
        {
            cargar();
        }


        private void cargar()
        {
            try
            {
                CategoriaNegocio negocio = new CategoriaNegocio();
                dgvCategorias.DataSource = negocio.listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una categoria para modificar.");
                return;
            }

            var seleccionado = dgvCategorias.CurrentRow.DataBoundItem as Categoria;
            if (seleccionado == null)
            {
                MessageBox.Show("No se pudo obtener la categoria seleccionada.");
                return;
            }

            frmCategoria modificar = new frmCategoria(seleccionado);
            modificar.ShowDialog();
            cargar();
        }


        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            Categoria seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

            DialogResult confirmacion = MessageBox.Show(
                "¿Confirmar eliminacion de esta categoría?"
            );

            if (confirmacion == DialogResult.No)
                return;

            try
            {
                CategoriaNegocio negocio = new CategoriaNegocio();
                negocio.eliminar(seleccionado.Id);
                MessageBox.Show("categoria eliminada");
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria marca = new frmCategoria();
            marca.ShowDialog();
            cargar();
        }
    }
}