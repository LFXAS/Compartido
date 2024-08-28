using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2
{
    /* HERENCIA MÚLTIPLE
     
     * En C#, no se admite la herencia múltiple directa de clases. 
     * Sin embargo, se puede lograr un comportamiento similar 
     * utilizando interfaces. 
     * Las interfaces permiten que una clase implemente múltiples 
     * conjuntos de funcionalidades, emulando la herencia múltiple.
     * 
     * Explicación del Código
     * Interfaces ICaminable y IVolable:
     * Ambas interfaces declaran un método: Caminar en ICaminable y Volar en IVolable.
     
     * Clase Pajaro:
     * Implementa ambas interfaces ICaminable y IVolable.
     * Proporciona implementaciones para los métodos Caminar y Volar.
     * Tiene una propiedad Nombre y un método MostrarInformacion.
     * 
     * Clase MainHerenciaMultiple:
     * Método Main donde se crea un objeto de la clase Pajaro y se llaman 
     * a los métodos definidos en las interfaces y la clase.    
     * 
     * Conceptos Clave:
     * Interfaces:
     * Definen un contrato que las clases deben cumplir. 
     * No contienen implementación de métodos, solo su firma.
     
     * Implementación de Interfaces:
     * Una clase puede implementar múltiples interfaces, 
     * proporcionando una forma de herencia múltiple en términos de funcionalidad.
     */

    // Definición de la interfaz ICaminable
    public interface ICaminable
    {
        void Caminar();
    }

    // Definición de la interfaz IVolable
    public interface IVolable
    {
        void Volar();
    }

    // Definición de la clase Pajaro que implementa ambas interfaces
    public class Pajaro : ICaminable, IVolable
    {
        public string Nombre { get; set; }

        // Constructor de la clase Pajaro
        public Pajaro(string nombre)
        {
            Nombre = nombre;
        }

        // Implementación del método Caminar de la interfaz ICaminable
        public void Caminar()
        {
            Console.WriteLine($"{Nombre} está caminando.");
        }

        // Implementación del método Volar de la interfaz IVolable
        public void Volar()
        {
            Console.WriteLine($"{Nombre} está volando.");
        }

        // Método para mostrar la información del pájaro
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
        }
    }

    class MainHerenciaMultiple
    {
        static void Main(string[] args)
        {
            // Crear un objeto de la clase Pajaro
            Pajaro pajaro = new Pajaro("Tweety");

            // Llamar a los métodos
            pajaro.MostrarInformacion();
            pajaro.Caminar();
            pajaro.Volar();

            Console.ReadKey();
        }
    }
}
