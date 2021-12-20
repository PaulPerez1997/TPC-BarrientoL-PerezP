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

        public List<DetalleCompras> ListaDetalles { get; set; }

        public bool listar { get; set; }

        Persona user = new Persona();
        protected void Page_Load(object sender, EventArgs e)
        {
          

            if (Session["Usuario"] != null)
            {
                user = (Persona)Session["Usuario"];
            }
            else
            {
                Session.Add("error", "No se inicio sesion");
                Response.Redirect("error.aspx", false);
            }

            
        }

        protected void admin_Click(object sender, EventArgs e)
        {
            Response.Redirect("administrador.aspx",false);
        }

        protected void BtnCompras_Click(object sender, EventArgs e)
        {
            if (TBDni.Text != "")
            {
                int dni = int.Parse(TBDni.Text);

                listar = true;

                DetalleCompras ticket = new DetalleCompras();
                DetalleCompraDatos datos = new DetalleCompraDatos();
                ListaDetalles = datos.ListaCompra(dni);
            }
            
  
        }
    }
}