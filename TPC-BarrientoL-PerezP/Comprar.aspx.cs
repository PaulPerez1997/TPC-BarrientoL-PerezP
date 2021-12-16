using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using datos;

namespace TPC_BarrientoL_PerezP
{
    public partial class Comprar : System.Web.UI.Page
    {
        public Articulo ArticuloEnVenta { get; set; } 

        public Persona user { get; set; }

        
        protected void Page_Load(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            PersonaDatos DatosPersona = new PersonaDatos();
           

            if (Session["Articulo"] != null)
            {
                art = (Articulo)Session["Articulo"];
                ArticuloEnVenta = art;
   
                user = DatosPersona.UsuarioXdni(art.dni);

            }
        }

        protected void BtnComprar_Click(object sender, EventArgs e)
        {
         

            int cantidad = int.Parse(TBCantidad.Text);
            decimal PrecioTotal = cantidad * ArticuloEnVenta.Precio;
           
            if ( cantidad > ArticuloEnVenta.Stock)
            {
                Session.Add("error", "Error al Comprar! La Cantidad Supera al Stock del Articulo ");
                Response.Redirect("error.aspx", false);
            }


            Persona Comprador = (Persona)Session["Usuario"];

            CompraRealizada compra = new CompraRealizada();
            compra.IDArticulo = ArticuloEnVenta.ID;
            compra.DniUsuario = Comprador.dni;
            compra.Fecha = DateTime.Now;
            CompraRealizadaDatos compranueva = new CompraRealizadaDatos();

            

        
            
            DetalleCompraDatos detalleDatos = new DetalleCompraDatos();
            DetalleCompras ticket = new DetalleCompras();
          

           

           
            if (compranueva.Agregar(compra))
            {
                int UltimoIdCompraRealizada = compranueva.UltimoIDCompraRealizadaxdni(Comprador.dni);

                ticket.IDCompraRealizada = UltimoIdCompraRealizada;
                ticket.IDArticulo = ArticuloEnVenta.ID;
                ticket.NombreArticulo = ArticuloEnVenta.Nombre;
                ticket.PrecioTotal = PrecioTotal;
                ticket.imagenURL = ArticuloEnVenta.ImagenURL;
                ticket.DNIComprador = Comprador.dni;
                ticket.NombreUsuarioComprador = Comprador.nombreusuario;
                ticket.NombreComprador = Comprador.nombres;
                ticket.ApellidoComprador = Comprador.apellido;
                ticket.TelefonoComprador = Comprador.telefono;
                ticket.MailComprador = Comprador.mail;
                ticket.DireccionAEnviar = TBDireccion.Text;
                ticket.DNIVendedor = user.dni;
                ticket.NombreUsuarioVendedor = user.nombreusuario;
                ticket.NombreVendedor = user.nombres;
                ticket.ApellidoVendedor = user.apellido;
                ticket.TelefonoVendedor = user.telefono;
                ticket.MailVendedor = user.mail;

                if( detalleDatos.agregar(ticket) == true)
                {

                    Session.Add("exito", "Enhorabuena Tu Compra se realizo con exito! ");
                    Response.Redirect("ComprasRealizadas.aspx", false);
                }
            

                
            }

        }
    }
}