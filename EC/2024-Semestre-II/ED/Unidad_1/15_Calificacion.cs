using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_1
{
    internal class Calificacion
    {
        static void Main(string[] args)
        {
            int NOTA;
            string linea;
            Console.Write("DIGITE CALIFICACIÓN:"); linea = Console.ReadLine();
            NOTA = byte.Parse(linea);
            switch (NOTA)
            {
                case 19:
                case 20:
                    ; Console.WriteLine("SOBRESALIENTE");
                    break;
                case 16:
                case 17:
                case 18:
                    ; Console.WriteLine("MUY BUENA");
                    break;
                case 14:
                case 15:
                    ; Console.WriteLine("BUENA");
                    break;
                case 12:
                case 13:
                    ; Console.WriteLine("REGULAR");
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("INSUFICIENTE");
                    break;
                default:
                    Console.WriteLine("FUERA DE RANGO");
                    break;
            }
            Console.Write("Pulse una Tecla..."); 
            Console.ReadKey();
        }
    }
}
