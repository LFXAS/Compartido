using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2
{
    /* MÉTODOS SOBRECARGADOS
     
     * Explicación del Código
     * Clase Calculadora:
     * Método Sumar(int a, int b): Suma dos números enteros.
     * Método Sumar(int a, int b, int c): Suma tres números enteros.
     * Método Sumar(double a, double b): Suma dos números de tipo double.
     * Método Sumar(params int[] numeros): Suma un conjunto variable de 
     * números enteros utilizando un array.
     * 
     * Clase MainCalculadora:
     * Método Main: Punto de entrada del programa donde se crean 
     * instancias de Calculadora y se llaman a los métodos Sumar con 
     * diferentes argumentos para demostrar la sobrecarga. 
     * 
     * Conceptos Clave:
     * Sobrecarga de Métodos:
     * Permite definir múltiples métodos con el mismo nombre dentro de 
     * la misma clase, pero con diferentes firmas 
     * (diferente número de parámetros o tipos de parámetros).
     * 
     * El compilador decide cuál método llamar en tiempo de compilación 
     * basado en los argumentos proporcionados en la llamada al método.
     */
    public class Calculadora
    {
        // Método Sumar con dos parámetros enteros
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        // Método Sumar con tres parámetros enteros
        public int Sumar(int a, int b, int c)
        {
            return a + b + c;
        }

        // Método Sumar con dos parámetros de tipo double
        public double Sumar(double a, double b)
        {
            return a + b;
        }

        // Método Sumar con un array de enteros
        public int Sumar(params int[] numeros)
        {
            int suma = 0;
            foreach (int num in numeros)
            {
                suma += num;
            }
            return suma;
        }
    }

    class MainCalculadora
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            // Llamadas a los métodos sobrecargados
            Console.WriteLine(calc.Sumar(3, 4));           // Suma de dos enteros
            Console.WriteLine(calc.Sumar(1, 2, 3));        // Suma de tres enteros
            Console.WriteLine(calc.Sumar(2.5, 3.7));       // Suma de dos doubles
            Console.WriteLine(calc.Sumar(1, 2, 3, 4, 5));  // Suma de un array de enteros
            Console.WriteLine(calc.Sumar(10, 20, 30, 40, 50));  // Suma de un array de enteros
            Console.ReadKey();
        }
    }
}
