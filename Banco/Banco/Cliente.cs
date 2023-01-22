using System;

namespace ProyectoIntegrador
{
    public class Cliente : Persona
    {
        private string telefono;

        public Cliente(string nombre, int dni, string direccion, string telefono) : base(nombre, dni, direccion)
        {
            this.telefono = telefono;
        }

        public string Telefono { get => telefono; set => telefono = value; }
        public void extraer()
        {
            Console.WriteLine("Extraer");
        }

        public void depositar()
        {
            Console.WriteLine("Depositar");
        }
        public void transferir()
        {
            Console.WriteLine("Transferencia");
        }

        public override string ToString()
        {
            return "Hola, mi nombre es: " + Nombre;
        }

    }
}
