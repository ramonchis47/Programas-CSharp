using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            //instaciamos la clase Thread
            Thread hilo = new Thread(new ThreadStart(MetodoHilo/*ponemos el metodo al constructor que se ejecutara en paralelo*/));
            hilo.Start();//iniciamos la ejecucion del metodo en paralelo
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Hilo principal trabajando!!!");
                Thread.Sleep(0);//dormir el hilo
            }
            Console.Read();
        }

        private static void MetodoHilo()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Proceso de hilo: " + i);
                Thread.Sleep(0);
            }
        }
    }
}
