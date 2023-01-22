using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrera paramCarrera = new Carrera("Ingeniería en Informática", "Florencio Varela");
            Alumno paramAlumno = new Alumno(1155991, 45015414, "Agustin", "ezpeleta 347");
            Profesor paramProfe = new Profesor(891273, 36987100, "Maximiliano Principe", "N/S", "Programacion orientada a objetos", "Ingeniería");
            Asignatura paramAsignatura = new Asignatura("Programacion orientada a objetos", "Obligatoria", 5, 1, paramCarrera);
            AsignaturaCursada paramAsigCursada = new AsignaturaCursada(8.5, 9.5, paramAsignatura, paramAlumno);

            Console.Write("********************* HISTORIA ACADÉMICA ********************\n");
            Console.WriteLine($"Nombre: {paramAlumno.Nombre} \nCarrera: {paramCarrera.Nombre}\nProfesor: {paramProfe.Nombre}\nSede: {paramAsignatura.ParamCarrera.Sede}");
            Console.WriteLine($"Nota Final: {paramAsigCursada.Final}\nMateria: {paramAsigCursada.ParamAsignatura.ParamCarrera.Nombre}");
            Console.WriteLine(paramAlumno.saludar());

            Console.ReadKey();

        }
    }
}