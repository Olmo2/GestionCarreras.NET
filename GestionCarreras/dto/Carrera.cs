using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCarreras.dto
{
   public class Carrera
    {

        public String nombre { get; set; }
        public ObservableCollection<Avituallamiento> avituallamientos { get; set; } = new ObservableCollection<Avituallamiento>();

        public Carrera(string nombre, ObservableCollection<Avituallamiento> avituallamientos)
        {
            this.nombre = nombre;
            this.avituallamientos = avituallamientos;
        }

        public override string ToString()
        {
            //  return carrera + " KM: " +puntoKm;

            return  nombre;
        }
    }
}
