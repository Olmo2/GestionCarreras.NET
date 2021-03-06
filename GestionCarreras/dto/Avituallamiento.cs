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
        public ObservableCollection<Material> material { get; set; }

        public Dictionary<Producto, int> map { get; set; }

        public Avituallamiento(string carrera, int puntoKm, Persona contacto, ObservableCollection<Material> material)
        {
            this.carrera = carrera;
            this.puntoKm = puntoKm;
            this.contacto = contacto;
            this.material = material;
        }

        public override string ToString()
        {
            //  return carrera + " KM: " +puntoKm;

            return "Carrera: " + carrera + " Punto KM: "+ puntoKm + "Contacto: " +  "Nombre: "+contacto.nombre + " Tlf: "+ contacto.tlf;
        }
    }
}
