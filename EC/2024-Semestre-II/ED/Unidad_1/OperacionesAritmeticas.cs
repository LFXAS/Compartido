using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_1
{
    internal class OperacionesAritmeticas
    {
        static void Main(string[] args)
        {
            int a, b; 
            try 
            {                
                Console.WriteLine("Ingrese primer operando:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese segundo operando:");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine("La suma es:" + (a + b));
                Console.WriteLine("La resta es:" + (a - b));
                Console.WriteLine("La multiplicación es:" + a * b);                
                Console.WriteLine("La división es:" + a / b);               
                Console.ReadKey();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadKey();
            }
        }
    }
}
