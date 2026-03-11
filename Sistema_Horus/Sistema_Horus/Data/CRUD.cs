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
        public static int IngresarEmpleado(Punteros p_empleado)
        {
            int retorno = 0;
            using (SqlConnection conn = ConexionDB.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert Into dbo.Usuarios (Nombre,A_paterno, A_materno,Usuario, Contrasena, Rol) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", p_empleado.Nombre, p_empleado.A_paterno, p_empleado.A_materno, p_empleado.Usuario, p_empleado.Contrasena, p_empleado.Rol), conn);

                retorno = comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
