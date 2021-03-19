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

        /*public void rellenar()
        {
            ListBoxProductos.Items.Clear();
            foreach (Producto p in ServicioListas.sV.listaProductos)
            {
                // ComboBoxItem cbi = new ComboBoxItem();
                ListBoxItem lbi = new ListBoxItem();
                // cbi.Content = p;
                lbi.Content = p;
                // comboBoxProductos.Items.Add(cbi);
                ListBoxProductos.Items.Add(lbi);
            }
        }*/

      
       
        public MainWindow()
        {
            
            InitializeComponent();
           ServicioListas.sV.listaProductos.Add(new Producto("Pan", "Comida", 20));
            ServicioListas.sV.listaProductos.Add(new Producto("Manolo Lama", "Comida", 20));
            ServicioListas.sV.listaProductos.Add(new Producto("Cebolla", "Comida", 20));
            ServicioListas.sV.listaProductos.Add(new Producto("Pako", "Comida", 20));
            ServicioListas.sV.listaProductos.Add(new Producto("Nachos", "Comida", 20));
           // listaProductos = new List<Producto>();
            this.DataContext = ServicioListas.sV;
           // rellenar();
        }

        private void ButtonGestionProductos_Click(object sender, RoutedEventArgs e)
        {

            GestioProductos2 gP = new GestioProductos2();
            
            gP.Show();
                
        }

        private void ListBoxProductos_GotFocus(Object sender, EventArgs e)
        {

            MessageBox.Show("You are in the Control.GotFocus event."); 
        }
    }
}
