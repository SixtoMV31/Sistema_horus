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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
            //Para no ocultar la barra de tareas
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void AbrirFormulario(object formsecundario)
        {
            if (this.PanelControl.Controls.Count > 0)
                this.PanelControl.Controls.RemoveAt(0);
            Form fh = formsecundario as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelControl.Controls.Add(fh);
            this.PanelControl.Tag = fh;
            fh.Show();

        }
        //btn Empleado
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new EmpleadosR());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ProductosR());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
