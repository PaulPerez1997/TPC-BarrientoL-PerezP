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
    public partial class EliminarArticulo : System.Web.UI.Page
    {
        public List<Articulo> Busqueda { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Session.Add("error", "Por Favor Iniciar Sesion como Administrador");
                Response.Redirect("error.aspx", false);
            }
            else
            {
                Persona user = new Persona();
                user = (Persona)Session["Usuario"];
                if (user.admin == false)
                {
                    Session.Add("error", "No posee permiso para Ingresar");
                    Response.Redirect("error.aspx", false);
                }

            }


            Articulo aux = new Articulo();
            ArticuloDatos datos = new ArticuloDatos();
            List<Articulo> lista = new List<Articulo>();
            lista = datos.Listar();
            Busqueda = datos.Buscar(TBBuscarArticulo.Text);

            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    aux = lista.Find(x => x.ID == id);
                    //Actual
                    TBNombre.Text = aux.Nombre;
                    TBMarca.Text = aux.Marca.Descripcion;
                    TBCategoria.Text = aux.Categoria.Descripcion;
                    TBDescripcion.Text = aux.Descripcion;
                    TBPrecio.Text = aux.Precio.ToString();
                    TBPeso_kg.Text = aux.Peso_kg.ToString();
                    TBLargo_cm.Text = aux.Largo_cm.ToString();
                    TBImagenURL.Text = aux.ImagenURL;
                    TBStock.Text = aux.Stock.ToString();

                    
                }
            }


        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"]);  
                ArticuloDatos datos = new ArticuloDatos();
                
                if (datos.Eliminar(id) == true)
                {
                    Session.Add("exito", "Articulo Eliminado Correctamente");
                    Response.Redirect("exito.aspx", false);
                }
                else
                {
                    Session.Add("error", "Error al Eliminar Articulo");
                    Response.Redirect("error.aspx", false);
                }


            }
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}