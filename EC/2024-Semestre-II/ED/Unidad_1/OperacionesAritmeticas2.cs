using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_1
{
    internal class OperacionesAritmeticas2
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

                double c = (double)a/ b;

                /* La división por cero con números de punto flotante (double en este caso) 
                 * en C# no lanza una excepción DivideByZeroException como lo hace con números enteros. 
                 * En su lugar, produce un valor especial llamado "Infinity" o "NaN" (Not a Number). 
                 * 
                 * En este caso, verificamos si el resultado de la división es Infinity (double.IsInfinity(resultado)) o NaN (double.IsNaN(resultado)). 
                 * Si es así, lanzamos una excepción personalizada ArithmeticException. 
                 * Esto manejará la situación en la que el divisor es cero sin lanzar una excepción específica de división por cero.
                 */

                if (double.IsInfinity(c) || double.IsNaN(c))
                {
                    throw new ArithmeticException("División por cero");
                }
                Console.WriteLine("El resultado de la división es: " + c);
                Console.ReadKey();
            }
            catch (ArithmeticException ex)
            {
                // Manejo de la excepción de división por cero
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadKey();
            }
            finally
            {
                // Este bloque se ejecuta siempre, ocurra o no ocurra una excepción
                Console.WriteLine("El programa ha terminado.");
                Console.ReadKey();
            }
        }
    }
}
