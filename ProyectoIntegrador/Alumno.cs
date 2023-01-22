using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    public class Alumno : Persona
    {
        private int idAlumno;


        public Alumno(int idAlumno, int dni, string nombre, string direccion) : base(dni, nombre, direccion)
        {
            this.IdAlumno = idAlumno;
        }


        public int IdAlumno { get => idAlumno; set => idAlumno = value; }




        //metodos
        public void inscribirMateria() { }
        public void inscribirCarrera() { }
        public void iniciarTramite() { }

        public override string saludar()
        {
            return "Hola, mi nombre es: " + Nombre + " y  mi dni es: " + Dni;
        }
    }
}