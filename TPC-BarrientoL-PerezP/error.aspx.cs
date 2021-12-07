using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPC_BarrientoL_PerezP
{
    public partial class error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BtnIniciar.Visible = false;

            if (Session["error"] != null)
            {
                lblerror.Text = Session["error"].ToString();
            }
               
            if ( Session["errorCarrito"] != null){
                lblerror.Text = Session["errorCarrito"].ToString();
                BtnIniciar.Visible = true;
              
            }
        }

        protected void BtnIniciar_Click(object sender, EventArgs e)
        {
            Response.Redirect("IniciarSesion.aspx",false);
        }
    }
}