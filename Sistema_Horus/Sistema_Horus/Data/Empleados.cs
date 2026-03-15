using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Horus.Data

{

    public class Empleados
    {
        // Tabla de Usuarios
        public string Nombre { get; set; }
        public string A_paterno { get; set; }
        public string A_materno { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Rol { get; set; }




        public Empleados() { }

        public Empleados(string pNombre, string pA_paterno, string pA_materno, string pUsuario, string pContrasena, string pRol)

        {
            this.Nombre = pNombre;
            this.A_paterno = pA_paterno;
            this.A_materno = pA_materno;
            this.Usuario = pUsuario;
            this.Contrasena = pContrasena;
            this.Rol = pRol;
        }

    }
    public class RegistrarClientes
    {
        //Tabla Ingresar Clientes
        public string NombreCliente { get; set; }
        public string A_PaternoCliente { get; set; }
        public string A_MaternoCliente { get; set; }
        public string Nombre_Local { get; set; }
        public string TelefonoCliente { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public string Detalle_Clientte { get; set; }

        public RegistrarClientes() { }
        public RegistrarClientes(string Cli_Nombre, string Cli_A_Paterno, string Cli_A_Materno, string Local_cli,
                                 string Telefono_Cli, DateTime Cli_Registro_Cliente, string Cli_Detalle)
        {
            this.NombreCliente = Cli_Nombre;
            this.A_PaternoCliente = Cli_A_Paterno;
            this.A_MaternoCliente = Cli_A_Materno;
            this.Nombre_Local = Local_cli;
            this.TelefonoCliente = Telefono_Cli;
            this.Fecha_Registro = Cli_Registro_Cliente;
            this.Detalle_Clientte = Cli_Detalle;
        }
    }

}
