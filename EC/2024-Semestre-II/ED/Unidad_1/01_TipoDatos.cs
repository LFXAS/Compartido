using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_1
{
    internal class TipoDatos
    {
        static void Main(string[] args)
        {
            int numero = 10;
            float flotante = 12.5F;
            double valor = 14.5;
            char caracter = 'C';
            string palabra = "Murcielago";
            bool estado = true;

            Console.WriteLine("Entero:"+numero);
            Console.WriteLine("Flotante:" + flotante);
            Console.WriteLine("Double:" + valor);
            Console.WriteLine("Caracter:" + caracter);
            Console.WriteLine("Cadena de caracteres:" + palabra);
            Console.WriteLine("Booleano:" + estado);
            Console.ReadKey();
        }
    }
}
