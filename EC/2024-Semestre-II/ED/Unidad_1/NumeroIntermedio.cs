using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_1
{
    internal class NumeroIntermedio
    {
        static void Main(string[] args)
        {
            int NUM1, NUM2, NUM3;
            string linea;
            Console.Write("PRIMER NÚMERO :"); linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            Console.Write("SEGUNDO NÚMERO :"); linea = Console.ReadLine();
            NUM2 = int.Parse(linea);
            Console.Write("TERCER NÚMERO :"); linea = Console.ReadLine();
            NUM3 = int.Parse(linea);
            Console.WriteLine();
            Console.Write("EL INTERMEDIO ES: ");

            if ((NUM1 > NUM2))
            {
                if ((NUM1 < NUM3))
                {
                    Console.WriteLine(NUM1);
                }
                else
                {
                    if ((NUM2 < NUM3))
                    {
                        Console.WriteLine(NUM3);
                    }
                    else
                    {
                        Console.WriteLine(NUM2);
                    }
                }
            }
            else
            {
                if ((NUM2 < NUM3))
                {
                    Console.WriteLine(NUM2);
                }
                else
                {
                    if ((NUM1 < NUM3))
                    {
                        Console.WriteLine(NUM3);
                    }
                    else
                    {
                        Console.WriteLine(NUM1);
                    }
                }
            }
            Console.Write("Pulse una Tecla:");
            Console.ReadKey();
        }
    }
}
