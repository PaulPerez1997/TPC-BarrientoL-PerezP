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
    public partial class Administrador : System.Web.UI.Page
    {
        public string user { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            user = Session["user"].ToString();
            Lbladmin.Text = "Bienvenido admin " + user;
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Agregar.aspx",false);
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Modificar.aspx", false);
        }
    }
}