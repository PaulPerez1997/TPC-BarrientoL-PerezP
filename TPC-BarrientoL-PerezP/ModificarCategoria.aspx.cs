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
    public partial class ModificarCategoria : System.Web.UI.Page
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

            if (!IsPostBack)
            {
                CategoriaDatos datos = new CategoriaDatos();
                ddlCategoria.DataSource = datos.listar();
                ddlCategoria.DataTextField = "descripcion";
                ddlCategoria.DataValueField = "id";
                ddlCategoria.DataBind();

            }
        }

        protected void BtnModificarCategoria_Click(object sender, EventArgs e)
        {
           

            

            CategoriaDatos datos = new CategoriaDatos();
            Categoria nuevo = new Categoria();
            nuevo.ID = int.Parse(ddlCategoria.SelectedItem.Value);
            nuevo.Descripcion = TBNuevoNombre.Text;
            if (datos.Modificar(nuevo))
            {

                Response.Redirect("Administrador.aspx", false);
            }
            else
            {
                Session.Add("error", "Error al Modificar Categoria");
                Response.Redirect("error.aspx", false);
            }
        }
    }
}