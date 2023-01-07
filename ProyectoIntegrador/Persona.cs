using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    public abstract class Persona
    {
        private int dni;
        private string nombre, direccion;

        public Persona(int dni, string nombre, string direccion)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Direccion = direccion;
        }

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public abstract string saludar();
    }
}
