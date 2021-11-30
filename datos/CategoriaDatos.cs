using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace datos
{
    public class CategoriaDatos
    {
        public List<Categoria> listar()
            {
                List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            datos.SetearConsulta("select id, nombre from Categorias");
            datos.EjecutarLectura();
           
               try 
	        {	        
		    while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.ID = (int)datos.Lector["id"];
                    aux.Descripcion = (string)datos.Lector["nombre"];
                    lista.Add(aux);
                }
                
            return lista;
	        }
	        catch (Exception ex)
	        {

	        	throw ex;
	        }
            finally{
                datos.cerrarConexion();
            }
        }

        public bool Agregar(string nuevo)
        {
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.SetearConsulta("insert into Categorias (nombre) values (@nombre)");
                datos.setearParametro("@nombre", nuevo);
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

        public bool Modificar(Categoria nuevo)
        {

            if (nuevo.Descripcion == "")
            {
                return false;
            }

            try
            {
                AccesoDatos datos = new AccesoDatos();

                datos.SetearConsulta("update Categorias set nombre = @nombre where id = @id");
                datos.setearParametro("@nombre", nuevo.Descripcion);
                datos.setearParametro("@id", nuevo.ID);
                datos.EjecutarAccion();


                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

    }
}
