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
    public partial class MiPerfil : System.Web.UI.Page
    {
        Persona user = new Persona();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null) {

                user = (Persona)Session["Usuario"];

                lblBienvenida.Text = "Bienvenido Cliente " + user.nombreusuario;
            }
            else
            {
                Session.Add("errorCarrito", "No se inicio sesion");
                Response.Redirect("error.aspx", false);
            }


        }

        protected void BtnPerfil_Click(object sender, EventArgs e)
        {
            
            Session.Add("Usuario", user);
            Response.Redirect("Perfil.aspx",false);
        }

        protected void BtnFavorito_Click(object sender, EventArgs e)
        {
            Session.Add("Usuario", user);
            Response.Redirect("Favoritos.aspx", false);
        }

        protected void BtnMisCompras_Click(object sender, EventArgs e)
        {
            Session.Add("Usuario", user);
            Response.Redirect("ComprasRealizadas.aspx", false);
        }

        protected void BtnCarrito_Click(object sender, EventArgs e)
        {
            Session.Add("Usuario", user);
            Response.Redirect("Carrito.aspx", false);
        }
    }
}