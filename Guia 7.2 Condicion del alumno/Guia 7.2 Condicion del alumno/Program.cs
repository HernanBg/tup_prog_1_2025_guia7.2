using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7._2_Condicion_del_alumno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la nota minimo para promocionar : ");
            double condicion = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del primer parcial : ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del segundo parcial : ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del tercer parcial : ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            

           double promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"El promedio es: {promedio:F2}");

            if (promedio >= condicion)
            {
                Console.WriteLine("¡Promocionado! Aprobaste sin rendir final.");
            }
            else 
            {
                Console.WriteLine("Debe rendir final.");
            }







        }
    }
}

