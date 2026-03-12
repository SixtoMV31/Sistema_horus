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
    public partial class EmpleadosR : Form
    {
        public EmpleadosR()
        {
            InitializeComponent();
        }


        private void EmpleadosR_Load(object sender, EventArgs e)
        {
            comboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRol.Items.Add("Empleado");
            comboRol.Items.Add("Administrador");
        }

        private void btnRegistrarEmpleados_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD();
            Punteros empleados = new Punteros();
            empleados.Nombre = txtNombre.Text;
            empleados.A_paterno = txtApaterno.Text;
            empleados.A_materno = txtAmaterno.Text;
            empleados.Usuario = txtUsuario.Text;
            empleados.Contrasena = txtContrasena.Text;
            empleados.Rol = comboRol.SelectedItem.ToString();

            int result = crud.IngresarEmpleado(empleados);
            if (result > 0)
            {
                MessageBox.Show("Datos guardados correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "Datos no guardados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
