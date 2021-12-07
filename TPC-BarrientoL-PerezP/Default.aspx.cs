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
    public partial class inicio : System.Web.UI.Page
    {

        public List<Articulo> ListaArticulos { get; set; }

        private List<Articulo> favoritos;
        protected void Page_Load(object sender, EventArgs e)
        {

            ArticuloDatos lista = new ArticuloDatos();
            ListaArticulos = lista.Listar();

            if (!IsPostBack)
            {
                
                
                Session.Add("ListaArticulos", ListaArticulos);
                if (Session["favoritos"] == null) { 
                    favoritos = new List<Articulo>();
                    Session.Add("favoritos", favoritos);
                }
            }

            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"]);
                favoritos = (List<Articulo>)Session["favoritos"];
                ListaArticulos = (List<Articulo>)Session["ListaArticulos"];
                favoritos.Add(ListaArticulos.Find(x => x.ID == id));
                Session.Add("favoritos", favoritos);
            }

        }
    }
}