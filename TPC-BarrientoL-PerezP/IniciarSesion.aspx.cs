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
           
            Persona user = new Persona();
            PersonaDatos aux = new PersonaDatos();
            string nombreusuario;
            //name = aux.Buscar(TBUser.Text, TBContraseña.Text);
            
            user = aux.Buscar2(TBUser.Text, TBContraseña.Text);

            nombreusuario = user.nombreusuario;
            
            if (user.admin == true){
                Session.Add("user", user.nombreusuario);
                Response.Redirect("Administrador.aspx", false);
            }
            else
            {
                Session.Add("user", user.nombreusuario);
                Response.Redirect("Default.aspx", false);
                
            }



            


}
    }
}