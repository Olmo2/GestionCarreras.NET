using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCarreras.dto
{
    public class Avituallamiento
    {

        public String carrera { get; set; }
        public int puntoKm { get; set; }
        public Persona contacto {get; set; }

        public ObservableCollection<Producto> material { get; set; }

        public Avituallamiento(string carrera, int puntoKm, Persona contacto, ObservableCollection<Producto> material)
        {
            this.carrera = carrera;
            this.puntoKm = puntoKm;
            this.contacto = contacto;
            this.material = material;
        }

        public override string ToString()
        {
            return carrera + " KM: " +puntoKm;
        }
    }
}
