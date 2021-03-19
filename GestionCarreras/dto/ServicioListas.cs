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



        private ServicioListas()
        {
           
        }

   
    }
}
