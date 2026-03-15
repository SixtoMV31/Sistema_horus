using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Horus.Data
{
    public class CRUD
    {
        private readonly ConexionDB _conexion = new ConexionDB();

        // Registrar los empleados
        public  int IngresarEmpleado(Punteros p_empleado)
        {
            int retorno = 0;
            using (SqlConnection conn = _conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand comando = new SqlCommand(string.Format("Insert Into dbo.Usuarios (Nombre,A_paterno, A_materno,Usuario, Contrasena, Rol) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", p_empleado.Nombre, p_empleado.A_paterno, p_empleado.A_materno, p_empleado.Usuario, p_empleado.Contrasena, p_empleado.Rol), conn);

                  retorno = comando.ExecuteNonQuery();
            }
            return retorno;
        }

        // Consulta a BD para usuario y password.
        public string Login(string usuario,string contrasena)
        {
            try
            {
               using (SqlConnection conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT rol FROM Usuarios WHERE Usuario=@usuario AND Contrasena=@contrasena";
                    using (SqlCommand cmd = new SqlCommand(query, conn)) 
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);
                        object resultado =cmd.ExecuteScalar();
                        if(resultado != null)
                        {
                            return resultado.ToString();
                        }
                        else
                        
                            return null;
                        
                    }
                } 

            }catch (Exception e) 
            {
                MessageBox.Show("Error"+e.Message);
                return null;
            }
        }
        public int RegistrarClientes(RegistrarClientes p_clientes)
        {
            int retorno = 0;
            using (SqlConnection conn = _conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("Insert Into dbo.Clientes " +
                    "(Nombre,A_paterno, A_materno,N_local, Telefono, Fecha_registro,Detalle) " +
                    "VALUES (@Nombre,@A_paterno,@A_materno,@N_local,@Telefono,@Fecha_registro,@Detalle)", conn);
                comando.Parameters.AddWithValue("@Nombre",p_clientes.NombreCliente);
                comando.Parameters.AddWithValue("@A_paterno", p_clientes.A_PaternoCliente);
                comando.Parameters.AddWithValue("@A_materno", p_clientes.A_MaternoCliente);
                comando.Parameters.AddWithValue("@N_local", p_clientes.Nombre_Local);
                comando.Parameters.AddWithValue("@Telefono", p_clientes.TelefonoCliente);
                comando.Parameters.AddWithValue("@Fecha_registro", p_clientes.Fecha_Registro);
                comando.Parameters.AddWithValue("@Detalle", p_clientes.Detalle_Clientte);

                retorno = comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
