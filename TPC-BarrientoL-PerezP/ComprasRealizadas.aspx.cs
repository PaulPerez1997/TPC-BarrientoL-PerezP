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
    public partial class ComprasRealizadas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["exito"] != null)
            {
                lblexito.Text = Session["exito"].ToString();
            }

            Persona usuario = (Persona)Session["Usuario"];


            CompraRealizadaDatos compra = new CompraRealizadaDatos();
            GVCompras.DataSource = compra.lista(usuario.dni);
            GVCompras.DataBind();
        }

        protected void Cliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cliente.aspx", false);
        }
    }
}