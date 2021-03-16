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
        public GestionProductos()
        {
            InitializeComponent();
            comboBoxTipo.Items.Add("Bebida");
            comboBoxTipo.Items.Add("Comida");
            comboBoxTipo.Items.Add("Material Sanitario");
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
    }
}
