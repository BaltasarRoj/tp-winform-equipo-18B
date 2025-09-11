using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace CapaPresentacion
{
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();    
            ArticuloNegocio negocio = new ArticuloNegocio();    
            try
            {
                nuevo.codigoArticulo = txtCodigo.Text;
                nuevo.nombre = txtNombre.Text;
                nuevo.Marca = (Marca)cboMarca.SelectedItem;
                //guardar la categoria........
                nuevo.descripcion = txtDescripcion.Text;
                nuevo.precio =  decimal.Parse(txtPrecio.Text);

                negocio.agregarArticulo(nuevo);
                MessageBox.Show("agregado correctamente");
                Close();
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                //manejo de combobox categoria
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
    }
}
