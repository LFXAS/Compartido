using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_1
{
    internal class FormatosSalida
    {
        static void Main(string[] args)
        {
            double BASE, ALTURA, RESUL;
            string linea;
            Console.Write("DIGITE LA BASE :"); linea = Console.ReadLine();
            BASE = double.Parse(linea);
            Console.Write("DIGITE LA ALTURA:"); linea = Console.ReadLine();
            ALTURA = double.Parse(linea);
            RESUL = (BASE * ALTURA) / 2;
            /*
             * String.Format("{0:####.00}", RESUL): Formatea el valor de RESUL para que se muestre con dos decimales, 
             * usando el formato ####.00. Si RESUL es 12.345, se mostrará como 12.35.             
             */
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:####.00}", RESUL));

            /*
             * String.Format("{0:c}", RESUL): Formatea el valor de RESUL como una moneda según la configuración regional del sistema.
             * Si RESUL es 1234.56, y el formato regional es para EE.UU., se mostrará como $1,234.56.
             */
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:c}", RESUL));

            /*
             * String.Format("{0:f}", RESUL): Formatea el valor de RESUL para mostrar un número fijo de decimales 
             * (por defecto, 2 decimales). Si RESUL es 12.3, se mostrará como 12.30.
             */
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:f}", RESUL));

            /*
             * String.Format("{0:g}", RESUL): Formatea el valor de RESUL en su forma más compacta, 
             * eliminando ceros innecesarios en los decimales o exponenciales. 
             * Por ejemplo, si RESUL es 1234.560, se mostrará como 1234.56.
             */
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:g}", RESUL));
            Console.WriteLine();

            /*
             * String.Format("Hoy es {0:F} ", DateTime.Now): Formatea la fecha y hora actuales (DateTime.Now) en un formato completo,
             * que incluye día, fecha, hora, minutos y segundos. Por ejemplo: "Hoy es lunes, 4 de septiembre de 2024 14:37:52".
             */
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:F} ", DateTime.Now));

            /*
             * String.Format("Hoy es {0:dddd} {0:dd/MM/yyyy} ", DateTime.Now): 
             * Formatea la fecha actual mostrando el nombre completo del día de la semana (dddd), 
             * seguido de la fecha en formato dd/MM/yyyy. Por ejemplo, "Hoy es lunes 04/09/2024".
             */
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:dddd} {0:dd/MM/yyy} ", DateTime.Now));
            Console.WriteLine("Pulse una Tecla...");
            Console.ReadKey();
        }
    }
}
