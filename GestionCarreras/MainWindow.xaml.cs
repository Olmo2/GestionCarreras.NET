using GestionCarreras.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestionCarreras
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Producto> listaProds;

        public MainWindow()
        {
            InitializeComponent();

            listaProds = new List<Producto>();
            listaProds.Add(new Producto("Pan", "Comida", 20));
            listaProds.Add(new Producto("Manolo Lama", "Comida", 20));
            listaProds.Add(new Producto("Cebolla", "Comida", 20));
            listaProds.Add(new Producto("Pako", "Comida", 20));
            listaProds.Add(new Producto("Nachos", "Comida", 20));
            foreach (Producto p in listaProds)
            {

               // ComboBoxItem cbi = new ComboBoxItem();
                ListBoxItem lbi = new ListBoxItem();
               // cbi.Content = p;
                lbi.Content = p;
               // comboBoxProductos.Items.Add(cbi);
                ListBoxProductos.Items.Add(lbi);
            }
        }

        private void ButtonGestionProductos_Click(object sender, RoutedEventArgs e)
        {

            GestionProductos gP = new GestionProductos(listaProds);
            
            gP.Show();
                
        }
    }
}
