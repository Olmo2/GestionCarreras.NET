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
    /// Lógica de interacción para FormEditarProducto2.xaml
    /// </summary>
    public partial class FormEditarProducto : Window
    {
        int index;
        public FormEditarProducto(Producto p, int i)
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.DataContext = ServicioListas.sV;
            index = i;
           /* comboBoxTipo.Items.Add("Bebida");
            comboBoxTipo.Items.Add("Comida");
            comboBoxTipo.Items.Add("Material Sanitario");*/

            textBoxNombre.Text = p.nombre;

            switch (p.tipo)
            {
                case "Bebida":
                    comboBoxTipo.SelectedIndex = 0;
                    break;
                case "Comida":
                    comboBoxTipo.SelectedIndex = 1;
                    break;
                case "Material Sanitario":
                    comboBoxTipo.SelectedIndex = 2;
                    break;
            }

            textBoxPrecio.Text = p.precio.ToString();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            Producto p = new Producto(textBoxNombre.Text, comboBoxTipo.SelectedItem.ToString(), int.Parse(textBoxPrecio.Text));
            ServicioListas.sV.listaProductos.RemoveAt(index);
            ServicioListas.sV.listaProductos.Add(p);
            
            this.Close();

        }
    }
}
