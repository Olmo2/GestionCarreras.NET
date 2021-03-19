using GestionCarreras.dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para GestionAvituallamientos.xaml
    /// </summary>
    public partial class GestionAvituallamientos : Window
    {
        public GestionAvituallamientos()
        {
            InitializeComponent();
            this.DataContext = ServicioListas.sV;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            
            Avituallamiento a = new Avituallamiento(
                    textBoxCarrera.Text,
                    int.Parse(textBoxPunto.Text),
                    new Persona(textBoxNombre.Text,
                    int.Parse(textBoxPunto.Text)), 
                    new ObservableCollection<Producto>((ObservableCollection<Producto>)listBoxAvituallamientos.SelectedItems));
            ServicioListas.sV.listaAvituallamientos.Add(a);
        }
    }
}
