using Sistema_Horus.Data;
using Sistema_Horus.Empleado;
using Sistema_Horus.Forms;
using Sistema_Horus.Forms.administrador;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace Sistema_Horus
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            ActiveControl = Tb_User;
        }

        private void Login_Load(object sender, EventArgs e)

        {

            BordeText(Pa_user);
            EstiloTextBox(Tb_User, "Usuario");
            EstiloTextBox(tb_contra, "Contraseña");
            ConexionDB conexion = new ConexionDB();

            try
            {
                var conn = conexion.ObtenerConexion();
                conn.Open();

                MessageBox.Show("Conexión exitosa con la base de datos");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void EstiloTextBox(TextBox tb, string placeholder)
        {
            int radio = 20;
            GraphicsPath path = new GraphicsPath();
            Rectangle r = new Rectangle(0, 0, tb.Width, tb.Height);
            path.AddArc(r.X, r.Y, radio, radio, 180, 90);
            path.AddArc(r.Right - radio, r.Y, radio, radio, 270, 90);
            path.AddArc(r.Right - radio, r.Bottom - radio, radio, radio, 0, 90);
            path.AddArc(r.X, r.Bottom - radio, radio, radio, 90, 90);
            path.CloseFigure();
            tb.Region = new Region(path);

            //Codigo placeholder
            tb.Text = placeholder;
            tb.ForeColor = Color.Gray;

            tb.GotFocus += (s, e) =>
            {
                if (tb.Text == placeholder)// validamos si el usuario hace click en el cuadro te texto, y txt borra lo que tenia
                {
                    tb.Text = "";
                }
            };
            tb.LostFocus += (s, e) =>
            {
                if (tb.Text == "")// si el usario da click afuera volvemos a colocar el placeholder
                {
                    tb.Text = placeholder;
                    tb.ForeColor = Color.Gray;
                }
            };
        }
        private void BordeText(Panel pa_user)
        {
            int radio = 20;
            GraphicsPath pathPanel = new GraphicsPath();
            Rectangle rp = new Rectangle(0, 0, pa_user.Width, pa_user.Height);
            pathPanel.AddArc(rp.X, rp.Y, radio, radio, 180, 90);
            pathPanel.AddArc(rp.Right - radio, rp.Y, radio, radio, 270, 90);
            pathPanel.AddArc(rp.Right - radio, rp.Bottom - radio, radio, radio, 0, 90);
            pathPanel.AddArc(rp.X, rp.Bottom - radio, radio, radio, 90, 90);
            pathPanel.CloseFigure();
            pa_user.Region = new Region(pathPanel);
        }

        private void btnIniciar_sesion_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD();
            string rol = crud.Login(Tb_User.Text, tb_contra.Text);
            if (rol == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                return;
            }
            this.Hide();
            if (rol == "Administrador")
            {
                Administrador FormAdmi = new Administrador();
                FormAdmi.Show();

            }
            else if (rol == "Empleado")
            {
                OpcionesEmpleadocs opcionesEmpleado = new OpcionesEmpleadocs();
                opcionesEmpleado.Show();
            }

        }






        //private void Tb_User_KeyDown(object sender, KeyEventArgs e)
        //{
        //if (e.KeyCode == Keys.Enter)
        //{
        //tb_contra.Focus();
        //}
        // }
    }
}
