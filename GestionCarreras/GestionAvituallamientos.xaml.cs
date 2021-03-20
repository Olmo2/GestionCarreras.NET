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
        
        TextBox tB = new TextBox();
        public GestionAvituallamientos()
        {
            InitializeComponent();

           foreach (Material m in ServicioListas.sV.listaMateriales)
            {
                ListBoxItem lbi = new ListBoxItem();
                ListBoxItem lbi2 = new ListBoxItem();
                lbi.Content = m.producto;
                lbi2.Content = m.textBox;

                listBoxMateriales.Items.Add(lbi);
                listBoxMateriales.Items.Add(lbi2);


            }

           /* foreach (Material m in ServicioListas.sV.listaMateriales)
            {
                ListBoxItem lbi = new ListBoxItem();
                lbi.Content = m.producto;

                listBoxMateriales.Items.Add(lbi); 

            }*/
           
            this.DataContext = ServicioListas.sV;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            //listBoxAvituallamientos.SelectedItems.Cast<Producto>
            ObservableCollection<Material> lista = new ObservableCollection<Material>();

            List<int> selectedItemIndexes = new List<int>();
            foreach (object o in listBoxMateriales.SelectedItems)
            {
                if(listBoxMateriales.Items.IndexOf(o)==0)
                selectedItemIndexes.Add(listBoxMateriales.Items.IndexOf(o));
                else if (listBoxMateriales.Items.IndexOf(o) % 2 == 0)
                    selectedItemIndexes.Add(listBoxMateriales.Items.IndexOf(o)-1);
            }

            foreach (int i in selectedItemIndexes)
            {
                lista.Add(ServicioListas.sV.listaMateriales[i]);
            }
            Avituallamiento a = new Avituallamiento(
                    textBoxCarrera.Text,
                    int.Parse(textBoxPunto.Text),
                    new Persona(textBoxNombre.Text,
                    int.Parse(textBoxPunto.Text)), 
                    lista);
            ServicioListas.sV.listaAvituallamientos.Add(a);
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            ServicioListas.sV.listaAvituallamientos.RemoveAt(listBoxAvituallamientos.SelectedIndex);
        }
    }
}
