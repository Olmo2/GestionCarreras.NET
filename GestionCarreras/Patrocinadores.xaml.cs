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
    /// Lógica de interacción para Patrocinadores.xaml
    /// </summary>
    public partial class Patrocinadores : Window
    {
        List<Avituallamiento> listAvi;
        public Patrocinadores(Carrera c)
        {
            InitializeComponent();
            labelCarrera.Content += c.nombre;
            listAvi = new List<Avituallamiento>();
            foreach (Avituallamiento a in ServicioListas.sV.listaAvituallamientos)
            {
                if (a.carrera.Equals(c.nombre))
                {
                    ListBoxItem lbi = new ListBoxItem();
                    lbi.Content = "Patrocinador: " + a.patrocinador;
                    ListBoxItem lbi2 = new ListBoxItem();
                    lbi2.Content = "Importe: " + a.importe;
                    listBoxCarreras.Items.Add(lbi);
                    listBoxCarreras.Items.Add(lbi2);

                }
            }
            
        }
    }
}
