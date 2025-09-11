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

        private void btnAceptarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                categoria.Descripcion = txtNombreCategoria.Text;

                negocio.agregar(categoria);
                MessageBox.Show("La categoría fue agregada.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            Categoria seleccionado;
            seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

            frmAltaCategoria modificar = new frmAltaCategoria(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                Categoria seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                CategoriaNegocio negocio = new CategoriaNegocio();
                negocio.eliminar(seleccionado.Id);
                MessageBox.Show("categoria eliminada");
                cargar();
            }
        }
    }
}