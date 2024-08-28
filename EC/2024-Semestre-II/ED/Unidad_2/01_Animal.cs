using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2
{

    /* HERENCIA SIMPLE Y SOBRESCRITURA DE MÉTODOS (POLIMORFISMO)
     
     * Explicación del Código
     * Clase Base Animal:
     * Propiedad Nombre.
     * Constructor que inicializa la propiedad Nombre.
     * Método virtual HacerSonido que puede ser sobrescrito por las clases derivadas.
     * Método MostrarInformacion que muestra el nombre del animal.
     * 
     * Clases Derivadas Perro y Gato:
     * Ambas heredan de Animal.
     * Sobrescriben el método HacerSonido para proporcionar su propia implementación.
     * 
     * Clase MainHerenciaSimple:
     * Método Main donde se crean objetos de las clases derivadas y se llaman a los métodos 
     * correspondientes.
     
     * Conceptos Clave:
     * Herencia:
     * Permite crear una nueva clase basada en una clase existente. La nueva clase (derivada) 
     * hereda las propiedades y métodos de la clase base.     
     
     * Polimorfismo:
     * Permite usar una clase derivada a través de una referencia de la clase base y 
     * sobrescribir métodos para proporcionar una implementación específica.

     * Métodos Virtuales y Sobrescritos:
     * Los métodos virtuales en la clase base pueden ser sobrescritos en las clases derivadas 
     * usando el modificador override.     
     */

    // Clase base Animal
    public class Animal
    {
        public string Nombre { get; set; }

        // Constructor de la clase base Animal
        public Animal(string nombre)
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
    public class Perro : Animal
    {
        // Constructor de la clase derivada Perro
        public Perro(string nombre) : base(nombre) { }

        // Sobrescribir el método HacerSonido
        public override void HacerSonido()
        {
            Console.WriteLine("El perro ladra: ¡Guau, guau!");
        }
    }

    // Clase derivada Gato
    public class Gato : Animal
    {
        // Constructor de la clase derivada Gato
        public Gato(string nombre) : base(nombre) { }

        // Sobrescribir el método HacerSonido
        public override void HacerSonido()
        {
            Console.WriteLine("El gato maúlla: ¡Miau, miau!");
        }
    }

    class MainHerenciaSimple
    {
        static void Main(string[] args)
        {
            // Crear objetos de las clases derivadas
            Animal perro = new Perro("Firulais");
            Animal gato = new Gato("Misu");

            // Llamar a los métodos
            perro.MostrarInformacion();
            perro.HacerSonido();

            gato.MostrarInformacion();
            gato.HacerSonido();
            Console.ReadKey();
        }
    }
}
