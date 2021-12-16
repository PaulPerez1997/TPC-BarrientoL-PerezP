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
    public partial class exito : System.Web.UI.Page
    {
       // Persona usuario;
        
        protected void Page_Load(object sender, EventArgs e)
        {

            string nombre = Session["exito"].ToString();
            lblexito.Text = nombre;

            //int registro = int.Parse(Request.QueryString["nuevocliente"]);

        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            //if (Session["Usuario"] != null) {
            //    usuario = (Persona)Session["Usuario"];
            //    if(usuario.admin == true)
            //    {
            //        Response.Redirect("Administrador.aspx", false);
            //    }
                
            //}
            
                Response.Redirect("Default.aspx", false);
            

        }
    }
}