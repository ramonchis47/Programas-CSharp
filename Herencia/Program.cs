using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(">Herencia<");
            CalculadoraCompleja s = new CalculadoraCompleja();
            Console.WriteLine("Suma:" + s.suma(54, 62151));
            Console.WriteLine("Multiplicacion: " + s.multi(1516, 54854));
            Console.WriteLine("Resta: " + s.resta(500, 300));
            Console.WriteLine("Division: " + s.division(780, 2));
        }
    }

    public class CalculadoraBasica//Clase basica
    {
        public int suma(int a, int b)//Metodo suma
        {
            return a + b;
        }
        public int resta(int a, int b)//Metodo resta
        {
            return a - b;
        }
    }
    public class CalculadoraCompleja : CalculadoraBasica //Clase que hereda de calculadora basica
    {
        public int multi(int a, int b)//metodo multiplicacion
        {
            return a * b;
        }
        public int division(int a, int b)//metodo division
        {
            return a / b;
        }
    }
}
