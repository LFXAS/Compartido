using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_1
{
    internal class BonoPorHijo
    {
        static void Main(string[] args)
        {
            double SUELDO, ARECIBIR;
            int NHIJO, BONO;
            string NOM, linea;
            Console.Write("NOMBRE EMPLEADO :"); NOM = Console.ReadLine();
            Console.Write("SUELDO EMPLEADO :"); linea = Console.ReadLine();
            SUELDO = double.Parse(linea);
            Console.Write("NÚMERO DE HIJOS :"); linea = Console.ReadLine();
            NHIJO = int.Parse(linea);

            if (NHIJO >= 3)             
              BONO = NHIJO * 10;
            else 
             BONO = NHIJO * 20;

            ARECIBIR = SUELDO + BONO;
            Console.WriteLine("RECIBE :" + String.Format("{0:c}", ARECIBIR));
            Console.Write("Pulse una Tecla:"); 
            Console.ReadKey();
        }
    }
}
