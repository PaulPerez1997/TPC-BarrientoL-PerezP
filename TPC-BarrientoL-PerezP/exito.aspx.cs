using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPC_BarrientoL_PerezP
{
    public partial class exito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string nombre = Request.QueryString["exito"].ToString();
            lblexito.Text = "Usuario "+nombre+" Cargado Correctamente! ";

        }
    }
}