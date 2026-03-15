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
    public partial class FormRegistrarClientes : Form
    {
        public FormRegistrarClientes()
        {
            InitializeComponent();
            this.ActiveControl = txt_NombreCliente;

            // Asigna el evento a todos los TextBox
            txt_NombreCliente.KeyDown += SaltarCampo_KeyDown;
            txt_A_PaternoCliente.KeyDown += SaltarCampo_KeyDown;
            txt_A_MaternoCliente.KeyDown += SaltarCampo_KeyDown;
            txt_Nombre_Local.KeyDown += SaltarCampo_KeyDown;
            txt_TelefonoCliente.KeyDown += SaltarCampo_KeyDown;
            txt_Detalle_Clientte.KeyDown += SaltarCampo_KeyDown;
        }

        private void btn_RegistrarCliente_Click(object sender, EventArgs e)
        {
            CRUD crud= new CRUD();
            RegistrarClientes clientes = new RegistrarClientes();
            clientes.NombreCliente=txt_NombreCliente.Text;
            clientes.A_PaternoCliente=txt_A_PaternoCliente.Text;
            clientes.A_MaternoCliente=txt_A_MaternoCliente.Text;
            clientes.Nombre_Local=txt_Nombre_Local.Text;
            clientes.TelefonoCliente=txt_TelefonoCliente.Text;
            clientes.Detalle_Clientte = txt_Detalle_Clientte.Text;
            clientes.Fecha_Registro = dt_Fecha_Registro.Value;
        

        int resultadoCliente =crud.RegistrarClientes(clientes);
            if (resultadoCliente >0)
            {
                MessageBox.Show("Cliente Registrado Correctamente", "Cliente Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error al Intentar registrar al cliente", "Datos no guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void SaltarCampo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sender == txt_NombreCliente) txt_A_PaternoCliente.Focus(); 
                else if (sender == txt_A_PaternoCliente) txt_A_MaternoCliente.Focus();
                else if (sender == txt_A_MaternoCliente) txt_Nombre_Local.Focus(); 
                else if (sender == txt_Nombre_Local) txt_TelefonoCliente.Focus();
                else if (sender == txt_TelefonoCliente) txt_Detalle_Clientte.Focus(); 
                else if (sender == txt_Detalle_Clientte) btn_RegistrarCliente.Focus();

                e.SuppressKeyPress = true;
            }
        }
    }
}
