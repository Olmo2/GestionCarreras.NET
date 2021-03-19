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
using System.Windows.Shapes;

namespace GestionCarreras
{
    /// <summary>
    /// Lógica de interacción para GestioProductos2.xaml
    /// </summary>
    public partial class GestionProductos : Window
    {
        public GestionProductos()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            /*  comboBoxTipo.Items.Add("Bebida");
              comboBoxTipo.Items.Add("Comida");
              comboBoxTipo.Items.Add("Material Sanitario");*/
            this.DataContext = ServicioListas.sV;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FormEditarProducto fep = new FormEditarProducto((Producto)listBoxProductos.Items[listBoxProductos.SelectedIndex], listBoxProductos.SelectedIndex);
            fep.Show();
        }

       

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            Producto p = new Producto(textBoxNombre.Text, comboBoxTipo.SelectedItem.ToString(), int.Parse(textBoxPrecio.Text));
            ServicioListas.sV.listaProductos.Add(p);
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            ServicioListas.sV.listaProductos.RemoveAt(listBoxProductos.SelectedIndex);
        }
    }
}
