using System;


namespace ProyectoIntegrador
{
    public abstract class Persona
    {
        private string nombre, direccion;
        private int dni;

        public Persona(string nombre, int dni, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Dni { get => dni; set => dni = value; }

        public abstract override string ToString();
        
    }
}
