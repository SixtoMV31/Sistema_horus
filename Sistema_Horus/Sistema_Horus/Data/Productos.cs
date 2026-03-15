using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Horus.Data
{
    public class Productos
    {
        public string Nombre {  get; set; }
        public string Modelo_telefono {  get; set; }
        public int Cantidad {  get; set; }
        public float PrecioMayoreo {  get; set; }
        public float PrecioPase {  get; set; }
        public float PrecioUnidad {  get; set; }
        public string Tipo  {  get; set; }

        public Productos() { }

        public Productos(string Pnombre, string Pmodelo, int Pcantidad, float Pmayoreo, float pase, float Punidad, string Ptipo)
        {
            this.Nombre = Pnombre;
            this.Modelo_telefono = Pmodelo;
            this.Cantidad = Pcantidad;
            this.PrecioMayoreo = Pmayoreo;
            this.PrecioPase = pase;
            this.PrecioUnidad = Punidad;
            this.Tipo = Ptipo;
        }
        
    }
}
