using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    public class Carrera
    {
        private string nombre, sede;

        //constructor de clase
        public Carrera(string nombre, string sede)
        {
            this.nombre = nombre;
            this.sede = sede;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Sede
        {
            get { return sede; }
            set { sede = value; }
        }
    }
}
