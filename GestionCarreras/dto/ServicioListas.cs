using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCarreras.dto
{

    public class ServicioListas
    {
         public static ServicioListas sV = new ServicioListas();
        
        public ObservableCollection<Producto> listaProductos { get; set; }  = new ObservableCollection<Producto>();
        public ObservableCollection<String> listaTipos { get; set; } = new ObservableCollection<String>();
        public ObservableCollection<Avituallamiento> listaAvituallamientos { get; set; } = new ObservableCollection<Avituallamiento>();



        private ServicioListas()
        {
            listaProductos.Add(new Producto("Pan", "Comida", 20));
            listaProductos.Add(new Producto("Manolo Lama", "Comida", 20));
            listaProductos.Add(new Producto("Cebolla", "Comida", 20));
            listaProductos.Add(new Producto("Pako", "Comida", 20));
            listaProductos.Add(new Producto("Nachos", "Comida", 20));

            listaTipos.Add("Bebida");
            listaTipos.Add("Comida");
            listaTipos.Add("Material Sanitario");

            listaAvituallamientos.Add(new Avituallamiento("Bonta", 420, new Persona("Anakin", 666666666), listaProductos));
        }

   
    }
}
