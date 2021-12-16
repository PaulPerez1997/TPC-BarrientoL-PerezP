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

   
    public partial class MisArticulos : System.Web.UI.Page
    {
       
        public List<Articulo> MisArt { get; set; }

    


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Session.Add("error","No se Inicio Sesion");
                Response.Redirect("error.aspx",false);
            }

       

            Persona user = (Persona)Session["Usuario"];
            List<Articulo> aux = new List<Articulo>();
            EnVentaDatos datosEnVenta =  new EnVentaDatos();
            ArticuloDatos datos = new ArticuloDatos();
            List<Articulo> ListaArticulos = new List<Articulo>();
            List<int> ListaIdArticulo = new List<int>();



            ListaIdArticulo = datosEnVenta.ListaIDArtEnVenta(user.dni);
            ListaArticulos = datos.Listar();

            

            foreach (var id in ListaIdArticulo)
            {
              aux.Add(ListaArticulos.Find(x => x.ID == id));           
            }

            if ( aux != null)
            {
                MisArt = aux;
            }
        }
    }
}