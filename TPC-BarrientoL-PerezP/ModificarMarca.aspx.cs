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
    public partial class ModificarMarca : System.Web.UI.Page
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
                MarcaDatos datos = new MarcaDatos();
                ddlMarca.DataSource = datos.listar();
                ddlMarca.DataTextField = "Descripcion";
                ddlMarca.DataValueField = "ID";
                ddlMarca.DataBind();
            }
        

        }

        protected void BtnAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcaDatos datos = new MarcaDatos();
            Marca nuevo = new Marca();
            nuevo.ID = int.Parse(ddlMarca.SelectedItem.Value);
            nuevo.Descripcion = TBNuevoNombre.Text;
            if (datos.Modificar(nuevo))
            {

                Response.Redirect("Administrador.aspx", false);
            }
            else
            {
                Session.Add("error", "Error al Modificar Marca");
                Response.Redirect("error.aspx", false);
            }



        }

      
    }
}