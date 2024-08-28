using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_1
{
    internal class Menu
    {
        const int MAX = 5;
        static void Main(string[] args)
        {
            int opcion;            
            int[] arreglo = new int[MAX];
            
            do
            {
                Console.Clear();
                Console.WriteLine("M E N U  P R I N C I P A L");
                Console.WriteLine("1.- Ingreso");
                Console.WriteLine("2.- Consulta");
                Console.WriteLine("3.- Busqueda");
                Console.WriteLine("4.- Modificación");
                Console.WriteLine("5.- Ordenamiento");
                Console.WriteLine("6.- Salir");
                Console.WriteLine("Digite la opción:");
                opcion =int.Parse(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        Console.Clear();
                        ingreso(arreglo);
                        break;
                    case 2:
                        Console.Clear();
                        mostrar(arreglo);
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 6);                                                
        }

        static void ingreso(int[] a)
        {
            for(int i=0; i<MAX; i++)
            {
                Console.WriteLine("Ingrese elemento en la posición {0}", i);
                a[i]=int.Parse(Console.ReadLine());
            }                
        }

        static void mostrar(int[] a)
        {
            for (int i = 0; i < MAX; i++)
                Console.WriteLine("Elemento en la posición [{0}]={1}", i, a[i]);                           
        }
    }
}
