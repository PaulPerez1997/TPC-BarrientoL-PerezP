using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class CompraRealizada
    {
        public int ID { get; set; }

        public int DniUsuario { get; set; }

        public int IDArticulo { get; set; }

        public DateTime Fecha { get; set; }

    }
}
