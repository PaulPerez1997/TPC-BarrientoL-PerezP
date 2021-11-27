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
        
           



        

        public bool Login(Persona User)
        {
            
            AccesoDatos datos = new AccesoDatos();
            try
            {
            
          
            datos.SetearConsulta("select dni,nombre,apellido,nacimiento,mail,nombreusuario,telefono,administrador from Usuario where @User = nombreusuario and @Contraseña = contraseña");
            datos.setearParametro("@User", User.nombreusuario);
            datos.setearParametro("@Contraseña", User.contraseña);
            datos.EjecutarLectura();
            
            while (datos.Lector.Read())
            {
                if (!(datos.Lector["dni"] is DBNull))
                        User.dni = (int)datos.Lector["dni"];
                
                if (!(datos.Lector["nombre"] is DBNull))
                        User.nombres = (string)datos.Lector["nombre"];
                
                if (!(datos.Lector["apellido"] is DBNull))
                        User.apellido = (string)datos.Lector["apellido"];
               
                if (!(datos.Lector["nacimiento"] is DBNull))
                        User.Nacimiento = (DateTime)datos.Lector["nacimiento"];
               
                if (!(datos.Lector["mail"] is DBNull))
                        User.mail = (string)datos.Lector["mail"];

                if (!(datos.Lector["nombreusuario"] is DBNull))
                        User.nombreusuario = (string)datos.Lector["nombreusuario"];

                if (!(datos.Lector["telefono"] is DBNull))
                        User.telefono = (string)datos.Lector["telefono"];
                
                if (!(datos.Lector["administrador"] is DBNull))
                        User.admin = (bool)datos.Lector["administrador"];
                   
                    return true;

                }

            return false;
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
