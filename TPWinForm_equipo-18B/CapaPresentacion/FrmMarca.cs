using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMarca : Form
    {
        public FrmMarca()
        {
            InitializeComponent();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            FrmAltaMarca marca = new FrmAltaMarca();
            marca.ShowDialog();
            cargar();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            Marca seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Querés eliminar la marca?",
                    "Eliminando",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2
                );

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Marca)dgvMarca.CurrentRow.DataBoundItem;

                    bool eliminada = marcaNegocio.eliminar(seleccionado.Id);

                    if (!eliminada)
                    {
                        MessageBox.Show(
                            "No se puede eliminar la marca porque está asociada a uno o más artículos.",
                            "Eliminación no permitida",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            "Marca eliminada correctamente.",
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

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            dgvMarca.DataSource = negocio.listar();
        }

     
        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            Marca seleccionado;
            seleccionado = (Marca)dgvMarca.CurrentRow.DataBoundItem;

            FrmAltaMarca modificar = new FrmAltaMarca(seleccionado);
            modificar.ShowDialog();
            cargar();
        }
    }
}
