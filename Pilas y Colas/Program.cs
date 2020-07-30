using System;
using System.Collections;//Libreria para utilizar pilas
using System.Collections.Generic;

namespace Pilas_y_Colas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;//Cambia de color la consola
            //Push & Pop
            Console.WriteLine(">>>PILAS<<<");
            Stack pila = new Stack();//Nuevo objeto de tipo pilas
            pila.Push("Esto es una pila");//Para poner cosas en la pila
            pila.Push("Segundo contenido de la pila");
            pila.Push("Tercer contenido de la pila");
            pila.Push("Cuarto contenido de la pila");

            Console.WriteLine("Este es el numero de contenidos de la pila: " + pila.Count);
            for (int i = 0; i < 4; i++)
            {
                string s = (string)pila.Pop();
                Console.WriteLine(s);
            }
            //Peek que basicamente es ver que elementos siguen pero sin extraer la informacion
            Console.ForegroundColor = ConsoleColor.Cyan;
            pila.Push("Una");
            pila.Push("Vez");
            pila.Push("Salte");
            pila.Push("El");
            pila.Push("Arroyo");
            for (int i = 0; i < 4; i++)
            {
                string ss = (string)pila.Peek();//Peek
                Console.WriteLine("El siguiente contenido es: " + ss);
                string s = (string)pila.Pop();
                Console.WriteLine(">>" + s);
            }
            //Usando contains y clear
            Console.ForegroundColor = ConsoleColor.White;
            pila.Push("Esteban");
            pila.Push("Annie");
            pila.Push("Antonio");
            pila.Push("Wicho");
            pila.Push("Mike");
            pila.Push("Chris");
            pila.Push("Mary");
            pila.Push("Amicia");
            if (pila.Contains("Amicia"))
            {
                pila.Clear();
            }
            Console.WriteLine("La pila contiene: " + pila.Count + " elementos");
            //Colas
            Console.ForegroundColor = ConsoleColor.Blue;
            Queue cola = new Queue();//Nuevo objeto de tipo colas
            cola.Enqueue("A");//Similar al push
            cola.Enqueue("B");
            cola.Enqueue("C");
            Console.WriteLine("Tiene: " + cola.Count + " elementos la cola");
            
            for (int i = 0; i < 3; i++)
            {
                string ss = (string)cola.Peek();//Peek
                Console.WriteLine("El siguiente contenido es: " + ss);
                string s = (string)cola.Dequeue();
                Console.WriteLine(">>" + s);
            }
            Console.WriteLine("las colas tambien utilizan contains y clear");
        }
    }
}
