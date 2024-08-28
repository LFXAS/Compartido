using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2
{
    /* LISTA DE OBJETOS 
     
     * Explicación del Código
     * Clase Persona:
     * Propiedades: Nombre y Edad.
     * Constructor: Inicializa las propiedades Nombre y Edad.
     * Método MostrarInformacion: Imprime el nombre y la edad de la persona.
     
     * Clase MainListaObjetos:
     * Método Main: Punto de entrada del programa donde se crea y 
     * manipula una lista de objetos Persona.
     * 
     * Conceptos Clave:
     * List: Una colección genérica en C# que permite almacenar 
     * objetos de cualquier tipo. Proporciona métodos para agregar, eliminar y acceder a los elementos.
     * Métodos de List:
     * Add(T item): Agrega un objeto al final de la lista.
     * RemoveAt(int index): Elimina el objeto en el índice especificado.
     * foreach: Un bucle para iterar sobre cada objeto en la lista.
     */

    // Definición de la clase Persona
    public class Persona2
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona2(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }

    class MainListaObjetos
    {
        static void Main(string[] args)
        {
            // Crear una lista de objetos Persona
            List<Persona2> listaPersonas = new List<Persona2>();

            // Agregar objetos a la lista
            listaPersonas.Add(new Persona2("Juan", 25));
            listaPersonas.Add(new Persona2("María", 30));
            listaPersonas.Add(new Persona2("Pedro", 22));

            // Acceder y mostrar información de los objetos en la lista
            foreach (Persona2 persona in listaPersonas)
            {
                persona.MostrarInformacion();
            }

            // Eliminar un objeto de la lista
            listaPersonas.RemoveAt(1); // Eliminar el segundo elemento (María)

            Console.WriteLine("\nDespués de eliminar a María:");

            // Mostrar la lista actualizada
            foreach (Persona2 persona in listaPersonas)
            {
                persona.MostrarInformacion();
            }
            Console.ReadKey();
        }
    }
}
