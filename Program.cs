using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memoria_dinamica
{
   
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Ingrese el tamaño del arreglo: ");
                int tamaño = int.Parse(Console.ReadLine());

                // Reservar memoria dinámica para el arreglo
                int[] arreglo = new int[tamaño];

                // Inicializar el arreglo
                for (int i = 0; i <tamaño; i++)
                {
                    arreglo[i] = i * 2;
                }

                // Imprimir el contenido del arreglo
                Console.WriteLine("Contenido del arreglo:");
                foreach (int num in arreglo)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();

                // No es necesario liberar la memoria en C# (el recolector de basura lo hace por nosotros)

            Console.ReadKey();
            }
        
        }
    }


