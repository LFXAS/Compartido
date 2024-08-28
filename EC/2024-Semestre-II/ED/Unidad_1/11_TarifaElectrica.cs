using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_1
{
    internal class TarifaElectrica
    {
        static void Main(string[] args)
        {
            int CANKV;
            double TOT, COSKV;
            COSKV = 0;
            string linea;
            Console.Write("Cantidad de Kilovatios :"); linea = Console.ReadLine();
            CANKV = int.Parse(linea);
            if ((CANKV <= 1000)) COSKV = 0.14;
            if (((CANKV > 1000) & (CANKV <= 1800))) COSKV = 0.12;
            if ((CANKV > 1800)) COSKV = 0.8;
            TOT = CANKV * COSKV;
            Console.WriteLine("A PAGAR: " + TOT);
            Console.Write("Pulse una Tecla:"); 
            Console.ReadKey();
        }
    }
}
