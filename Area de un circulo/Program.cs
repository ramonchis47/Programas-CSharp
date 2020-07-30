using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_un_circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float radio;
            const float pi = 3.1416f; //Pi es una constante
            Console.WriteLine("Bienvenido a su aplicacion de sacar areas de circulos!!!\nIntroduzca el radio del circulo a calcular: ");
            radio = float.Parse(Console.ReadLine());
            Console.WriteLine("El area es: " + (pi * ( radio * radio)));
        }
    }
}
