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
        private readonly ConexionDB _conexion=new ConexionDB();

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
    }
}
