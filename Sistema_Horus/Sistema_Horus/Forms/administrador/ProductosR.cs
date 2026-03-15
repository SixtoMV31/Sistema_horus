using Sistema_Horus.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Horus.Forms.administrador
{
    public partial class ProductosR : Form
    {
        public ProductosR()
        {
            InitializeComponent();
        }

        private void btnAddProductos_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD();
            Productos producto = new Productos();
            producto.Nombre = txtNameProducto.Text;
            producto.Modelo_telefono = txtModeloTelefono.Text;
            producto.Cantidad = int.Parse(txtCantidad.Text);
            producto.PrecioMayoreo = float.Parse(TxtMayoreo.Text);
            producto.PrecioPase = float.Parse(txtPase.Text);
            producto.PrecioUnidad = float.Parse(txtUnidad.Text);
            producto.Tipo = txtTipo.Text;

            int result = crud.AgregarProducto(producto);
            if (result > 0)
            {
                MessageBox.Show("Datos guardados correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Datos no guardados correctamente", "Datos no guardados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }
    }
}
