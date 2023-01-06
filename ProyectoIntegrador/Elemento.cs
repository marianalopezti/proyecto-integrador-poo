using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    public class Elemento
    {
        private String TipoElemento;
        public double Ancho;
        public double Alto;
        public double Peso;

        // PROPIEDADES
        public String getTipoElemento()
        {
            return TipoElemento;
        }

        public void setTipoElemento(String paramTipo)
        {
            TipoElemento = paramTipo;
        }
    }
}
