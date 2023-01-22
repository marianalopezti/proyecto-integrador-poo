using System;
using System.Collections.Generic;
using System.Diagnostics;
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


            Elemento e1 = new Elemento("Envase de cerveza", 90, 380, 500);

            e1.mostrarDatos();

            Console.WriteLine("");
            

            int alto, ancho, peso;

            Console.WriteLine("Ingrese alto del producto: ");
            alto = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese ancho del producto: ");
            ancho = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese peso del producto: ");
            peso = int.Parse(Console.ReadLine());

            if (alto > 0 && ancho > 0 && peso > 0)
            {
                // si se cumplen las tres condiciones me muestra por consola el tipo de elemento "Envase de gaseosa"
                if (alto == 350 && ancho == 100 && peso == 200)
                {
                    Console.WriteLine("Tipo: " + e.getTipoElemento());
                    Recibo r = new Recibo();
                    r.TipoElemento = e.getTipoElemento();
                    r.TotalDiario = 100;
                    r.setValor(250);

                    Console.WriteLine("Datos del recibo:");
                    Console.WriteLine("Tipo de elemento: " + r.TipoElemento);
                    Console.WriteLine("Total: " + r.TotalDiario);
                    Console.WriteLine("Valor: " + r.getValor());

                    Console.ReadKey();
                }
                // si se cumplen las tres condiciones me muestra por consola el tipo de elemento "Botella de vidrio"
                if (alto == 120 && ancho == 50 && peso == 50)
                {
                    Console.WriteLine("Tipo: " + b.getTipoElemento());
                    Recibo r = new Recibo();
                    r.TipoElemento = b.getTipoElemento();
                    r.TotalDiario = 100;
                    r.setValor(250);

                    Console.WriteLine("Datos del recibo:");
                    Console.WriteLine("Tipo de elemento: " + r.TipoElemento);
                    Console.WriteLine("Total: " + r.TotalDiario);
                    Console.WriteLine("Valor: " + r.getValor());


                    Recibo r1 = new Recibo(e1.getTipoElemento(), 400, 10);
                    r1.mostrarDatos();

                }

                // En el caso del else no se muestra correctamente
            }
           
            Console.ReadKey();
        }
        public class Elemento
        {
            private string TipoElemento;
            public double Ancho;
            public double Alto;
            public double Peso;

            public Elemento() { }
            public Elemento(string paramTipo, double paramAncho, double paramAlto, double paramPeso)
            {
                TipoElemento = paramTipo;
                Ancho = paramAncho;
                Alto = paramAlto;
                Peso = paramPeso;
            }

            public void mostrarDatos()
            {
                Console.WriteLine("Datos del elemento:");
                Console.WriteLine("Peso: " + Peso);
                Console.WriteLine("Alto: " + Alto);
                Console.WriteLine("Ancho: " + Ancho);
                Console.WriteLine("Tipo: " + getTipoElemento());
            }

            public string getTipoElemento()
            {
                return TipoElemento;
            }

            public void setTipoElemento(string paramTipo)
            {
                TipoElemento = paramTipo;
            }
        }
        public class Recibo
        {
            public string TipoElemento;
            private double Valor;
            public int TotalDiario;

            public Recibo() { }
            public Recibo(string paramTipo, double paramValor, int paramTotal)
            {
                TipoElemento = paramTipo;
                Valor = paramValor;
                TotalDiario = paramTotal;
            }

            public void mostrarDatos()
            {
                Console.WriteLine("Datos del recibo:");
                Console.WriteLine("Tipo de elemento: " + TipoElemento);
                Console.WriteLine("Total: " + TotalDiario);
                Console.WriteLine("Valor: " + getValor());
            }
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
}