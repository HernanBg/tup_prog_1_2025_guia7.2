using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7._2_Lista_ordenada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                
                Console.Write("Ingrese el nombre del alumno 1: ");
                string nombre1 = Console.ReadLine();
                Console.Write("Ingrese el número de libreta del alumno 1: ");
                int libreta1 = Convert.ToInt32(Console.ReadLine());

                
                Console.Write("Ingrese el nombre del alumno 2: ");
                string nombre2 = Console.ReadLine();
                Console.Write("Ingrese el número de libreta del alumno 2: ");
                int libreta2 = Convert.ToInt32(Console.ReadLine());

                
                Console.Write("Ingrese el nombre del alumno 3: ");
                string nombre3 = Console.ReadLine();
                Console.Write("Ingrese el número de libreta del alumno 3: ");
                int libreta3 = Convert.ToInt32(Console.ReadLine());

               
                string tempNombre;
                int tempLibreta;

                if (libreta1 > libreta2)
                {
                    tempLibreta = libreta1; libreta1 = libreta2; libreta2 = tempLibreta;
                    tempNombre = nombre1; nombre1 = nombre2; nombre2 = tempNombre;
                }

                if (libreta1 > libreta3)
                {
                    tempLibreta = libreta1; libreta1 = libreta3; libreta3 = tempLibreta;
                    tempNombre = nombre1; nombre1 = nombre3; nombre3 = tempNombre;
                }

                if (libreta2 > libreta3)
                {
                    tempLibreta = libreta2; libreta2 = libreta3; libreta3 = tempLibreta;
                    tempNombre = nombre2; nombre2 = nombre3; nombre3 = tempNombre;
                }

               
                Console.WriteLine("\nLista ordenada por número de libreta:");
                Console.WriteLine($"Nombre: {nombre1}, Libreta: {libreta1}");
                Console.WriteLine($"Nombre: {nombre2}, Libreta: {libreta2}");
                Console.WriteLine($"Nombre: {nombre3}, Libreta: {libreta3}");
            }
        }
    }
}
