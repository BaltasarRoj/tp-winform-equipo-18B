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
        private Marca marca = null;
        public FrmAltaMarca()
        {
            InitializeComponent();
        }

        
        public FrmAltaMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar una Marca";
        }

        
        private void btnAceptarMarca_Click(object sender, EventArgs e)
        {
            
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                if (marca == null)
                {
                    marca = new Marca();
                }
                marca.Descripcion = txtNombreMarca.Text;

                if (marca.Id != 0)
                {
                    negocio.modificar(marca);
                    MessageBox.Show("La marca fue modificada.");
                }
                else
                {
                    negocio.agregar(marca);
                    MessageBox.Show("La marca fue agregada.");
                }
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
            if(marca != null)
            {
                txtNombreMarca.Text = marca.Descripcion;
            }
        }

        private void txtNombreMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras y Backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquea la tecla
            }
        }
    }
}
