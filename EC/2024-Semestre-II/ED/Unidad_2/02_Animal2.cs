using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2
{
    /* POLIMORFISMO POR ABSTRACCIÓN

     * Explicación del Código
     * Clase Abstracta Animal:
     * Propiedad: Nombre.
     * Constructor: Inicializa la propiedad Nombre.
     * Método Abstracto: HacerSonido es un método abstracto 
     * que debe ser implementado por las clases derivadas.
     * Método: MostrarInformacion que imprime el nombre del animal.

     * Clases Derivadas Perro y Gato:
     * Ambas heredan de Animal y proporcionan una implementación 
     * para el método abstracto HacerSonido.

     * Clase MainPolimorfismoAbstraccion:
     * Método Main: Punto de entrada del programa donde se crean 
     * objetos de las clases derivadas y se utilizan a través de 
     * referencias de la clase base Animal.         
     * 
     * Conceptos Clave: 
     * Clase Abstracta:
     * Una clase que no puede ser instanciada directamente y puede 
     * contener métodos abstractos que deben ser implementados por 
     * las clases derivadas.
     * 
     * Método Abstracto:
     * Un método que no tiene implementación en la clase base abstracta 
     * y debe ser sobrescrito en las clases derivadas.

     * Polimorfismo:
     * Permite usar una clase base para referenciar objetos de las 
     * clases derivadas. Los métodos sobrescritos en las clases derivadas 
     * se invocan de acuerdo al tipo del objeto al que hace referencia, 
     * no al tipo de la variable.
     */


    // Clase abstracta Animal
    public abstract class Animal2
        {
            public string Nombre { get; set; }

            // Constructor de la clase Animal
            public Animal2(string nombre)
            {
                Nombre = nombre;
            }

            // Método abstracto que debe ser implementado por las clases derivadas
            public abstract void HacerSonido();

            // Método para mostrar la información del animal
            public void MostrarInformacion()
            {
                Console.WriteLine($"Nombre: {Nombre}");
            }
        }

        // Clase derivada Perro
        public class Perro2 : Animal2
        {
            // Constructor de la clase Perro
            public Perro2(string nombre) : base(nombre) { }

            // Implementación del método abstracto HacerSonido
            public override void HacerSonido()
            {
                Console.WriteLine("El perro ladra: ¡Guau, guau!");
            }
        }

        // Clase derivada Gato
        public class Gato2 : Animal2
        {
            // Constructor de la clase Gato
            public Gato2(string nombre) : base(nombre) { }

            // Implementación del método abstracto HacerSonido
            public override void HacerSonido()
            {
                Console.WriteLine("El gato maúlla: ¡Miau, miau!");
            }
        }

        class MainPolimorfismoAbstraccion
        {
            static void Main(string[] args)
            {
                // Crear objetos de las clases derivadas
                Animal2 perro = new Perro2("Firulais");
                Animal2 gato = new Gato2("Misu");

                // Llamar a los métodos usando polimorfismo
                perro.MostrarInformacion();
                perro.HacerSonido();

                gato.MostrarInformacion();
                gato.HacerSonido();

                Console.ReadKey();
            }
        }    

}
