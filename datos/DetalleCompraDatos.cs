using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace datos
{
    public class DetalleCompraDatos
    {
        
        public bool agregar(DetalleCompras detalle)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into DetalleCompra ( IDCompraRealizada,IDArticulo,NombreArticulo,PrecioTotal,imagenURL,DNIComprador,NombreUsuarioComprador,NombreComprador,ApellidoComprador,DireccionAEnviar,TelefonoComprador,MailComprador,DNIVendedor,NombreUsuarioVendedor,NombreVendedor,ApellidoVendedor,TelefonoVendedor,MailVendedor)values(@IDCompraRealizada,@IDArticulo,@NombreArticulo,@PrecioTotal,@imagenURL,@DNIComprador,@NombreUsuarioComprador,@NombreComprador,@ApellidoComprador,@DireccionAEnviar,@TelefonoComprador,@MailComprador,@DNIVendedor,@NombreUsuarioVendedor,@NombreVendedor,@ApellidoVendedor,@TelefonoVendedor,@MailVendedor)");

                datos.setearParametro("@IDCompraRealizada",detalle.IDCompraRealizada);
                //Articulo
                datos.setearParametro("@IDArticulo",detalle.IDArticulo);
                datos.setearParametro("@NombreArticulo",detalle.NombreArticulo);
                datos.setearParametro("@PrecioTotal",detalle.PrecioTotal);
                datos.setearParametro("@imagenURL",detalle.imagenURL);
                //Comprador
                datos.setearParametro("@DNIComprador",detalle.DNIComprador);
                datos.setearParametro("@NombreUsuarioComprador", detalle.NombreUsuarioComprador);
                datos.setearParametro("@NombreComprador", detalle.NombreComprador);
                datos.setearParametro("@ApellidoComprador", detalle.ApellidoComprador);
                datos.setearParametro("@DireccionAEnviar", detalle.DireccionAEnviar);
                datos.setearParametro("@TelefonoComprador", detalle.TelefonoComprador);
                datos.setearParametro("@MailComprador", detalle.MailComprador);
                //Vendedor 
                datos.setearParametro("@DNIVendedor", detalle.DNIVendedor);
                datos.setearParametro("@NombreUsuarioVendedor", detalle.NombreUsuarioVendedor);
                datos.setearParametro("@NombreVendedor", detalle.NombreVendedor);
                datos.setearParametro("@ApellidoVendedor", detalle.ApellidoVendedor);
                datos.setearParametro("@TelefonoVendedor", detalle.TelefonoVendedor);
                datos.setearParametro("@MailVendedor", detalle.MailVendedor);
                datos.EjecutarAccion();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }


        }

        public List<DetalleCompras> ListaVenta (int dni)
        {
            AccesoDatos datos = new AccesoDatos();
            List<DetalleCompras> ListaTicket = new List<DetalleCompras>();

            try
            {
               
                datos.SetearConsulta("select id,IDCompraRealizada,IDArticulo,NombreArticulo,PrecioTotal,imagenURL,DNIComprador,NombreUsuarioComprador,NombreComprador,ApellidoComprador,DireccionAEnviar,TelefonoComprador,MailComprador,DNIVendedor,NombreUsuarioVendedor,NombreVendedor,ApellidoVendedor,TelefonoVendedor,MailVendedor from DetalleCompra where DNIVendedor = @dni");
                datos.setearParametro("@dni",dni);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    DetalleCompras aux = new DetalleCompras();

                    if (!(datos.Lector["id"] is DBNull))
                        aux.id = (int)datos.Lector["id"];

                    if (!(datos.Lector["IDCompraRealizada"] is DBNull))
                        aux.IDCompraRealizada = (int)datos.Lector["IDCompraRealizada"];

                    if (!(datos.Lector["IDArticulo"] is DBNull))
                        aux.IDArticulo = (int)datos.Lector["IDArticulo"];

                    if (!(datos.Lector["NombreArticulo"] is DBNull))
                        aux.NombreArticulo = (string)datos.Lector["NombreArticulo"];

                    if (!(datos.Lector["PrecioTotal"] is DBNull))
                        aux.PrecioTotal = (decimal)datos.Lector["PrecioTotal"];

                    if (!(datos.Lector["imagenURL"] is DBNull))
                        aux.imagenURL = (string)datos.Lector["imagenURL"];

                    if (!(datos.Lector["DNIComprador"] is DBNull))
                        aux.DNIComprador = (int)datos.Lector["DNIComprador"];

                    if (!(datos.Lector["NombreUsuarioComprador"] is DBNull))
                        aux.NombreUsuarioComprador = (string)datos.Lector["NombreUsuarioComprador"];

                    if (!(datos.Lector["NombreComprador"] is DBNull))
                        aux.NombreComprador = (string)datos.Lector["NombreComprador"];

                    if (!(datos.Lector["ApellidoComprador"] is DBNull))
                        aux.ApellidoComprador = (string)datos.Lector["ApellidoComprador"];

                    if (!(datos.Lector["DireccionAEnviar"] is DBNull))
                        aux.DireccionAEnviar = (string)datos.Lector["DireccionAEnviar"];

                    if (!(datos.Lector["TelefonoComprador"] is DBNull))
                        aux.TelefonoComprador = (string)datos.Lector["TelefonoComprador"];

                    if (!(datos.Lector["MailComprador"] is DBNull))
                        aux.MailComprador = (string)datos.Lector["MailComprador"];

                    if (!(datos.Lector["DNIVendedor"] is DBNull))
                        aux.DNIVendedor = (int)datos.Lector["DNIVendedor"];

                    if (!(datos.Lector["NombreUsuarioVendedor"] is DBNull))
                        aux.NombreUsuarioVendedor = (string)datos.Lector["NombreUsuarioVendedor"];

                    if (!(datos.Lector["NombreVendedor"] is DBNull))
                        aux.NombreVendedor = (string)datos.Lector["NombreVendedor"];

                    if (!(datos.Lector["ApellidoVendedor"] is DBNull))
                        aux.ApellidoVendedor = (string)datos.Lector["ApellidoVendedor"];

                    if (!(datos.Lector["TelefonoVendedor"] is DBNull))
                        aux.TelefonoVendedor = (string)datos.Lector["TelefonoVendedor"];

                    if (!(datos.Lector["MailVendedor"] is DBNull))
                        aux.MailVendedor = (string)datos.Lector["MailVendedor"];
                    ListaTicket.Add(aux);
                }

                return ListaTicket;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<DetalleCompras> ListaCompra(int dni)
        {
            AccesoDatos datos = new AccesoDatos();
            List<DetalleCompras> ListaTicket = new List<DetalleCompras>();

            try
            {

                datos.SetearConsulta("select id,IDCompraRealizada,IDArticulo,NombreArticulo,PrecioTotal,imagenURL,DNIComprador,NombreUsuarioComprador,NombreComprador,ApellidoComprador,DireccionAEnviar,TelefonoComprador,MailComprador,DNIVendedor,NombreUsuarioVendedor,NombreVendedor,ApellidoVendedor,TelefonoVendedor,MailVendedor from DetalleCompra where DNIComprador = @dni");
                datos.setearParametro("@dni", dni);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    DetalleCompras aux = new DetalleCompras();

                    if (!(datos.Lector["id"] is DBNull))
                        aux.id = (int)datos.Lector["id"];

                    if (!(datos.Lector["IDCompraRealizada"] is DBNull))
                        aux.IDCompraRealizada = (int)datos.Lector["IDCompraRealizada"];

                    if (!(datos.Lector["IDArticulo"] is DBNull))
                        aux.IDArticulo = (int)datos.Lector["IDArticulo"];

                    if (!(datos.Lector["NombreArticulo"] is DBNull))
                        aux.NombreArticulo = (string)datos.Lector["NombreArticulo"];

                    if (!(datos.Lector["PrecioTotal"] is DBNull))
                        aux.PrecioTotal = (decimal)datos.Lector["PrecioTotal"];

                    if (!(datos.Lector["imagenURL"] is DBNull))
                        aux.imagenURL = (string)datos.Lector["imagenURL"];

                    if (!(datos.Lector["DNIComprador"] is DBNull))
                        aux.DNIComprador = (int)datos.Lector["DNIComprador"];

                    if (!(datos.Lector["NombreUsuarioComprador"] is DBNull))
                        aux.NombreUsuarioComprador = (string)datos.Lector["NombreUsuarioComprador"];

                    if (!(datos.Lector["NombreComprador"] is DBNull))
                        aux.NombreComprador = (string)datos.Lector["NombreComprador"];

                    if (!(datos.Lector["ApellidoComprador"] is DBNull))
                        aux.ApellidoComprador = (string)datos.Lector["ApellidoComprador"];

                    if (!(datos.Lector["DireccionAEnviar"] is DBNull))
                        aux.DireccionAEnviar = (string)datos.Lector["DireccionAEnviar"];

                    if (!(datos.Lector["TelefonoComprador"] is DBNull))
                        aux.TelefonoComprador = (string)datos.Lector["TelefonoComprador"];

                    if (!(datos.Lector["MailComprador"] is DBNull))
                        aux.MailComprador = (string)datos.Lector["MailComprador"];

                    if (!(datos.Lector["DNIVendedor"] is DBNull))
                        aux.DNIVendedor = (int)datos.Lector["DNIVendedor"];

                    if (!(datos.Lector["NombreUsuarioVendedor"] is DBNull))
                        aux.NombreUsuarioVendedor = (string)datos.Lector["NombreUsuarioVendedor"];

                    if (!(datos.Lector["NombreVendedor"] is DBNull))
                        aux.NombreVendedor = (string)datos.Lector["NombreVendedor"];

                    if (!(datos.Lector["ApellidoVendedor"] is DBNull))
                        aux.ApellidoVendedor = (string)datos.Lector["ApellidoVendedor"];

                    if (!(datos.Lector["TelefonoVendedor"] is DBNull))
                        aux.TelefonoVendedor = (string)datos.Lector["TelefonoVendedor"];

                    if (!(datos.Lector["MailVendedor"] is DBNull))
                        aux.MailVendedor = (string)datos.Lector["MailVendedor"];


                    ListaTicket.Add(aux);
                }

                return ListaTicket;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }
}
