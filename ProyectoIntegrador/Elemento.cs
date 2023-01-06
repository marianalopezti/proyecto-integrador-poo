using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    public class Elemento
    {
        private string TipoElemento;
        public double Ancho;
        public double Alto;
        public double Peso;

        // PROPIEDADES
        public string getTipoElemento()
        {
            return TipoElemento;
        }

        public void setTipoElemento(string paramTipo)
        {
            TipoElemento = paramTipo;
        }
    }
}
