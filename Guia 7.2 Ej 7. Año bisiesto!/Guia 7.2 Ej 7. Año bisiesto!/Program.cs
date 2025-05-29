using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7._2_Ej_7.Año_bisiesto_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int año;

            Console.Write("Ingrese un año: ");
            año = Convert.ToInt32(Console.ReadLine());

            if (año % 4 == 0)
            {
                if (año % 100 != 0 || año % 400 == 0)
                {
                    Console.WriteLine("El año " + año + " es bisiesto.");
                }
                else
                {
                    Console.WriteLine("El año " + año + " no es bisiesto.");
                }
            }
            else
            {
                Console.WriteLine("El año " + año + " no es bisiesto.");
            }
        }
    }
}
