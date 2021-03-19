using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCarreras.dto
{
    public class Persona
    {

        public String nombre { get; set; }
        public int tlf { get; set; }

        public Persona(string nombre, int tlf)
        {
            this.nombre = nombre;
            this.tlf = tlf;
        }
    }
}
