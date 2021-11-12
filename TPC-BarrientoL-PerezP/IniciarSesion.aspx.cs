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
            string name;
            PersonaDatos aux = new PersonaDatos();
            name = aux.Buscar(TBUser.Text, TBContraseña.Text);

            Welcome.Text = "Bienvenido " + name + " Te Deseamos buenas Compras!!!";
        }
    }
}