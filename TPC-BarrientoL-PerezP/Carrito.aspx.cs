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
    public partial class Carrito : System.Web.UI.Page
    {
      
        public List<Articulo> ListaCarrito { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Persona user = new Persona();
            if (Session["Usuario"] != null)
            {
                user = (Persona)Session["Usuario"];
                lblCarrito.Text = "Su Carrito " + user.nombreusuario;
            }
            else
            {
                Session.Add("errorCarrito","No se inicio sesion");
                Response.Redirect("error.aspx",false);
            }

            ArticuloDatos datos = new ArticuloDatos();
            List<Articulo> ListaArticulo = new List<Articulo>();
            ListaArticulo = datos.Listar();
            CarritoDatos carritodatos = new CarritoDatos();
            List<int> ListaIDArticulo = carritodatos.ListaIDArticulo(user.dni);
            List<Articulo> art = new List<Articulo>();
            


            foreach (var idart in ListaIDArticulo)
            {
               art.Add(ListaArticulo.Find(x => x.ID == idart));
                
            }
            ListaCarrito = art;



            if (Session["Carrito"] != null)
            {
                ListaCarrito = (List<Articulo>)Session["Carrito"];
                //int id = int.Parse(Request.QueryString["id"]);
                //ListaCarrito.Add(ListaArticulo.Find(x => x.ID == id));
               

            }

            if (Request.QueryString["id"] != null) {

                int id = int.Parse(Request.QueryString["id"]);
                Articulo arti = new Articulo();
                arti = ListaArticulo.Find( x => x.ID == id );

                Session.Add("Articulo",arti);
                Response.Redirect("Comprar.aspx",false);
            }

            if (Request.QueryString["Quitarid"] != null)
            {
                int id = int.Parse(Request.QueryString["Quitarid"]);

                if (carritodatos.Quitar(user.dni, id) == true) {
                    Response.Redirect("Carrito.aspx", false);
                }
                else
                {

                    Session.Add("errorCarrito", "Error al Quitar articulo");
                    Response.Redirect("error.aspx", false);
                }
           

                
            }

        }

        protected void BtnComprar_Click(object sender, EventArgs e)
        {

        }
    }
}