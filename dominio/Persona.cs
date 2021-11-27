using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Persona
    {
        
        public int dni { get; set; }
        public string nombres { get; set; }
        public string apellido { get; set; }
        public DateTime Nacimiento { get; set; }
        
        public string mail { get; set; }
        public string nombreusuario { get; set; }
        public string contraseña { get; set; }
        public string telefono { get; set; }

        public Boolean admin { get; set; }
        
    }
}
  
  