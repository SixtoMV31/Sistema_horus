using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Horus.Forms;
using Sistema_Horus.Forms.administrador;

namespace Sistema_Horus
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            EmpleadosR registraEmpleado = new EmpleadosR();
            registraEmpleado.Show();
        }
    }
}
