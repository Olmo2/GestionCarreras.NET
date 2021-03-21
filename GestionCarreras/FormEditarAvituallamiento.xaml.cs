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
    /// Lógica de interacción para FormEditarAvituallamiento.xaml
    /// </summary>
    public partial class FormEditarAvituallamiento : Window
    {
        public Avituallamiento a;
        public int index;
        public FormEditarAvituallamiento(Avituallamiento avituallamiento, int i)
        {
            InitializeComponent();
             a = avituallamiento;
            index = i;
            textBoxCarrera.Text = a.carrera;
            textBoxNombre.Text = a.contacto.nombre;
            textBoxTlf.Text = a.contacto.tlf.ToString();
            textBoxPunto.Text = a.puntoKm.ToString();
            foreach (Material m in a.material)
            {
                ListBoxItem lbi = new ListBoxItem();
                ListBoxItem lbi2 = new ListBoxItem();
                lbi.Content = m.producto;
                lbi2.Content = m.textBox;

                listBoxMaterialesForm.Items.Add(lbi);
                listBoxMaterialesForm.Items.Add(lbi2);


            }
        }

        private void buttonConfirmar_Click(object sender, RoutedEventArgs e)
        {
            
            ObservableCollection<Material> lista = new ObservableCollection<Material>();

            List<int> selectedItemIndexes = new List<int>();
            foreach (object o in listBoxMaterialesForm.SelectedItems)
            {
                if (listBoxMaterialesForm.Items.IndexOf(o) == 0)
                    selectedItemIndexes.Add(listBoxMaterialesForm.Items.IndexOf(o));
                else if (listBoxMaterialesForm.Items.IndexOf(o) % 2 == 0)
                    selectedItemIndexes.Add(listBoxMaterialesForm.Items.IndexOf(o) /2);
            }

            foreach (int i in selectedItemIndexes)
            {
                lista.Add(a.material[i]);
            }
            Avituallamiento a1 = new Avituallamiento(
                    textBoxCarrera.Text,
                    int.Parse(textBoxPunto.Text),
                    new Persona(textBoxNombre.Text,
                    int.Parse(textBoxPunto.Text)),
                    lista);
            ServicioListas.sV.listaAvituallamientos.RemoveAt(index);
            ServicioListas.sV.listaAvituallamientos.Add(a1);
            this.Close();
        }
    }
}
