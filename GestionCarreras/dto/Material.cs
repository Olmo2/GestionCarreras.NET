using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GestionCarreras.dto
{
    public class Material
    {

        public Producto producto { get; set; }

        public TextBox textBox { get; set; } = new TextBox();

        public int cantidad { get; set; }

        public Material(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
            this.textBox.Text= cantidad.ToString();
        }
        public override string ToString()
        {
            return producto.nombre + textBox.Text;
        }

    }
}
