using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    public class AsignaturaCursada
    {
        private double nota, final;
        private Alumno paramAlumno;
        private Asignatura paramAsignatura;

        public AsignaturaCursada(double nota, double final, Asignatura paramAsignatura, Alumno paramAlumno)
        {
            this.nota = nota;
            this.final = final;
            this.paramAsignatura = paramAsignatura;
            this.paramAlumno = paramAlumno;
        }

        public double Nota { get => nota; set => nota = value; }
        public double Final { get => final; set => final = value; }
        public Alumno ParamAlumno { get => paramAlumno; set => paramAlumno = value; }
        public Asignatura ParamAsignatura { get => paramAsignatura; set => paramAsignatura = value; }
    }
}
