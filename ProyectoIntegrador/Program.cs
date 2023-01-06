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
            Elemento e = new Elemento();
            e.Alto = 350;
            e.Ancho = 100;
            e.Peso = 200;
            e.setTipoElemento("Envase de gaseosa");

            Elemento b = new Elemento();
            b.Alto = 120;
            b.Ancho = 50;
            b.Peso = 50;
            b.setTipoElemento("Botella de vidrio");

            int alto, ancho, peso;


            Console.WriteLine("Ingrese alto del producto: ");
            alto = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese ancho del producto: ");
            ancho = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese peso del producto: ");
            peso = int.Parse(Console.ReadLine());

            if(alto > 0 && ancho > 0 && peso > 0)
            {
                // si se cumplen las tres condiciones me muestra por consola el tipo de elemento "Envase de gaseosa"
                if(alto== 350 && ancho== 100 && peso == 200)
                {
                    Console.WriteLine("Tipo: " + e.getTipoElemento());
                }
                // si se cumplen las tres condiciones me muestra por consola el tipo de elemento "Botella de vidrio"
                if (alto == 120 && ancho == 50 && peso == 50)
                {
                    Console.WriteLine("Tipo: " + b.getTipoElemento());
                }
                else
                {
                    Console.WriteLine("Ese producto no existe");
                }
            }

            Console.ReadKey();

            //Recibo r = new Recibo();
            //r.TipoElemento = e.getTipoElemento();
            //r.TotalDiario = 100;
            //r.setValor(250);

            //Console.WriteLine("Datos del recibo:");
            //Console.WriteLine("Tipo de elemento: " + r.TipoElemento);
            //Console.WriteLine("Total: " + r.TotalDiario);
            //Console.WriteLine("Valor: " + r.getValor());

            //Console.ReadKey();

        }
    }
}
