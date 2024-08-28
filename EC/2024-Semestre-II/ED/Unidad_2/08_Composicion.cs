using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2
{
    /* COMPOSICIÓN
     
     * Explicación del Código
     * Clase Direccion:
     * Propiedades: Calle, Ciudad, CodigoPostal.
     * Constructor: Inicializa las propiedades Calle, Ciudad y CodigoPostal.
     * Método MostrarDireccion: Imprime la dirección completa.
     
     * Clase Persona:
     * Propiedades: Nombre, Edad, Direccion.
     * Constructor: Inicializa las propiedades Nombre, Edad y Direccion.
     * Método MostrarInformacion: Imprime el nombre, la edad y la dirección 
     * de la persona.
     
     * Clase Program:
     * Método Main: Punto de entrada del programa donde se crean y manipulan 
     * instancias de Persona y Direccion. 
     * 
     * Conceptos Clave:
     * Composición: Se refiere a una relación "tiene un" (has-a) entre clases. 
     * En este ejemplo, una Persona tiene una Direccion.
     
     * Instanciación: Se crean instancias de Direccion y se pasan 
     * como argumentos al constructor de Persona.
      
     * Métodos: Se usan métodos para mostrar información de los objetos.
     */

    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public string CodigoPostal { get; set; }

        public Direccion(string calle, string ciudad, string codigoPostal)
        {
            Calle = calle;
            Ciudad = ciudad;
            CodigoPostal = codigoPostal;
        }

        public void MostrarDireccion()
        {
            Console.WriteLine($"Calle: {Calle}, Ciudad: {Ciudad}, Código Postal: {CodigoPostal}");
        }
    }

    public class Persona4
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Direccion Direccion { get; set; } // Composición

        public Persona4(string nombre, int edad, Direccion direccion)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
            Direccion.MostrarDireccion();
        }
    }

    class Composicion
    {
        static void Main(string[] args)
        {
            // Crear una instancia de Direccion
            Direccion direccion1 = new Direccion("Calle Falsa 123", "Springfield", "12345");

            // Crear una instancia de Persona y asignarle una dirección
            Persona4 persona1 = new Persona4("Homer Simpson", 39, direccion1);

            // Mostrar la información de la persona
            persona1.MostrarInformacion();

            // Crear otra instancia de Direccion
            Direccion direccion2 = new Direccion("Avenida Siempre Viva 742", "Springfield", "54321");

            // Crear otra instancia de Persona y asignarle una dirección
            Persona4 persona2 = new Persona4("Marge Simpson", 36, direccion2);

            // Mostrar la información de la segunda persona
            persona2.MostrarInformacion();

            Console.ReadKey();
        }
    }
}
