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
        public bool adm { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
         

            if (!IsPostBack) {

               
            }

            if ((Persona)Session["Usuario"] == null)
            {

                adm = false;
            }
            else
            {
                Persona aux = new Persona();
                aux = (Persona)Session["Usuario"];
                if( aux.admin == true)
                {
                    adm = true;
                }
                adm = false;
            }



        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {

            //Page.Validate();
            //if (!Page.IsValid);
            //return;

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

            
          
            if(adm == true)
            {
             nuevo.admin = true;
            }
            else
            {
                nuevo.admin = false;
            }

            datos.Agregar(nuevo);
            Session.Add("exito","Cliente Registrado con Exito! ");

            Response.Redirect("exito.aspx?nuevocliente=1", false);
            
        }

        
    }
}