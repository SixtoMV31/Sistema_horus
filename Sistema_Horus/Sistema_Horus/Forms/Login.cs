using Sistema_Horus.Data;
using System.Data.SqlClient;
namespace Sistema_Horus
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
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
    }
}
