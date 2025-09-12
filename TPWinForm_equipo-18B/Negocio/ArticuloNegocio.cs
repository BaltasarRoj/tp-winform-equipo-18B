using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Negocio
{
    public class ArticuloNegocio
    {

        public List<Articulo> listar() { 
            
            List <Articulo>lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                datos.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre, M.Descripcion AS Marca, C.Descripcion AS Tipo, A.Descripcion, A.Precio, I.ImagenUrl AS Imagen,A.IdCategoria,A.IdMarca FROM ARTICULOS A LEFT JOIN IMAGENES I ON I.IdArticulo = A.Id JOIN MARCAS M ON M.Id = A.IdMarca JOIN CATEGORIAS C ON C.Id = A.IdCategoria");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Articulo aux = new Articulo();
                    aux.id = (int)datos.Lector["Id"];
                    aux.codigoArticulo = (string)datos.Lector["Codigo"];
                    aux.nombre = (string)datos.Lector["Nombre"];
                    
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.tipo = new Categoria();
                    aux.tipo.Id = (int)datos.Lector["IdCategoria"];
                    aux.tipo.Descripcion = (string)datos.Lector["Tipo"];
                    
                    aux.descripcion = (string)datos.Lector["Descripcion"];
                    aux.precio = (decimal)datos.Lector["Precio"];
                    aux.UrlImagen = (string)datos.Lector["Imagen"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                datos.cerrarConexion();    
            }

        
        }
        
        public void agregarArticulo(Articulo nuevo) {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,Precio) values (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@Precio)");
                datos.setearParametro("@Codigo", nuevo.codigoArticulo);
                datos.setearParametro("@Nombre", nuevo.nombre);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.tipo.Id);
                datos.setearParametro("@Descripcion", nuevo.descripcion);
                datos.setearParametro("@Precio", nuevo.precio);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {
                datos.cerrarConexion();
            }



        }

        public void modificarArticulo(Articulo modificar) {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @cod, Nombre = @nom, IdMarca = @idmarca, IdCategoria = @idcategoria, Descripcion = @desc, Precio = @precio where Id = @Id");
                datos.setearParametro("@cod", modificar.codigoArticulo);
                datos.setearParametro("@nom", modificar.nombre);
                datos.setearParametro("@idmarca", modificar.Marca.Id);
                datos.setearParametro("@idcategoria", modificar.tipo.Id);
                datos.setearParametro("@desc", modificar.descripcion);
                datos.setearParametro("@precio", modificar.precio);
                datos.setearParametro("@Id", modificar.id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        
        
        }


        public void EliminarArticulo(Articulo eliminar) { 
        
        }


    }
}
