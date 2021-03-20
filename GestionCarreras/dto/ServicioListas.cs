using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GestionCarreras.dto
{

    public class ServicioListas
    {
         public static ServicioListas sV = new ServicioListas();
        
        public ObservableCollection<Producto> listaProductos { get; set; }  = new ObservableCollection<Producto>();
        public ObservableCollection<String> listaTipos { get; set; } = new ObservableCollection<String>();
        public ObservableCollection<Avituallamiento> listaAvituallamientos { get; set; } = new ObservableCollection<Avituallamiento>();

        public ObservableCollection<Material> listaMateriales { get; set; } = new ObservableCollection<Material>();



        private ServicioListas()
        {
            listaProductos.Add(new Producto("Barrita Energética", "Comida", 20));
            listaProductos.Add(new Producto("Gatorade", "Bebida", 20));
            listaProductos.Add(new Producto("Vendas", "Material Sanitario", 20));
            listaProductos.Add(new Producto("Pako", "Comida", 20));
            listaProductos.Add(new Producto("Nachos", "Comida", 20));

            listaTipos.Add("Bebida");
            listaTipos.Add("Comida");
            listaTipos.Add("Material Sanitario");

            listaMateriales.Add(new Material(listaProductos[0],10 ));
            listaMateriales.Add(new Material(listaProductos[1], 5));
            listaMateriales.Add(new Material(listaProductos[2], 6));
            listaMateriales.Add(new Material(listaProductos[3], 99));
            listaMateriales.Add(new Material(listaProductos[4], 75));

            listaAvituallamientos.Add(new Avituallamiento("Bonta", 420, new Persona("Anakin", 666666666), listaMateriales));
        }

   
    }
}
