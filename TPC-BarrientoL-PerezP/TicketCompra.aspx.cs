using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;
using dominio;

namespace TPC_BarrientoL_PerezP
{
    public partial class DetalleCompra : System.Web.UI.Page
    {

        public List<DetalleCompras> ListaDetalles { get; set; }

       
        protected void Page_Load(object sender, EventArgs e)
        {
          Persona user = new Persona();

            if (Session["Usuario"] != null)
            {
               user = (Persona)Session["Usuario"];  
            }
            else
            {
                Session.Add("error", "No se inicio sesion");
                Response.Redirect("error.aspx", false);
            }

            DetalleCompras ticket = new DetalleCompras();
            DetalleCompraDatos datos = new DetalleCompraDatos();

            string aux = Request.QueryString["nombre"];

            if( aux == "venta")
            {
                ListaDetalles = datos.ListaVenta(user.dni);
            }

            if (aux == "compra")
            {
                ListaDetalles = datos.ListaCompra(user.dni);
            }


         



        }
    }
}