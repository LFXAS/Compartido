using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_1
{
    internal class EstadoCivil
    {
        static void Main(string[] args)
        {
            char ECIVIL;
            string linea;
            bool estado = true;

            do
            {
                Console.Write("DIGITE C,S,V,D :"); linea = Console.ReadLine();
                ECIVIL = char.Parse(linea);
                if (ECIVIL == 'C' || ECIVIL == 'S' || ECIVIL == 'V' || ECIVIL == 'D')
                    estado = false;
            } while (estado);
            
            switch (ECIVIL)
            {
                case 'C':
                    Console.WriteLine("CASADO");
                    break;
                case 'S': 
                    Console.WriteLine("SOLTERO");
                    break;
                case 'V':
                    Console.WriteLine("VIUDO");
                    break;
                case 'D':
                    Console.WriteLine("DIVORCIADO");
                    break;
                default:
                    Console.WriteLine("NO EXISTE");
                    break;
            }
            Console.Write("Pulse una Tecla:"); 
            Console.ReadKey();        
        }
    }
}
