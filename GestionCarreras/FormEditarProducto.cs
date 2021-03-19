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
    
    public partial class FormEditarProducto : Form
    {
        public int index;
        
        public FormEditarProducto(Producto p, int i)
        {
           
            InitializeComponent();
            index = i;
            comboBoxTipo.Items.Add("Bebida");
            comboBoxTipo.Items.Add("Comida");
            comboBoxTipo.Items.Add("Material Sanitario");

            textBoxNombre.Text = p.nombre;

            switch (p.tipo)
            {
                case "Bebida":
                    comboBoxTipo.SelectedIndex = 0;
                    break;
                case "Comida":
                    comboBoxTipo.SelectedIndex = 1;
                    break;
                case "Material Sanitario":
                    comboBoxTipo.SelectedIndex = 2;
                    break;
            }
            
            textBoxPrecio.Text = p.precio.ToString();
        }


        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            Producto p = new Producto(textBoxNombre.Text, comboBoxTipo.SelectedItem.ToString(),int.Parse(textBoxPrecio.Text));
            ServicioListas.sV.listaProductos.RemoveAt(index);
            ServicioListas.sV.listaProductos.Add(p);
            
            this.Dispose();

        }
    }
}
