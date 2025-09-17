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
    public partial class AltaImagen : Form
    {
        private int idArticulo;

        public AltaImagen(int idArticulo)
        {
            InitializeComponent();
            this.idArticulo = idArticulo;
        }
        public AltaImagen()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                negocio.AgregarImagen(idArticulo, txtUrlImagen.Text);

                MessageBox.Show("Imagen agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la imagen: " + ex.Message);
            }
        }
    }
}
