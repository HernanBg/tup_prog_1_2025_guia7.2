using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7._2_Ej_5.Orden_que_ocurrió_el_menor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, menor, ordenMenor;

            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            menor = numero;      
            ordenMenor = 1;       

            for (int i = 2; i <= 5; i++)
            {
                Console.Write("Ingrese un número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero < menor)
                {
                    menor = numero;
                    ordenMenor = i;
                }
            }

            Console.WriteLine($"\nEl menor número se ingresó en la posición {ordenMenor}.");
        }

    }
    
}
