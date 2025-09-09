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
    public partial class Articulos : Form
    {
        private List<Articulo> listaArticulo;
        public Articulos()
        {
            InitializeComponent();
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();
            
            dgvArticulos.DataSource = listaArticulo;
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            pbxArticulo.Load(listaArticulo[0].UrlImagen);
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
            catch (Exception ex)
            {
                pbxArticulo.Load("https://dynamoprojects.com/wp-content/uploads/2022/12/no-image.jpg");
            }  
          
        }

    }
    
}
