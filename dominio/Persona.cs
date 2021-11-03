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
       // public DateTime Nacimiento { get; set; }
        //String.Format("{0:dd/MM/yyyy}", Nacimiento);
        public string mail { get; set; }
        public char nombreusuario { get; set; }
        public char contraseña { get; set; }
        public char telefono { get; set; }
        
    }
}
  
  