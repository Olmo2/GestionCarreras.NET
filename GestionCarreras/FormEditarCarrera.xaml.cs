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
    /// Lógica de interacción para FormEditarCarrera.xaml
    /// </summary>
    public partial class FormEditarCarrera : Window
    {
        int index;
        public FormEditarCarrera(Carrera c, int i)
        {
            InitializeComponent();
            index = i;
            this.DataContext = ServicioListas.sV;

            textBoxNombre.Text = c.nombre;
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

            ServicioListas.sV.listaCarreras.RemoveAt(index);
            ServicioListas.sV.listaCarreras.Add(c);

            this.Close();
        }
    }
}
