using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2
{
    /* POLIMORFISMO POR HERENCIA
  
     * Explicación del Código
     * Clase Base Animal:
     * Propiedad: Nombre.
     * Constructor: Inicializa la propiedad Nombre.
     * Método Virtual: HacerSonido que puede ser sobrescrito por las clases derivadas.
     * Método: MostrarInformacion que imprime el nombre del animal.
     
     * Clases Derivadas Perro y Gato:
     * Ambas heredan de Animal y sobrescriben el método HacerSonido 
     * para proporcionar su propia implementación.
     
     * Clase MainPolimorfismoHerencia:
     * Método Main: Punto de entrada del programa donde se crea un array de Animal 
     * que contiene instancias de Perro y Gato.
     * Se itera sobre el array y se llaman a los métodos MostrarInformacion 
     * y HacerSonido en cada objeto, demostrando el polimorfismo.  
     * 
     * Conceptos Clave:
     * Herencia:
     * Permite que una clase derivada herede propiedades y métodos de una clase base.
     * 
     * Polimorfismo:
     * Permite que una referencia de la clase base se comporte como una instancia 
     * de cualquier clase derivada. Los métodos sobrescritos en las clases derivadas 
     * se invocan de acuerdo al tipo real del objeto.
     
     * Métodos Virtuales y Sobrescritos:
     * Los métodos virtuales en la clase base pueden ser sobrescritos en las clases 
     * derivadas utilizando el modificador override.
     */

    // Clase base Animal
    public class Animal3
    {
        public string Nombre { get; set; }

        // Constructor de la clase Animal
        public Animal3(string nombre)
        {
            Nombre = nombre;
        }

        // Método virtual que puede ser sobrescrito por las clases derivadas
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }

        // Método para mostrar la información del animal
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
        }
    }

    // Clase derivada Perro
    public class Perro3 : Animal3
    {
        // Constructor de la clase Perro
        public Perro3(string nombre) : base(nombre) { }

        // Sobrescribir el método HacerSonido
        public override void HacerSonido()
        {
            Console.WriteLine("El perro ladra: ¡Guau, guau!");
        }
    }

    // Clase derivada Gato
    public class Gato3 : Animal3
    {
        // Constructor de la clase Gato
        public Gato3(string nombre) : base(nombre) { }

        // Sobrescribir el método HacerSonido
        public override void HacerSonido()
        {
            Console.WriteLine("El gato maúlla: ¡Miau, miau!");
        }
    }

    class MainPolimorfismoHerencia
    {
        static void Main(string[] args)
        {
            // Crear un array de animales
            Animal3[] animales = new Animal3[]
            {
                new Perro3("Firulais"),
                new Gato3("Misu"),
                new Perro3("Rex"),
                new Gato3("Tom")
            };

            // Iterar sobre el array y llamar a los métodos
            foreach (Animal3 animal in animales)
            {
                animal.MostrarInformacion();
                animal.HacerSonido();
            }

            Console.ReadKey();
        }
    }
}
