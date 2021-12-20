using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace datos
{
    public class EnVentaDatos
    {

        public bool Agregar(EnVenta aux)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("insert into EnVenta(Dniusuario,IdArticulo,Estado)values(@dni,@idarticulo,1)");
                datos.setearParametro("@dni",aux.dniUsuario);
                datos.setearParametro("@idarticulo",aux.idArticulo);
                datos.EjecutarAccion();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }


        public List<int> ListaIDArtEnVenta(int dni)
        {
            List<int> Lista = new List<int>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //datos.SetearConsulta("select IdArticulo from EnVenta where Dniusuario = @dni");
                datos.SetearConsulta("select id from Articulo where dniUsuario = @dni and Estado = 1");
                datos.setearParametro("@dni", dni);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    int aux = new int();

                    if (!(datos.Lector["id"] is DBNull))
                        aux = (int)datos.Lector["id"];


                    Lista.Add(aux);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }
    }






    
}
