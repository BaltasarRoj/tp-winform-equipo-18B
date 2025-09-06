using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int idArticulo { get; set; }
        public string nombre { get; set; }
        public Marca marca { get; set; }
        public Categoria categoria { get; set; }
        public string descripcion { get; set; }

        //List < imagen>
        private float precio;
        public float Precio
        {
            get { return precio; }
            set
            {
                if (value <= 0)
                    precio = value;

                else precio = -2;
            }

        }
    }
}

