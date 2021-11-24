using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public enum TipoUser
    {
        admin=1,
        normal=2,
    }
    public class Persona
    {
        public int dni { get; set; }
        public string nombres { get; set; }
        public string apellido { get; set; }
        public DateTime nacimiento { get; set; }   
        public string mail { get; set; }
        public string nombreusuario { get; set; }
        public string contraseña { get; set; }
        public string telefono { get; set; }
        public TipoUser TipoUsuario { get; set; }

        public Persona(string user, string pass, bool admin)
        {
            nombreusuario= user;
            contraseña = pass;
            TipoUsuario = admin ? TipoUser.admin : TipoUser.normal;
        }

        public Persona()
        {

        }

    }
    
}
  
  