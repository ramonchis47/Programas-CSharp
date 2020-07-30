using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arreglo
            Console.ForegroundColor = ConsoleColor.Green;//Cambia el color de la consola 
            int[] arreglo = { 1, 4, 5, 6 };
            Console.WriteLine("Arreglo [0]: " + arreglo[0] + " Arreglo[1]: " + arreglo[1] + " Arreglo[2]: " + arreglo[2] + " Arreglo[3]: " + arreglo[3]);

            Console.ForegroundColor = ConsoleColor.Yellow;//Cambia color de la consola
            string[] arregloS = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };//Arreglo de tipo string
            foreach (var item in arregloS)
            {
                Console.WriteLine(item);
            }
            //Matriz
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            int[,] matrices = new int[2, 2];
            Console.WriteLine("Ingrese datos para llenar la matriz[2,2]: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrices[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("La matriz es: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrices[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
