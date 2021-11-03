using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Peso_kg { get; set; }
        public decimal Largo_cm { get; set; }
        public string ImagenURL { get; set; }
        public int Stock { get; set; }

        public Categoria Categoria { get; set; }

        public Marca Marca { get; set; }
       
    }
}
