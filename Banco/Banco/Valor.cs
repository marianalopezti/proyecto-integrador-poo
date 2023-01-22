using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    public class Valor
    {
        private string texto, nombre;
        private decimal cotizacion;
        public Valor(string texto, string nombre, decimal cotizacion)
        {
            this.texto = texto;
            this.nombre = nombre;
            this.cotizacion = cotizacion;
        }
        public string Texto
        {
            get { return texto; }
            set { texto = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public decimal Cotizacion
        {
            get { return cotizacion; }
            set { cotizacion = value; }
        }
    }
}
