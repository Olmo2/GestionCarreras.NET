using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCarreras.dto
{
    class Producto
    {
        public String nombre { get; set; }
        public String tipo { get; set; }
        public int precio { get; set; }

        public Producto(String nombre, String tipo, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.tipo = tipo;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
