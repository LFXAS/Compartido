using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_1
{
    internal class SumatoriaWhile
    {
        static void Main(string[] args)
        {
            int numeroTerminos = 0, c = 1;
            double s = 0;
            //Ingreso de datos
            Console.WriteLine("Ingrese el número de términos que desea generar y sumar de la serie 1/n:");
            numeroTerminos = int.Parse(Console.ReadLine());

            //Proceso
            while(c <= numeroTerminos)
            {
                s = s + 1.0 / c;
                c++;
            }

            //Salida
            Console.WriteLine("El resultado de la sumatoria de la serie 1/n es:" + s);
            Console.ReadKey();

        }
    }
}
