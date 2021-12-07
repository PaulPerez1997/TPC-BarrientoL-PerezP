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
    public partial class Favoritos : System.Web.UI.Page
    {
        //public List<Articulo> ListaArticulos { get; set; }

        private List<Articulo> Carrito;

        public List<Articulo> ListaFavoritos { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["favoritos"] != null) {

                ListaFavoritos = (List<Articulo>)Session["favoritos"];

            }
            if (Request.QueryString["id"] != null)
            {
                Carrito = new List<Articulo>();
                int id = int.Parse(Request.QueryString["id"]);
                //Carrito = (List<Articulo>)Session["favoritos"]; 
                Carrito.Add(ListaFavoritos.Find(x => x.ID == id));
                if (Session["Usuario"] != null)
                {
                    Persona user = (Persona)Session["Usuario"];
                    CarritoDatos datos = new CarritoDatos();
                    if(datos.Agregar(user.dni,id) == true)
                    {
                        //Session.Add("Carrito", Carrito);
                        //Response.Redirect("Carrito.aspx", false);

                    }

                    

                   
                }
                else
                {
                    Session.Add("errorCarrito", "No se inicio sesion");
                    Response.Redirect("error.aspx", false);
                }
            }

        }

        //protected void BtnAgregaralCarrito_Click(object sender, EventArgs e)
        //{
        //    if (Session["Usuario"] == null)
        //    {

        //        Session.Add("errorCarrito", "Debes Iniciar Sesion para Agregar al Carrito! ");
        //        Response.Redirect("error.aspx", false);

        //    }
        //    else {

                
        //    }
            
          

        //}
    }
}