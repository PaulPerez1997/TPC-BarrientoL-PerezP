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
        public List<Persona> Listar()
        {
            List<Persona> lista = new List<Persona>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select dni,nombre,apellido,nacimiento,mail,nombreusuario,telefono from Usuario");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Persona aux = new Persona();
                    
                    aux.dni = (int)datos.Lector["dni"];

                    if (!(datos.Lector["nombre"] is DBNull))
                        aux.nombres = (string)datos.Lector["nombre"];

                    if (!(datos.Lector["apellido"] is DBNull))
                        aux.apellido = (string)datos.Lector["apellido"];

                    if (!(datos.Lector["nacimiento"] is DBNull))
                        aux.nacimiento = (DateTime)datos.Lector["nacimiento"];

                    if (!(datos.Lector["mail"] is DBNull))
                        aux.mail = (string)datos.Lector["mail"];

                    if (!(datos.Lector["nombreusuario"] is DBNull))
                        aux.nombreusuario = (string)datos.Lector["nombreusuario"];

                    if (!(datos.Lector["telefono"] is DBNull))
                        aux.telefono = (string)datos.Lector["telefono"];



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

        public Persona Buscar2(string User, string Contraseña)
        {
            
            AccesoDatos datos = new AccesoDatos();
            Persona aux = new Persona();
            datos.SetearConsulta("select dni,nombre,apellido,nacimiento,mail,nombreusuario,telefono from Usuario where @User = nombreusuario and @Contraseña = contraseña");
            datos.setearParametro("@User", User);
            datos.setearParametro("@Contraseña", Contraseña);
            datos.EjecutarLectura();
            
            while (datos.Lector.Read())
            {
                if (!(datos.Lector["dni"] is DBNull))
                    aux.dni = (int)datos.Lector["dni"];
                
                if (!(datos.Lector["nombre"] is DBNull))
                    aux.nombres = (string)datos.Lector["nombre"];
                
                if (!(datos.Lector["apellido"] is DBNull))
                    aux.apellido = (string)datos.Lector["apellido"];
               
                if (!(datos.Lector["nacimiento"] is DBNull))
                    aux.nacimiento = (DateTime)datos.Lector["nacimiento"];
               
                if (!(datos.Lector["mail"] is DBNull))
                    aux.mail = (string)datos.Lector["mail"];

                if (!(datos.Lector["nombreusuario"] is DBNull))
                    aux.nombreusuario = (string)datos.Lector["nombreusuario"];

                if (!(datos.Lector["telefono"] is DBNull))
                    aux.telefono = (string)datos.Lector["telefono"];
               
            }

           
            return aux; 
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
                datos.setearParametro("@Nacimiento", nuevo.nacimiento);
                datos.setearParametro("@Email", nuevo.mail);
                datos.setearParametro("@NombreUsuario", nuevo.nombreusuario);
                datos.setearParametro("@Contraseña", nuevo.contraseña);
                datos.setearParametro("@Telefono", nuevo.telefono);
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

        public bool Loguear(Persona persona)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select dni,nombreusuario,contraseña,tipousuario from Usuario where nombreusuario=@user and contraseña=@pass");
                datos.setearParametro("@user", persona.nombreusuario);
                datos.setearParametro("@pass", persona.contraseña);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    persona.dni = (int)datos.Lector["dni"];
                    persona.TipoUsuario = (int)(datos.Lector["tipousuario"])==1?TipoUser.admin :TipoUser.normal;
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

    }
}
