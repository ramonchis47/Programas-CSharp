using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            bool s = true;
            while(s == true){
                Console.Clear();
                Bienvenida();
                Console.Write("Ingrese el signo del operador a utilizar: ");
                string o = Console.ReadLine();
                Console.WriteLine("El resultado es: " + Op(o));
                s = Repetir();
            }
        }
        
        
        public static void Bienvenida()//funcion
        {
            Console.WriteLine("Bienvenido a su calculadora!\n+ Suma\n- Resta\n* Multiplicación\n/ División");
        }
        private static bool Repetir()
        {
            string o;
            bool b = true;
            Console.WriteLine("Desea salir de la aplicacion: ");
            o = Console.ReadLine();
            if ((o == "Si") || (o == "si"))
            {
                b = false;
            }
            return b;
        }
        private static double Op(string s)
        {
            double primer = 0, segundo = 0, resultado = 0;
            Console.Clear();
            switch (s)
            {
                case "+":
                    Console.WriteLine("Ingrese el primer numero: ");
                    primer = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero: ");
                    segundo = double.Parse(Console.ReadLine());
                    resultado = primer + segundo;
                    break;
                case "-":
                    Console.WriteLine("Ingrese el primer numero: ");
                    primer = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero: ");
                    segundo = double.Parse(Console.ReadLine());
                    resultado = primer - segundo;
                    break;
                    
                case "*":
                    Console.WriteLine("Ingrese el primer numero: ");
                    primer = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero: ");
                    segundo = double.Parse(Console.ReadLine());
                    resultado = primer * segundo;
                    break;
                case "/":
                    Console.WriteLine("Ingrese el primer numero: ");
                    primer = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero: ");
                    segundo = double.Parse(Console.ReadLine());
                    resultado = primer / segundo;
                    break;
            }
            return resultado;
        }
    }

}
