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
                datos.SetearConsulta("select A.id,a.nombre,M.id, M.nombre, C.id, C.nombre, A.descripcion, A.precio, A.peso_kg, A.largo_cm, A.imagenURL, A.stock, A.Estado,a.dniUsuario from Articulo A, Marcas M, Categorias C where A.idMarca = M.id and A.idCategoria = C.id");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                  
                if (!(datos.Lector["id"] is DBNull))
                 aux.ID = (int)datos.Lector["id"];

                    if (!(datos.Lector["dniUsuario"] is DBNull))
                        aux.dni = (int)datos.Lector["dniUsuario"];

                    if (!(datos.Lector["Estado"] is DBNull))
                        aux.Estado = (bool)datos.Lector["Estado"];

                    if (!(datos.Lector["nombre"] is DBNull))
                    aux.Nombre = (string)datos.Lector["nombre"];

                if (!(datos.Lector["descripcion"] is DBNull))
                    aux.Descripcion = (string)datos.Lector["descripcion"];

                if (!(datos.Lector["imagenURL"] is DBNull))
                    aux.ImagenURL = (string)datos.Lector["imagenURL"];

                if (!(datos.Lector["precio"] is DBNull))
                    aux.Precio = (decimal)datos.Lector["precio"];

                if (!(datos.Lector["peso_kg"] is DBNull))
                    aux.Peso_kg = (decimal)datos.Lector["peso_kg"];

                if (!(datos.Lector["largo_cm"] is DBNull))
                    aux.Largo_cm = (decimal)datos.Lector["largo_cm"];

                    if (!(datos.Lector["stock"] is DBNull))
                        aux.Stock = datos.Lector.GetInt64(11);


                aux.Marca = new Marca();
                aux.Marca.ID = datos.Lector.GetInt32(2);
                aux.Marca.Descripcion = datos.Lector.GetString(3);

                aux.Categoria = new Categoria();
                aux.Categoria.ID = datos.Lector.GetInt32(4);
                aux.Categoria.Descripcion = datos.Lector.GetString(5);

                    if (aux.Estado == true)
                    {
                        lista.Add(aux);
                    }
                
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

        public List<Articulo> Buscar(string Buscar)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
          
            try
            {
                string like = Buscar + "%";
                datos.SetearConsulta("select A.nombre, M.nombre, C.nombre, descripcion, imagenURL, precio, peso_kg, largo_cm, stock, A.id from Articulo A, Categorias C, Marcas M where A.nombre like @Nombre and A.idMarca = M.id and A.idCategoria = C.id");
              
                datos.setearParametro("@Nombre", like);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    if (!(datos.Lector["id"] is DBNull))
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
                        aux.Peso_kg = (decimal)datos.Lector["peso_kg"];

                    if (!(datos.Lector["largo_cm"] is DBNull))
                        aux.Largo_cm = (decimal)datos.Lector["largo_cm"];

                    if (!(datos.Lector["stock"] is DBNull))
                        aux.Stock = datos.Lector.GetInt64(8);


                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = datos.Lector.GetString(1);

                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = datos.Lector.GetString(2);

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
    



        public bool Agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into Articulo(nombre,dniUsuario,idMarca,idCategoria,descripcion,precio,peso_kg,largo_cm,imagenURL,stock,Estado)values(@Nombre,@dni,@idMarca,@idCategoria,@Descripcion,@Precio,@Peso,@Largo,@ImagenURL,@Stock,@Estado)");
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@dni", nuevo.dni);
                datos.setearParametro("@idMarca",nuevo.Marca.ID);
                datos.setearParametro("@idCategoria",nuevo.Categoria.ID);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.setearParametro("@Peso", nuevo.Peso_kg);
                datos.setearParametro("@Largo",nuevo.Largo_cm);
                datos.setearParametro("@ImagenURL", nuevo.ImagenURL);
                datos.setearParametro("@Stock",nuevo.Stock);
                datos.setearParametro("@Estado",nuevo.Estado);
                datos.EjecutarAccion();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
                
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public bool modificar(Articulo Art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("update Articulo set nombre=@Nombre, idMarca = @idMarca,idCategoria = @idCategoria,descripcion = @Desc,precio = @Precio,peso_kg = @Peso,largo_cm = @Largo,imagenURL = @img,stock = @Stock where id = @id");              
                datos.setearParametro("@Nombre", Art.Nombre);
                datos.setearParametro("@Desc", Art.Descripcion);
                datos.setearParametro("@idMarca", Art.Marca.ID);
                datos.setearParametro("@idCategoria", Art.Categoria.ID);
                datos.setearParametro("@img", Art.ImagenURL);
                datos.setearParametro("@Precio", Art.Precio);
                datos.setearParametro("@Largo", Art.Largo_cm);
                datos.setearParametro("@Peso", Art.Peso_kg);
                datos.setearParametro("@Stock", Art.Stock);
                datos.setearParametro("@id", Art.ID);
                datos.EjecutarAccion();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {

                datos.cerrarConexion();
            }
        }

        public bool Eliminar (int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update Articulo set Estado = 0 where id = @id");
                datos.setearParametro("@id",id);
                datos.EjecutarAccion();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
          
        }

        public int UltimoIDArtxdni(int dni)
        {
            int nuevoidart = new int();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select top 1 id from Articulo where dniUsuario = @dni order by id desc ");
                datos.setearParametro("@dni",dni);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    if (!(datos.Lector["id"] is DBNull))
                        nuevoidart = (int)datos.Lector["id"];

                }
                return nuevoidart;
            }
            catch (Exception)
            {
                return -1;
                throw;
            }

        }


    }
}
