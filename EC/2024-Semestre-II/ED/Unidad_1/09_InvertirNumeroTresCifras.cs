﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_1
{
    internal class InvertirNumeroTresCifras
    {
        static void Main(string[] args)
        {
            int NUM, AUX, DEC, UNI, CEN;
            string linea;
            Console.WriteLine("INGRESE NÚMERO DE TRES CIFRAS :");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);
            CEN = NUM / 100;
            NUM = NUM % 100;
            
            DEC = NUM / 10;
            UNI = NUM % 10;
            AUX = (UNI * 100) + (DEC * 10) + CEN;
            Console.WriteLine("NÚMERO INVERTIDO ES: " + AUX);
            Console.WriteLine("Pulse una Tecla...");
            Console.ReadKey();
        }
    }
}
