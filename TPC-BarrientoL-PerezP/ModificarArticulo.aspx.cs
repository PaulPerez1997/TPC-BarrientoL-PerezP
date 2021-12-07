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
    

    public partial class Modificar : System.Web.UI.Page
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

            if (!IsPostBack) { 
            if(Request.QueryString["id"] != null)
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

                //Mdificar
                TBNombreModificar.Text = aux.Nombre;
                TBDescripcionModificar.Text = aux.Descripcion;
                TBPrecioModificar.Text = aux.Precio.ToString();
                TBPeso_kgModificar.Text = aux.Peso_kg.ToString();
                TBLargo_cmModificar.Text = aux.Largo_cm.ToString();
                TBImagenURLModificar.Text = aux.ImagenURL;
                TBStockModificar.Text = aux.Stock.ToString();


                CategoriaDatos Categoria = new CategoriaDatos();
                ddlCategoria.DataSource = Categoria.listar();
                ddlCategoria.DataTextField = "descripcion";
                ddlCategoria.DataValueField = "id";
                ddlCategoria.DataBind();

                MarcaDatos marca = new MarcaDatos();
                ddlMarca.DataSource = marca.listar();
                ddlMarca.DataTextField = "descripcion";
                ddlMarca.DataValueField = "id";
                ddlMarca.DataBind();
            }
            }
        }

        protected void BtnBuscarArticulo_Click(object sender, EventArgs e)
        {
           
            
        }


        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"]);
                Articulo nuevo = new Articulo();
                nuevo.ID = id;
                nuevo.Nombre = TBNombreModificar.Text;


                nuevo.Marca = new Marca();
                nuevo.Marca.ID = int.Parse(ddlMarca.SelectedItem.Value);

                nuevo.Categoria = new Categoria();
                nuevo.Categoria.ID = int.Parse(ddlCategoria.SelectedItem.Value);

                nuevo.Descripcion = TBDescripcionModificar.Text;
                nuevo.Precio = decimal.Parse(TBPrecioModificar.Text);
                nuevo.Peso_kg = decimal.Parse(TBPeso_kgModificar.Text);
                nuevo.Largo_cm = decimal.Parse(TBLargo_cmModificar.Text);
                nuevo.ImagenURL = TBImagenURLModificar.Text;
                nuevo.Stock = Int64.Parse(TBStockModificar.Text);

                ArticuloDatos datos = new ArticuloDatos();
                if (datos.modificar(nuevo) == true)
                {
                    Session.Add("exito","Articulo Modificado Correctamente");
                    Response.Redirect("exito.aspx",false);
                }
                else
                {
                    Session.Add("error", "Error al Modificar Articulo");
                    Response.Redirect("error.aspx", false);
                }


            }
        }
    }
}