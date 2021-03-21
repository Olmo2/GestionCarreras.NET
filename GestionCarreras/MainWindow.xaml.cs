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

        public MainWindow()
        {
            
            InitializeComponent();
            this.WindowStartupLocation= WindowStartupLocation.CenterScreen;
            this.DataContext = ServicioListas.sV;
          
        }

        private void ButtonGestionProductos_Click(object sender, RoutedEventArgs e)
        {

            GestionProductos gP = new GestionProductos();
            gP.Show();
                
        }

        private void ButtonGestionAvituallamieno_Click(object sender, RoutedEventArgs e)
        {
            GestionAvituallamientos gA = new GestionAvituallamientos();
            gA.Show();
        }

        private void buttonGestionCarrera_Click(object sender, RoutedEventArgs e)
        {
            GestionCarrerasWindow gC = new GestionCarrerasWindow();
            gC.Show();
        }
    }
}
