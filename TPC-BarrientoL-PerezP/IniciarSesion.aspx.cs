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
    public partial class Cuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }

        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {

            Persona user;
            PersonaDatos aux = new PersonaDatos();
            try
            {
                user = new Persona(TBUser.Text, TBContraseña.Text, false);
                if (aux.Loguear(user))
                {
                    Session.Add("persona", user);
                    Response.Redirect("Administrador.aspx",false);
                }
                else
                {
                    Session.Add("Error","Usuario y/o Contraseña incorrecto/s");
                    Response.Redirect("Error.aspx",false);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            



            


}
    }
}