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
        public List<Producto> listaProds;
        public GestionProductos(List<Producto> lP)
        {
            listaProds = new List<Producto>();
            listaProds = lP;
            InitializeComponent();
            comboBoxTipo.Items.Add("Bebida");
            comboBoxTipo.Items.Add("Comida");
            comboBoxTipo.Items.Add("Material Sanitario");
         
            foreach (Producto p in listaProds)
            {
                listBoxEditarProducto.Items.Add(p);
                listBoxBorrarProducto.Items.Add(p);
            }
           
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
            FormEditarProducto fep = new FormEditarProducto((Producto)listBoxEditarProducto.Items[i],i,listaProds);
            fep.Show();
        }

        private void buttonEliminarProd_Click(object sender, EventArgs e)
        {
            //Borar un producto 
        }
    }
}
