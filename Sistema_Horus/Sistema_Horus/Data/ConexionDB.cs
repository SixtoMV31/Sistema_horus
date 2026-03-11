using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace Sistema_Horus.Data
{
    public class ConexionDB
    {
        public SqlConnection ObtenerConexion()
        {
            SqlConnection conn = new SqlConnection("Server=CHARLY\\SQLEXPRESS;Database=BD_Horus;Trusted_Connection=True;TrustServerCertificate=True;");
            conn.Open();
            return conn;
        }
    }
}
