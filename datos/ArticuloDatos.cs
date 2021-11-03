using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;


namespace datos
{
    public class ArticuloDatos
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select A.id,M.id, M.nombre, C.id, C.nombre, A.descripcion, A.precio, A.peso_kg, A.largo_cm, A.imagenURL, A.stock, A.Estado from Articulo A, Marcas M, Categorias C where A.idMarca = M.id and A.idCategoria = C.id");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.ID = (int)datos.Lector["id"];

                    if (!(datos.Lector["nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["nombre"];

                    if (!(datos.Lector["descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["descripcion"];

                    if (!(datos.Lector["imagenURL"] is DBNull))
                        aux.ImagenURL = (string)datos.Lector["imagenURL"];

                    if (!(datos.Lector["precio"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["precio"];

                    if (!(datos.Lector["peso_kg"] is DBNull))
                        aux.ImagenURL = (string)datos.Lector["peso_kg"];

                    if (!(datos.Lector["largo_cm"] is DBNull))
                        aux.ImagenURL = (string)datos.Lector["largo_cm"];

                    if (!(datos.Lector["stock"] is DBNull))
                        aux.ImagenURL = (string)datos.Lector["stock"];

                    if (!(datos.Lector["Estado"] is DBNull))
                        aux.ImagenURL = (string)datos.Lector["Estado"];

                    aux.Marca = new Marca();
                    aux.Marca.ID = datos.Lector.GetInt32(1);
                    aux.Marca.Descripcion = datos.Lector.GetString(2);

                    aux.Categoria = new Categoria();
                    aux.Categoria.ID = datos.Lector.GetInt32(3);
                    aux.Categoria.Descripcion = datos.Lector.GetString(4);


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



        public void Agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,ImagenUrl,Precio,IdMarca,IdCategoria) values (@Codigo,@Nombre,@Descripcion,@ImagenURL,@Precio,@IdMarca,@IdCategoria)");
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@ImagenURL", nuevo.ImagenURL);
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.setearParametro("@IdMarca", nuevo.Marca.ID);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.ID);
                datos.EjecutarAccion();
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

        public void modificar(Articulo Art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Desc, IdMarca = @idMarca, IdCategoria = @idCategoria, ImagenUrl = @img, Precio = @Precio where id = @id");              
                datos.setearParametro("@Nombre", Art.Nombre);
                datos.setearParametro("@Desc", Art.Descripcion);
                datos.setearParametro("@idMarca", Art.Marca.ID);
                datos.setearParametro("@idCategoria", Art.Categoria.ID);
                datos.setearParametro("@img", Art.ImagenURL);
                datos.setearParametro("@Precio", Art.Precio);
                datos.setearParametro("@id", Art.ID);
                datos.EjecutarAccion();
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
    }
}
