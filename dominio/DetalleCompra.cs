using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class DetalleCompras
    {
        public int id { get; set; }

        public int IDCompraRealizada { get; set; }

        public int IDArticulo { get; set; }

        public string NombreArticulo { get; set; }

        public decimal PrecioTotal { get; set; }

        public string imagenURL { get; set; }

        public int DNIComprador { get; set; }

        public string NombreUsuarioComprador { get; set; }

        public string NombreComprador { get; set; }

        public string ApellidoComprador { get; set; }

        public string DireccionAEnviar { get; set; }

        public string TelefonoComprador { get; set; }

        public string MailComprador { get; set; }

        public int DNIVendedor { get; set; }
       
        public string NombreUsuarioVendedor { get; set; }

        public string NombreVendedor { get; set; }

        public string ApellidoVendedor { get; set; }
        
        public string TelefonoVendedor { get; set; }

        public string MailVendedor { get; set; }
    }


    
}
