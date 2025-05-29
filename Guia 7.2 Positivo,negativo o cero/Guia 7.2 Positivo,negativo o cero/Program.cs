using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7._2_Positivo_negativo_o_cero
{
    internal class Program
    {
        static void Main(string[] args)
        {
       

            Console.WriteLine("Ingrese un Numero ");
            Double num = Convert.ToDouble(Console.ReadLine());


            if (num < 0)
            {
                Console.WriteLine("El numero es negativo ");

            }
            else
            {
                if (num == 0)
                {
                    Console.WriteLine("El numero es 0 ");

                }
                else
                {
                    Console.WriteLine("El numero es positivo");
                }





            }





        }
    }
}
