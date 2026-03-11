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
<<<<<<< HEAD
        //Editado xd
        
=======
<<<<<<< HEAD
        // Esta es otra prueba xd ssjdjjdjs
=======
        // Esta es una prueba de  mergeo y se entienda a que vamos
>>>>>>> administrador
>>>>>>> main
        private string conexion= "Server=MENDEZ\\SQLEXPRESS;Database=BD_Horus;Trusted_Connection=True;TrustServerCertificate=True;";
        public SqlConnection ObtenerConexion()
        {
            SqlConnection conn = new SqlConnection(conexion);
            return conn;
        }
        //a ver checa si funciono
    }
}
