using System;


namespace ProyectoIntegrador
{
    public class Banco
    {
        private string nombre;
        private int codigo;

        public Banco(string nombre, int codigo)
        {
            this.Nombre = nombre;
            this.Codigo = codigo;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        
    }
}
