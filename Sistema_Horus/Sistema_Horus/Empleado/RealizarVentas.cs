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

namespace Sistema_Horus.Empleado
{
    public partial class RealizarVentas : Form
    {
        int IdClienteSeleccionado = 0;
        CRUD crud = new CRUD();
        public RealizarVentas()
        {
            InitializeComponent();
            buscarClientes();
            buscarProductos();
            
        }

        private void  buscarClientes()
        {
            
            txtBuscarClientes.AutoCompleteMode=AutoCompleteMode.Suggest;
            txtBuscarClientes.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBuscarClientes.AutoCompleteCustomSource = crud.ObtenerNombreClientes();
            txtBuscarClientes.TextChanged += TxtBuscarClientes_TextChanged;

        }

        private void TxtBuscarClientes_TextChanged(object? sender, EventArgs e)
        {
            RegistrarClientes cliente = crud.BuscarCliente(txtBuscarClientes.Text);

            if (cliente != null )
            {
                IdClienteSeleccionado = cliente.Id_Clientes;
                txtNombre.Text = cliente.NombreCliente;
                TxtApellido1.Text = cliente.A_PaternoCliente;
                txtApellido2.Text = cliente.A_MaternoCliente;
                txtTelefono.Text= cliente.TelefonoCliente;
                txtLocal.Text = cliente.Nombre_Local;
            }
            else
            {
                IdClienteSeleccionado = 0;
                txtNombre.Text = string.Empty;
                TxtApellido1.Text= string.Empty;
                txtApellido2.Text= string.Empty;
                txtTelefono.Text = string.Empty;
                txtLocal.Text = string.Empty;
               
            }

        }
        private void buscarProductos()
        {

            txtBuscarProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBuscarProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBuscarProducto.AutoCompleteCustomSource = crud.BuscarProductos();
            txtBuscarProducto.AutoCompleteCustomSource = crud.BuscarProductos();


        }
        private void TxtNombreProducto_TextChanged(object? sender, EventArgs e)
        {
            AutoCompleteStringCollection modelos = crud.BuscarModelo(txtBuscarProducto.Text);

            if (modelos.Count > 0)
            {
                txtBuscarModelo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtBuscarModelo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtBuscarModelo.AutoCompleteCustomSource = modelos;
                txtBuscarModelo.Enabled = true;
            }
            else
            {
                txtBuscarModelo.Text = string.Empty;
                txtBuscarModelo.Enabled = false;
            }
        }
            private void buscarModelo()
        {

            txtBuscarModelo.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBuscarModelo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBuscarModelo.AutoCompleteCustomSource = crud.ObtenerNombreClientes();
            txtBuscarModelo.TextChanged += TxtBuscarClientes_TextChanged;

        }
    }
}
