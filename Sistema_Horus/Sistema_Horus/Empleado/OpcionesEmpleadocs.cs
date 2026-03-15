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
    public partial class OpcionesEmpleadocs : Form
    {

        private Button botonActivo = null;

        private readonly Color colorNormal = Color.FromArgb(45, 45, 48);   // Color original
        private readonly Color colorSeleccionado = Color.FromArgb(0, 122, 204); // Color activo

        public OpcionesEmpleadocs()
        {
            InitializeComponent();

            btnVentas.Click += BotonMenu_Click;
            btn_AgregarCliente.Click += BotonMenu_Click;
        }
        private void BotonMenu_Click(object sender, EventArgs e)
        {
            // Regresar el botón anterior a su color original
            if (botonActivo != null)
            {
                botonActivo.BackColor = colorNormal;
                botonActivo.ForeColor = Color.White;
            }

            // Aplicar color al botón recién seleccionado
            botonActivo = (Button)sender;
            botonActivo.BackColor = colorSeleccionado;
            botonActivo.ForeColor = Color.White;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new RealizarVentas());
        }

        private void AbrirFormEnPanel(Form formulario)
        {
            panelContenedor.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formulario);
            panelContenedor.Tag = formulario;
            formulario.Show();
        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormRegistrarClientes());
        }
    }


}
