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
    public partial class AgregarMarca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Session.Add("error", "Por Favor Iniciar Sesion como Administrador");
                Response.Redirect("error.aspx", false);
            }
            else {
                Persona user = new Persona();
                user = (Persona)Session["Usuario"];
                if (user.admin == false)
                {
                    Session.Add("error", "No posee permiso para Ingresar");
                    Response.Redirect("error.aspx", false);
                }

            }

        }

        protected void BtnAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcaDatos nuevo = new MarcaDatos();

            if (nuevo.Agregar(TBNombre.Text) == true)
            {       
            Response.Redirect("Administrador.aspx", false);
            }
            else
            {
                Session.Add("error", "Error al ingresar Articulo");
                Response.Redirect("error.aspx", false);
            }

}
    }
}