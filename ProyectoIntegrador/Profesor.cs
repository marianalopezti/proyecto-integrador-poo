using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    public class Profesor : Persona
    {
        private int dni, legajo;
        private string nombre, direccion, asignaturaCarrera, departamento;


        public Profesor(int dni, int legajo, string nombre, string direccion, string asignaturaCarrera, string departamento) : base(dni, nombre, direccion)
        {
            this.legajo = legajo;
            this.asignaturaCarrera = asignaturaCarrera;
            this.departamento = departamento;
        }

        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        public string AsignaturaCarrera
        {
            get { return asignaturaCarrera; }
            set { asignaturaCarrera = value; }
        }
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        public override string saludar()
        {
            return "Hola soy un profesor";
        }
    }
}
