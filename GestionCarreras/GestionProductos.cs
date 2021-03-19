using GestionCarreras.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCarreras
{
    public partial class GestionProductos : Form
    {
       
        

        public GestionProductos(MainWindow mainWindow)
        {
           
            InitializeComponent();
            comboBoxTipo.Items.Add("Bebida");
            comboBoxTipo.Items.Add("Comida");
            comboBoxTipo.Items.Add("Material Sanitario");

            listBoxEditarProducto.DataSource = ServicioListas.sV.listaProductos;
            listBoxEditarProducto.DataBindings.Add(new Binding("Text", ServicioListas.sV, "listaProductos"));
            
            /* foreach (Producto p in ServicioListas.sV.listaProductos)
             {
                 listBoxEditarProducto.Items.Add(p);
                 listBoxBorrarProducto.Items.Add(p);
             }*/

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            Producto p = new Producto(textBoxNombre.Text, comboBoxTipo.SelectedText, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i= listBoxEditarProducto.SelectedIndex;
            FormEditarProducto fep = new FormEditarProducto((Producto)listBoxEditarProducto.Items[i],i);
            fep.Show();
        }

        private void buttonEliminarProd_Click(object sender, EventArgs e)
        {
            //Borar un producto 
        }

    }
}
