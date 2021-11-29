using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace TPC_BarrientoL_PerezP
{
    public partial class AgregarMarca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcaDatos nuevo = new MarcaDatos();

            if (nuevo.Agregar(TBNombre.Text) == true)
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