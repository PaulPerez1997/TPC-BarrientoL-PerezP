using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace datos
{
    public class MarcaDatos
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            datos.SetearConsulta("select id, nombre from Marcas");
            datos.EjecutarLectura();

            try
            {
                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.ID = datos.Lector.GetInt32(0);
                    aux.Descripcion = datos.Lector.GetString(1);
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

        public bool Agregar(string nuevo)
        {
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.SetearConsulta("insert into Marcas (nombre) values (@nombre)");
                datos.setearParametro("@nombre",nuevo);
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
    }
}
