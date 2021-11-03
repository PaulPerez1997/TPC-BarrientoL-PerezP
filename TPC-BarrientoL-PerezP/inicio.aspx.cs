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
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Articulo> ArticuloLista;
            ArticuloDatos lista = new ArticuloDatos();
            ArticuloLista = lista.Listar();
            GVArticulo.DataSource = ArticuloLista;

        }
    }
}