using ProyectoIntegrador;
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
            Console.Write("******* Banco *******\n");

            Banco banco = new Banco("HSBC", 200);
            Console.WriteLine("Nombre del banco: " + banco.Nombre);
            Console.WriteLine("Codigo: " + banco.Codigo + "\n");


            Cuenta cuenta = new Cuenta("01/05/2022", "1237848", 43999, 12, 60);
            Console.WriteLine("Fecha de apertura: " + cuenta.FechaApertura);
            Console.WriteLine("Numero de cuenta: " + cuenta.Numero);
            Console.WriteLine("Saldo: " + cuenta.Saldo);
            Console.WriteLine("Meses: " + cuenta.Meses);
            Console.WriteLine("Intereses: " + cuenta.Interes + "\n");


            Valor valor = new Valor("USD", "Dolar", 179);
            Console.WriteLine("Valor: " + valor.Texto);
            Console.WriteLine("Moneda: " + valor.Nombre);
            Console.WriteLine("Cotizacion: " + valor.Cotizacion + "\n");


            Sucursal sucursal = new Sucursal("1", "direccion 1");
            Console.WriteLine("ID Sucursal: " + sucursal.IdSucursal);
            Console.WriteLine("Direccion de la sucursal: " + sucursal.Direccion + "\n");


            FondoDeInversion fondoDeInversion = new FondoDeInversion("11/07/2011", "11/08/2015", "ICBC", 30, 25);
            Console.WriteLine("Fecha de Apertura: " + fondoDeInversion.FechaApertura);
            Console.WriteLine("Fecha de Vencimiento: " + fondoDeInversion.FechaVencimiento);
            Console.WriteLine("Nombre: " + fondoDeInversion.Nombre);
            Console.WriteLine("Importe: " + fondoDeInversion.Importe);
            Console.WriteLine("Rentabilidad: " + fondoDeInversion.Rentabilidad + "\n");


            CarteraDeValores carteraDeValores = new CarteraDeValores(valor);
            Console.WriteLine("Cartera de valor: " + carteraDeValores.Valores.Texto + "\n");



            Cliente varCliente = new Cliente("Agustin", 23858949, "Ezpeleta 456", "123590087");
            Console.WriteLine("Nombre del cliente: " + varCliente.Nombre);
            Console.WriteLine("Dni: " + varCliente.Dni);
            Console.WriteLine("Direccion: " + varCliente.Direccion);
            Console.WriteLine("Telefono: " + varCliente.Telefono + "\n");


            TarjetaDeCredito tarjeta = new TarjetaDeCredito("20/12/2019", "231231", "Mastercard", "Agustin");
            Console.WriteLine("Fecha de Vencimiento: " + tarjeta.FechaVencimiento);
            Console.WriteLine("Numero de tarjeta: " + tarjeta.Numero);
            Console.WriteLine("Tipo de tarjeta: " + tarjeta.Tipo);
            Console.WriteLine("Titular: " + tarjeta.Titular + "\n");

            Console.ReadKey();
        }
    }
}