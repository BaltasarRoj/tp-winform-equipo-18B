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
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Articulo nuevo = new Articulo();    
            ArticuloNegocio negocio = new ArticuloNegocio();    
            try
            {
                 if (articulo == null)
                    articulo = new Articulo();

                articulo.codigoArticulo = txtCodigo.Text;
                articulo.nombre = txtNombre.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.tipo = (Categoria)cboCategoria.SelectedItem;
                articulo.descripcion = txtDescripcion.Text;
                articulo.precio =  decimal.Parse(txtPrecio.Text);

                if (articulo.id != 0)
                {

                    negocio.modificarArticulo(articulo);
                    MessageBox.Show("Modificado correctamente");

                }
                else { 
                
                    negocio.agregarArticulo(articulo);
                    MessageBox.Show("agregado correctamente");

                }


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
            CategoriaNegocio categoriaNegocio= new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";


                if (articulo != null) {
                    txtCodigo.Text = articulo.codigoArticulo;
                    txtNombre.Text = articulo.nombre;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.tipo.Id;
                    txtDescripcion.Text = articulo.descripcion;
                    txtPrecio.Text = articulo.precio.ToString();

                }
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
