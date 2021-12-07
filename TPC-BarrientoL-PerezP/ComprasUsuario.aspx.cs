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
    public partial class ComprasUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GVCompras.Visible = false;
        }

        protected void admin_Click(object sender, EventArgs e)
        {
            Response.Redirect("administrador.aspx",false);
        }

        protected void BtnCompras_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(TBDni.Text);
            CompraRealizadaDatos compra = new CompraRealizadaDatos();
            GVCompras.DataSource = compra.lista(dni);
            GVCompras.Visible = true;
            GVCompras.DataBind();
        }
    }
}