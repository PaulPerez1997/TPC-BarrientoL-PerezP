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
    public partial class MasterPeassy : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {

            Response.Redirect("Buscar.aspx?nombre=" + TBBuscar.Text, false);
            

        }
    }
}