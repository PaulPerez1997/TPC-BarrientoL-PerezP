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
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
               
                TBClick.Text = "pageload";
            }

        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            
            Persona nuevo = new Persona();
            PersonaDatos datos = new PersonaDatos();


            nuevo.dni = int.Parse(TBDni.Text);
            nuevo.nombres = TBNombre.Text;
            nuevo.apellido = TBApellido.Text;
            nuevo.Nacimiento = DateTime.Parse(TBNacimiento.Text);
            nuevo.mail = TBMail.Text;
            nuevo.nombreusuario = TBNombreUsuario.Text;
            nuevo.contraseña = TBContraseña.Text;
            nuevo.telefono = TBTelefono.Text;
            if (TBAdmin.Text == "admin")
            {
                nuevo.admin = true;
            }
            else
            {
                nuevo.admin = false;
            }

            datos.Agregar(nuevo);

        }

        protected void BtnAgregarClick_Click(object sender, EventArgs e)
        {
            TBClick.Text = "eventoclick";
        }
    }
}