using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7._2_EJ4_Mayor_valor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, mayor;
            Console.WriteLine("Ingrese un numero ");
            numero = Convert.ToInt32(Console.ReadLine());
            mayor = numero;


            for (int i = 2; i <= 5; i++)
            {
                Console.WriteLine("Ingrese un numero ");
                numero = Convert.ToInt32(Console.ReadLine());
               


                if (numero > mayor)
                {
                    mayor = numero;
                }

            }

            Console.WriteLine("\nEl mayor numero ingresado fue " +mayor);













        }
    }
}
