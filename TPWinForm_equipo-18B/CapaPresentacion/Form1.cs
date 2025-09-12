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
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulo;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }


        private void cargar() {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulo = negocio.listar();

                dgvArticulos.DataSource = listaArticulo;
                dgvArticulos.Columns["UrlImagen"].Visible = false;
                pbxArticulo.Load(listaArticulo[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
           Articulo seleccionado =  (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);

        }

        private void cargarImagen(string imagen) {

            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception )
            {
                pbxArticulo.Load("https://dynamoprojects.com/wp-content/uploads/2022/12/no-image.jpg");
            }  
          
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            
            frmAltaArticulo modificar= new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();

        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbxArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnEdiCategoria_Click(object sender, EventArgs e)
        {
            frmAltaCategoria ventana = new frmAltaCategoria();
            ventana.ShowDialog();
        }

        private void btnExitPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
