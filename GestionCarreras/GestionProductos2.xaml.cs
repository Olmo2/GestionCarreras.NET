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
    public partial class GestionProductos2 : Window
    {
        public GestionProductos2()
        {
            InitializeComponent();
            comboBoxTipo.Items.Add("Bebida");
            comboBoxTipo.Items.Add("Comida");
            comboBoxTipo.Items.Add("Material Sanitario");
            this.DataContext = ServicioListas.sV;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int i = listBoxProductos.SelectedIndex;
            FormEditarProducto fep = new FormEditarProducto((Producto)listBoxProductos.Items[i], i);
            fep.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
