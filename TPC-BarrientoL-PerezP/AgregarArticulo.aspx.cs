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
    public partial class Agregar : System.Web.UI.Page
    {
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

            try
            {
                MarcaDatos marca = new MarcaDatos();         
                CategoriaDatos categoria = new CategoriaDatos();

                ddlMarca.DataSource = marca.listar();
                ddlMarca.DataTextField = "Descripcion";
                ddlMarca.DataValueField = "ID";
                ddlMarca.DataBind();

                ddlCategoria.DataSource = categoria.listar();
                ddlCategoria.DataTextField = "Descripcion";
                ddlCategoria.DataValueField = "ID";
                ddlCategoria.DataBind();

            }
            catch (Exception)
            {
                Session.Add("error.aspx","Error en Agregado de Articulo");
                throw;
            }

        }

        protected void BtnAgregarArticulo_Click(object sender, EventArgs e)
        {
           
            Articulo art = new Articulo();
            ArticuloDatos datos = new ArticuloDatos();
            
            art.Nombre = TBNombre.Text;
            art.Descripcion = TBDescripcion.Text;
            art.ImagenURL = TBImagenURL.Text;
            art.Peso_kg = decimal.Parse(TBPeso_KG.Text);
            art.Largo_cm = decimal.Parse(TBLargo_cm.Text);
            art.Precio = decimal.Parse(TBPrecio.Text);
            art.Stock = int.Parse(TBStock.Text);
            art.Estado = true;

            art.Marca = new Marca();
            art.Marca.ID = int.Parse(ddlMarca.SelectedItem.Value);
            art.Marca.Descripcion = ddlMarca.SelectedItem.Text;

            art.Categoria = new Categoria();
            art.Categoria.ID = int.Parse(ddlCategoria.SelectedItem.Value);
            art.Categoria.Descripcion = ddlCategoria.SelectedItem.Text;


            if (datos.Agregar(art) == true)
            {
                
                Response.Redirect("Administrador.aspx", false);
            }
            else
            {
                Session.Add("error", "Error al ingresar Articulo");
                Response.Redirect("error.aspx", false);
            }

          
            

              
            
           



           
        }
    }
}