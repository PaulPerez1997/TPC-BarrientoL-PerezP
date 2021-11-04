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
        protected void Page_Load(object sender, EventArgs e)
        {

            ArticuloDatos lista = new ArticuloDatos();
            ListaArticulos = lista.Listar();
           /* GVArticulos.DataSource = lista.Listar();
            GVArticulos.DataBind();    */    
        }
    }
}