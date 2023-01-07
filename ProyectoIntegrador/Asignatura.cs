using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    public class Asignatura
    {
        private string nombre, tipo;
        private int horas, cuatrimetre;
        private Carrera Carrera;


        public Asignatura(string nombre, string tipo, int horas, int cuatrimetre, Carrera Carrera)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.horas = horas;
            this.cuatrimetre = cuatrimetre;
            this.Carrera = Carrera;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Horas { get => horas; set => horas = value; }
        public int Cuatrimetre { get => cuatrimetre; set => cuatrimetre = value; }
        public Carrera ParamCarrera { get => Carrera; set => Carrera = value; }
    }
}
