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
    public partial class Buscar : System.Web.UI.Page
    {
        public List<Articulo> Busqueda { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            string NombreArticulo = Request.QueryString["nombre"].ToString();
            lblbusqueda.Text = NombreArticulo;
            ArticuloDatos lista = new ArticuloDatos();
            Busqueda = lista.Buscar(NombreArticulo);
            //Busqueda = lista.Listar();


        }
    }
}
       
       