using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sistema_Horus.Data
{
    public class CRUD
    {
        private readonly ConexionDB _conexion = new ConexionDB();

        // Registrar los empleados
        public  int IngresarEmpleado(Empleados p_empleado)
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
        public int AgregarProducto(Productos p_productos)
        {
            int retorno = 0;
            using (SqlConnection conn = _conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand comando = new SqlCommand(string.Format("Insert Into dbo.Productos (Nombre_producto,Cantidad, Modelo_Telefono,Precio_mayoreo, Precio_pase, Precio_unidad, Tipo) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", p_productos.Nombre, p_productos.Cantidad, p_productos.Modelo_telefono, p_productos.PrecioMayoreo, p_productos.PrecioPase, p_productos.PrecioUnidad, p_productos.Tipo), conn);

                retorno = comando.ExecuteNonQuery();
            }
            return retorno;
        }


        // Consulta a BD para usuario y password.
        public Empleados Login(string usuario,string contrasena)
        {
            try
            {
               using (SqlConnection conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT Id_usuario,Nombre, Rol FROM Usuarios WHERE Usuario=@usuario AND Contrasena=@contrasena";
                    using (SqlCommand cmd = new SqlCommand(query, conn)) 
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            Empleados p = new Empleados();
                            p.Id_Usuarios = Convert.ToInt32(reader["Id_Usuario"]);
                            p.Nombre = reader["Nombre"].ToString();
                            p.Rol = reader["Rol"].ToString();
                            return p;
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
        
        public AutoCompleteStringCollection ObtenerNombreClientes()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            using (SqlConnection conn = _conexion.ObtenerConexion())
            {
                conn.Open();
                DataTable datos = new DataTable();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT* FROM Clientes", conn);
                sqlData.Fill(datos);
                for (int i = 0;i<datos.Rows.Count;i++)
                {
                    lista.Add(datos.Rows[i]["Nombre"].ToString());
                    lista.Add(datos.Rows[i]["A_paterno"].ToString());
                    
                }
            }
            return lista;
        }
        public RegistrarClientes BuscarCliente(string nombre)
        {
            RegistrarClientes cliente = null;
            using (SqlConnection conn = _conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT Id_clientes, Nombre, A_paterno, A_materno, Telefono, N_local " +
                    "FROM Clientes WHERE Nombre = @Nombre", conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cliente = new RegistrarClientes();
                    cliente.Id_Clientes = Convert.ToInt32(reader["Id_clientes"]);
                    cliente.NombreCliente = reader["Nombre"].ToString();
                    cliente.A_PaternoCliente = reader["A_paterno"].ToString();
                    cliente.A_MaternoCliente = reader["A_materno"].ToString();
                    cliente.TelefonoCliente = reader["Telefono"].ToString();
                    cliente.Nombre_Local = reader["N_local"].ToString();
                }
            }
            return cliente;
        }
        public AutoCompleteStringCollection BuscarProductos()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            using (SqlConnection conn = _conexion.ObtenerConexion())
            {
                conn.Open();
                DataTable datos = new DataTable();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT* FROM Productos", conn);
                sqlData.Fill(datos);
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    lista.Add(datos.Rows[i]["Nombre_Producto"].ToString());

                }
            }
            return lista;
        }
        public AutoCompleteStringCollection BuscarModelo(string nombreProducto)
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            using (SqlConnection conn = _conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT Modelo_Telefono FROM Productos WHERE Nombre_producto =@nombre", conn);
                cmd.Parameters.AddWithValue(@"Nombre", nombreProducto);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    lista.Add(reader["Modelo_Telefono"].ToString());

                }
                return lista;

            }
            
        }
    }
}
