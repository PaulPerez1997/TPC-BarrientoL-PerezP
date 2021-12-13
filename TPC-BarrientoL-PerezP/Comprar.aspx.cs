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

            if(Session["Articulo"] != null)
            {
                art = (Articulo)Session["Articulo"];
                ArticuloEnVenta = art;

                user = DatosPersona.UsuarioXdni(art.dni);

            }
        }

        protected void BtnComprar_Click(object sender, EventArgs e)
        {
            Persona usuario = (Persona)Session["Usuario"];

            CompraRealizada compra = new CompraRealizada();
            compra.IDArticulo = ArticuloEnVenta.ID;
            compra.DniUsuario = usuario.dni;
            compra.Fecha = DateTime.Now;
            CompraRealizadaDatos compranueva = new CompraRealizadaDatos();
            if (compranueva.Agregar(compra))
            {
                
                Session.Add("exito","Enhorabuena Tu Compra se realizo con exito! ");
                Response.Redirect("ComprasRealizadas.aspx",false);
            }

        }
    }
}