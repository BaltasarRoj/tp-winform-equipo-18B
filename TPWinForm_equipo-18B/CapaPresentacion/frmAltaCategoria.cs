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

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            Categoria seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Querés eliminar la categoría?",
                    "Eliminando",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2
                );

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

                    bool eliminada = categoriaNegocio.eliminar(seleccionado.Id);

                    if (!eliminada)
                    {
                        MessageBox.Show(
                            "No se puede eliminar la categoría porque está asociada a uno o más artículos.",
                            "Eliminación no permitida",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(
                            "Categoría eliminada correctamente.",
                            "Eliminación exitosa",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        cargar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }


        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria marca = new frmCategoria();
            marca.ShowDialog();
            cargar();
        }

        private void btnModificarCategoria_Click_1(object sender, EventArgs e)
        {
            Categoria seleccionado;
            seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

            frmCategoria modificar = new frmCategoria(seleccionado);
            modificar.ShowDialog();
            cargar();
        }
    }
}