using GestionCarreras.dto;

namespace GestionCarreras
{
    partial class GestionProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddProd = new System.Windows.Forms.Button();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEditarProd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonEliminarProd = new System.Windows.Forms.Button();
            this.listBoxEditarProducto = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(25, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nuevo Producto ";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(28, 71);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(130, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio";
            // 
            // buttonAddProd
            // 
            this.buttonAddProd.Location = new System.Drawing.Point(29, 214);
            this.buttonAddProd.Name = "buttonAddProd";
            this.buttonAddProd.Size = new System.Drawing.Size(129, 23);
            this.buttonAddProd.TabIndex = 6;
            this.buttonAddProd.Text = "Añadir Producto";
            this.buttonAddProd.UseVisualStyleBackColor = true;
            this.buttonAddProd.Click += new System.EventHandler(this.buttonAddProd_Click);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(28, 127);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(130, 21);
            this.comboBoxTipo.TabIndex = 7;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(29, 180);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(129, 20);
            this.textBoxPrecio.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(216, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Editar Producto";
            // 
            // buttonEditarProd
            // 
            this.buttonEditarProd.Location = new System.Drawing.Point(220, 214);
            this.buttonEditarProd.Name = "buttonEditarProd";
            this.buttonEditarProd.Size = new System.Drawing.Size(121, 23);
            this.buttonEditarProd.TabIndex = 11;
            this.buttonEditarProd.Text = "Editar Producto";
            this.buttonEditarProd.UseVisualStyleBackColor = true;
            this.buttonEditarProd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(427, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Eliminar Producto";
            // 
            // buttonEliminarProd
            // 
            this.buttonEliminarProd.Location = new System.Drawing.Point(431, 214);
            this.buttonEliminarProd.Name = "buttonEliminarProd";
            this.buttonEliminarProd.Size = new System.Drawing.Size(138, 23);
            this.buttonEliminarProd.TabIndex = 14;
            this.buttonEliminarProd.Text = "Eliminar Producto";
            this.buttonEliminarProd.UseVisualStyleBackColor = true;
            this.buttonEliminarProd.Click += new System.EventHandler(this.buttonEliminarProd_Click);
            // 
            // listBoxEditarProducto
            // 
            this.listBoxEditarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.listBoxEditarProducto.FormattingEnabled = true;
            this.listBoxEditarProducto.ItemHeight = 20;
            this.listBoxEditarProducto.Location = new System.Drawing.Point(220, 55);
            this.listBoxEditarProducto.Name = "listBoxEditarProducto";
            this.listBoxEditarProducto.Size = new System.Drawing.Size(349, 144);
            this.listBoxEditarProducto.TabIndex = 15;
            // 
            // GestionProductos
            // 
            this.ClientSize = new System.Drawing.Size(600, 273);
            this.Controls.Add(this.listBoxEditarProducto);
            this.Controls.Add(this.buttonEliminarProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonEditarProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.buttonAddProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Name = "GestionProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddProd;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEditarProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonEliminarProd;
        private System.Windows.Forms.ListBox listBoxEditarProducto;
    }
}