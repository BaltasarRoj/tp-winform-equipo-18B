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
    public partial class FrmAltaMarca : Form
    {
        public FrmAltaMarca()
        {
            InitializeComponent();
        }

        private void btnAceptarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                marca.Descripcion = txtNombreMarca.Text;

                negocio.agregar(marca);
                MessageBox.Show("La marca fue agregada.");
                Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAltaMarca_Load(object sender, EventArgs e)
        {

        }
    }
}
