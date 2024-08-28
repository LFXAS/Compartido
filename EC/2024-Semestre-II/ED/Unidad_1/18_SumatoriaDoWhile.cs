using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_1
{
    internal class SumatoriaDoWhile
    {
        static void Main(string[] args)
        {
            int numeroTerminos = 0;
            double s = 0, c = 0;
            //Ingreso de datos
            Console.WriteLine("Ingrese el número de términos que desea generar y sumar de la serie 1/n:");
            numeroTerminos = int.Parse(Console.ReadLine());

            //Proceso
            do
            {
                c = c +1;
                s = s + 1 / c;
            } while (c<numeroTerminos);

            //Salida
            Console.WriteLine("El resultado de la sumatoria de la serie 1/n es:" + s);
            Console.ReadKey();
        
        }
    }
}
