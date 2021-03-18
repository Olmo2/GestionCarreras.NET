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
        public List<Producto> listaProds;
        public FormEditarProducto(Producto p, int i, List<Producto> lista)
        {
            listaProds = lista;
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

        public Producto actualizarProducto(Producto p)
        {
            return p;
        }

        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            Producto p = new Producto(textBoxNombre.Text, comboBoxTipo.SelectedItem.ToString(),int.Parse(textBoxPrecio.Text));
            actualizarProducto(p);
            GestionProductos g = (GestionProductos)Parent;
            listaProds.RemoveAt(index);
            listaProds.Add(p);

            this.Dispose();

        }
    }
}
