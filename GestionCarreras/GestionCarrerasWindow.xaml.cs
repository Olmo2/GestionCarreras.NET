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
    /// Lógica de interacción para GestionCarreras.xaml
    /// </summary>
    public partial class GestionCarrerasWindow : Window
    {
        public GestionCarrerasWindow()
        {
            InitializeComponent();
            this.DataContext = ServicioListas.sV;
        }

        private void ButtonEditar_Click(object sender, RoutedEventArgs e)
        {
            FormEditarCarrera fEC = new FormEditarCarrera((Carrera)listBoxCarreras.SelectedItem,listBoxCarreras.SelectedIndex);
            fEC.Show();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
           Carrera c = (Carrera)listBoxCarreras.SelectedItem;
            int index = 0;
            foreach(Avituallamiento a in c.avituallamientos)
            {
                
                if (a.carrera.Equals(c.nombre))
                {
                    ServicioListas.sV.listaAvituallamientos.RemoveAt(index);
                }
                index++;
            }

            ServicioListas.sV.listaCarreras.RemoveAt(listBoxCarreras.SelectedIndex);

        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Avituallamiento> lista = new ObservableCollection<Avituallamiento>();

            List<int> selectedItemIndexes = new List<int>();
            foreach (object o in listBoxAvituallamientos.SelectedItems)
            {
                selectedItemIndexes.Add(listBoxAvituallamientos.Items.IndexOf(o));
            }

            foreach (int i in selectedItemIndexes)
            {
                lista.Add(ServicioListas.sV.listaAvituallamientos[i]);
            }
            Carrera c = new Carrera(textBoxNombre.Text, lista);

           
            ServicioListas.sV.listaCarreras.Add(c);
        }
    }
}
