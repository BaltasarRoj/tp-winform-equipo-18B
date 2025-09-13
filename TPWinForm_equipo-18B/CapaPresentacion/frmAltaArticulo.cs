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
using System.Security.AccessControl;

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
                if (!validarArticulo())
                    return;

                if (ExisteCodigo(txtCodigo.Text)) {
                    MessageBox.Show("el codigo ingresado ya existe. Ingrese otro codigo");
                    return;
                }

                if (articulo == null)
                    articulo = new Articulo();

                articulo.codigoArticulo = txtCodigo.Text;
                articulo.nombre = txtNombre.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.tipo = (Categoria)cboCategoria.SelectedItem;
                articulo.descripcion = txtDescripcion.Text;
                articulo.precio = decimal.Parse(txtPrecio.Text);
                articulo.UrlImagen = txtUrlImagen.Text;


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

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

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
                    txtUrlImagen.Text = articulo.UrlImagen;
                    cargarImagen(articulo.UrlImagen);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        {

            try
            {
                pboArticulosAlta.Load(imagen);
            }
            catch (Exception)
            {
                pboArticulosAlta.Load("https://dynamoprojects.com/wp-content/uploads/2022/12/no-image.jpg");
            }

        }


        /* private bool SoloNumeros( string cadena) {
             foreach (char caracter in cadena) {
                 if (!(char.IsNumber(caracter)))
                     return false;
             }

             return true;
         }*/

        private bool validarArticulo() {

            if (string.IsNullOrEmpty(txtCodigo.Text)) {
                MessageBox.Show("El codigo de articulo no puede estar vacio..");
                return false;
            }

            if (cboMarca.SelectedIndex < 0) {
                MessageBox.Show("seleccione la marca del articulo...");
                return false;
            }

            if (cboCategoria.SelectedIndex < 0) {
                MessageBox.Show("seleccione el tipo de categoria del articulo...");
                return false;
            }


            if (string.IsNullOrEmpty(txtNombre.Text)) {
                MessageBox.Show("El Nombre de articulo no puede estar vacio..");
                return false;
            }

            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Debe ingresar un precio.");
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio)) {
                MessageBox.Show("El precio debe contener solo Numeros..");
                return false;
            }

            if (precio < 0) {
                MessageBox.Show("El precio no puede ser negativo..");
                return false;
            }

            if (string.IsNullOrEmpty(txtUrlImagen.Text))
            {
                MessageBox.Show("Este articulo requiere una imagen...");
                return false;
            }



            return true;
        }



        private bool ExisteCodigo (string codigo) {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Codigo from ARTICULOS where Codigo = @codigo");
                datos.setearParametro("@codigo", codigo);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                    return true;
                
                else 
                    return false;

            }
            catch (Exception)
            {
                throw;
                
            }
            finally {
                datos.cerrarConexion();
            }

            
        }
    }
}
