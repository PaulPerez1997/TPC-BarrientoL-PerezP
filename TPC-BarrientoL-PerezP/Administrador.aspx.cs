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
        public Persona user { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Session.Add("error","Por Favor Iniciar Sesion como Administrador");
                Response.Redirect("error.aspx",false);
            }
            else
            {
                user = (Persona)Session["usuario"];
                lblAdmin.Text = "Bienvenido admin " + user.nombreusuario;
            }

            
           
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarArticulo.aspx",false);
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarArticulo.aspx", false);
        }

        protected void BtnAgregarMarca_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarMarca.aspx", false);
        }

        protected void BtnModificarMarca_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarMarca.aspx",false);
        }

        protected void BtnAgregarCategoria_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarCategoria.aspx", false);
        }

        protected void BtnModificarCategoria_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarCategoria.aspx", false);
        }

        protected void BtnAgregarAdmin_Click(object sender, EventArgs e)
        {

            Session.Add("Usuario", user);
            Response.Redirect("Registrarse.aspx", false);


        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}