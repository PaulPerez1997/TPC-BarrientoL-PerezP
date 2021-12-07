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
          

            try
            {
                user.nombreusuario = TBUser.Text;
                user.contraseña = TBContraseña.Text;



                if (aux.Login(user))
                {
                    if (user.admin == true)
                    {
                        Session.Add("Usuario", user);
                        Response.Redirect("Administrador.aspx", false);
                    }
                    else
                    {
                        Session.Add("Usuario", user);
                        Response.Redirect("Cliente.aspx?nombre="+user.nombreusuario, false);

                    }

                    

                }
                else
                {


                    Session.Add("error","Usuario o Contraseña Incorrecta! ");
                    Response.Redirect("error.aspx", false);
                }

            }
            catch (Exception ex )
            {


                Session.Add("error", ex.ToString());
                Response.Redirect("error.aspx", false);
            }







        }
    }
}