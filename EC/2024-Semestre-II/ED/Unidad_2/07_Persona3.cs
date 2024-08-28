using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2
{
    /* ARREGLO DE OBJETOS
      
     * Explicación del Código
     * Clase Persona:
     * Propiedades: Nombre y Edad.
     * Constructor: Inicializa las propiedades Nombre y Edad.
     * Método MostrarInformacion: Imprime el nombre y la edad de la persona.
     * 
     * Clase MainArregloObjetos:
     * Método Main: Punto de entrada del programa donde se crea y
     * manipula un arreglo de objetos Persona. 
     * 
     * Conceptos Clave:
     * Array (Arreglo): Una estructura de datos que almacena un número fijo 
     * de elementos del mismo tipo. Los elementos se acceden mediante índices.
     * 
     * Inicialización del Arreglo: Crear y asignar valores a los elementos del arreglo.
     * 
     * Acceso a Elementos: Usar índices para acceder a elementos específicos del arreglo.
     * 
     * Modificación de Elementos: Cambiar los valores de los elementos del arreglo.
     */

    // Definición de la clase Persona
    public class Persona3
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        // Constructor de la clase Persona
        public Persona3(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Método para mostrar la información de la persona
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }

    class MainArregloObjetos
    {
        static void Main(string[] args)
        {
            // Crear un arreglo de objetos Persona
            Persona3[] personas = new Persona3[3];

            // Inicializar el arreglo con objetos Persona
            personas[0] = new Persona3("Juan", 25);
            personas[1] = new Persona3("María", 30);
            personas[2] = new Persona3("Pedro", 22);

            // Acceder y mostrar información de los objetos en el arreglo
            foreach (Persona3 persona in personas)
            {
                persona.MostrarInformacion();
            }

            // Modificar un objeto en el arreglo
            personas[1].Nombre = "Ana";
            personas[1].Edad = 31;

            Console.WriteLine("\nDespués de modificar el segundo elemento:");

            // Mostrar la información actualizada
            foreach (Persona3 persona in personas)
            {
                persona.MostrarInformacion();
            }

            Console.ReadKey();
        }
    }
}
