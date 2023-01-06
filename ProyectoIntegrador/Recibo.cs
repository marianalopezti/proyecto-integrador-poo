using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    public class Recibo
    {
        public String TipoElemento;
        private double Valor;
        public int TotalDiario;

        public double getValor()
        {
            return Valor;
        }

        public void setValor(double paramValor)
        {
            Valor = paramValor;
        }
    }
}
