using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace datos
{
    public class CompraRealizadaDatos
    {

        public bool Agregar(CompraRealizada compra)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into CompraRealizada(Dniusuario,IdArticulo,Fecha)values(@DniUsuario,@IDArticulo,@Fecha)");
                datos.setearParametro("@IDArticulo", compra.IDArticulo);
                datos.setearParametro("@DniUsuario", compra.DniUsuario);
                datos.setearParametro("@Fecha", compra.Fecha);
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

        public List<CompraRealizada> lista(int dni)
        {
            List<CompraRealizada> lista = new List<CompraRealizada>();
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.SetearConsulta("select id,Dniusuario,IdArticulo,Fecha from CompraRealizada where Dniusuario = @dni");
                datos.setearParametro("@dni", dni);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    CompraRealizada compra = new CompraRealizada();

                    if (!(datos.Lector["id"] is DBNull))
                        compra.ID = (int)datos.Lector["id"];

                    if (!(datos.Lector["Dniusuario"] is DBNull))
                        compra.DniUsuario = (int)datos.Lector["Dniusuario"];

                    if (!(datos.Lector["IdArticulo"] is DBNull))
                        compra.IDArticulo = (int)datos.Lector["IdArticulo"];

                    if (!(datos.Lector["Fecha"] is DBNull))
                        compra.Fecha = (DateTime)datos.Lector["Fecha"];

                    lista.Add(compra);

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

        public int UltimoIDCompraRealizadaxdni(int dni)
        {
            int nuevoidcompra = new int();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select top 1 id from CompraRealizada where dniUsuario = @dni order by id desc ");
                datos.setearParametro("@dni", dni);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    if (!(datos.Lector["id"] is DBNull))
                        nuevoidcompra = (int)datos.Lector["id"];

                }
                return nuevoidcompra;
            }
            catch (Exception)
            {
                return -1;
                throw;
            }

        }

    }
}
