using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace datos
{
    public class PersonaDatos
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select a.id,Codigo,Nombre,M.id,M.Descripcion Marca,a.Descripcion,ImagenUrl,C.Id,C.Descripcion,A.Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where C.id = A.IdCategoria and M.Id = A.IdMarca");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    
                    aux.ID = (int)datos.Lector["id"];

                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];

                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenURL = (string)datos.Lector["ImagenUrl"];

                    if (!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.ID = datos.Lector.GetInt32(7);
                    aux.Categoria.Descripcion = datos.Lector.GetString(8);
                    
                    aux.Marca = new Marca();
                    aux.Marca.ID = datos.Lector.GetInt32(3);
                    aux.Marca.Descripcion = datos.Lector.GetString(4);

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

        public List<Persona> Buscar2(string User, string Contraseña)
        {
            List<Persona> lista = new List<Persona>();
            AccesoDatos datos = new AccesoDatos();
            datos.SetearConsulta("select dni,nombre,apellido,nacimiento,mail,nombreusuario,telefono,administrador from Usuario where @User = nombreusuario and @Contraseña = contraseña");
            datos.setearParametro("@User", User);
            datos.setearParametro("@Contraseña", Contraseña);
            datos.EjecutarLectura();
            Persona aux = new Persona();
            while (datos.Lector.Read())
            {
                

                if (!(datos.Lector["nombreusuario"] is DBNull))
                    aux.nombreusuario = (string)datos.Lector["nombreusuario"];

            }

            lista.Add(aux);
            return lista; 
        }

        public String Buscar(string Mail, string Contraseña)
        {
            string aux="";
            AccesoDatos datos = new AccesoDatos();
            datos.SetearConsulta("select nombreusuario from Usuario where mail = @Mail and contraseña = @Contraseña ");
            datos.setearParametro("@Mail", Mail);
            datos.setearParametro("@Contraseña", Contraseña);
            datos.EjecutarLectura();
            while(datos.Lector.Read())
            {
              
                if (!(datos.Lector["nombreusuario"] is DBNull))
                    aux = (string)datos.Lector["nombreusuario"];
               
            }
            datos.cerrarConexion();
            return aux;
           
        }



        public void Agregar(Persona nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into Usuario (dni,nombre,apellido,nacimiento,mail,nombreusuario,contraseña,telefono,administrador) values (@Dni,@Nombre,@Apellido,@Nacimiento,@Email,@NombreUsuario,@Contraseña,@Telefono,@Admin)");
                datos.setearParametro("@Dni", nuevo.dni);
                datos.setearParametro("@Nombre", nuevo.nombres);
                datos.setearParametro("@Apellido", nuevo.apellido);
                datos.setearParametro("@Nacimiento", nuevo.Nacimiento);
                datos.setearParametro("@Email", nuevo.mail);
                datos.setearParametro("@NombreUsuario", nuevo.nombreusuario);
                datos.setearParametro("@Contraseña", nuevo.contraseña);
                datos.setearParametro("@Telefono", nuevo.telefono);
                datos.setearParametro("@Admin", nuevo.admin);
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
                datos.setearParametro("@Nombre",Art.Nombre);
                datos.setearParametro("@Desc",Art.Descripcion);
                datos.setearParametro("@idMarca",Art.Marca.ID);
                datos.setearParametro("@idCategoria",Art.Categoria.ID);
                datos.setearParametro("@img",Art.ImagenURL);
                datos.setearParametro("@Precio",Art.Precio);
                datos.setearParametro("@id",Art.ID);
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
