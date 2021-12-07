using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace datos
{
    public class CarritoDatos
    {
        public bool Agregar(int dni, int idarticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into Compra(Dniusuario,IdArticulo)values(@DniUsuario,@IDArticulo)");     
                datos.setearParametro("@IDArticulo", idarticulo);
                datos.setearParametro("@DniUsuario", dni);
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


        public List<int> ListaIDArticulo(int dni)
        {
            List<int> lista = new List<int>();
            AccesoDatos datos = new AccesoDatos();
            int aux = new int();


            try
            {
                datos.SetearConsulta("select IdArticulo from Compra where Dniusuario = @dni");
                datos.setearParametro("@dni",dni);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                  

                    if (!(datos.Lector["IdArticulo"] is DBNull))
                        aux = (int)datos.Lector["IdArticulo"];

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

        public bool Quitar(int dni, int IDArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("delete from Compra where Dniusuario = @dni and IdArticulo = @id");
                datos.setearParametro("@dni", dni);
                datos.setearParametro("@id", IDArticulo);
                datos.EjecutarAccion();
                return true;
             }
            catch (Exception ex)
            {
                return false;
                throw ex ;
            }
          

        }

    }
}
