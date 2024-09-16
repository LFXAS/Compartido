using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2
{
    /* CONCEPTOS BÁSICO: CLASE, OBJETO, ABSTRACCIÓN Y ENCAPSULAMIENTO
     
    * Clase Definición: Una clase es una plantilla o blueprint a partir 
    * de la cual se crean objetos. 
    * Define un conjunto de propiedades y métodos que son comunes 
    * a todos los objetos de ese tipo.
    * 
    * Objeto Definición: Un objeto es una instancia de una clase. 
    * Representa una entidad concreta con un estado y un 
    * comportamiento definido por las propiedades y métodos de su clase.
    * 
    * Abstracción Definición: La abstracción es el proceso de ocultar 
    * los detalles de implementación y mostrar solo la 
    * funcionalidad esencial de un objeto. 
    * Se centra en lo que un objeto hace, en lugar de cómo lo hace.
    * 
    * Encapsulamiento Definición: El encapsulamiento es el concepto
    * de agrupar datos (propiedades) y métodos que operan sobre 
    * esos datos en una sola unidad (la clase). 
    * Además, restringe el acceso directo a algunas de las 
    * propiedades o métodos de un objeto. 
    * Esto se logra mediante modificadores de acceso 
    * como private, protected y public.
    */
    internal class Persona
    {
        private string nombre;
        private int edad;

        // Propiedades de la clase Persona
        //public string Nombre { get; set; }
        //public int Edad { get; set; }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }



        // Constructor de la clase Persona
        /*public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }*/

        // Método de la clase Persona
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
    
        }
    }

    class MainMiPrimeraClase
    {
        static void Main(string[] args)
        {
            // Crear un objeto de la clase Persona
            //Persona persona1 = new Persona("Juan", 25);
            Persona persona2 = new Persona();
            persona2.Nombre = "Pablo";
            persona2.Edad = 25;
            //Llamar al método MostrarInformacion
            persona2.MostrarInformacion();
            //Console.WriteLine("Nombre de la persona:{0}", persona1.Nombre);
            //Console.WriteLine("Edad de la persona:{0}", persona1.Edad);
            Console.ReadKey();
        }
    }
}
