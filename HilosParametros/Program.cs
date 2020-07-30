using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HilosParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread hilo = new Thread(MetodoHilo);
            hilo.Start(5);//iniciamos el hilo con el parametro pedido
            hilo.Join();//Este metodo hace que la consola espere a que termine el hilo
            Console.Read();
        }

        private static void MetodoHilo(object o)
        {
            for (int i = 1; i < (int)o; i++)
            {
                Console.WriteLine("Hilo de procesos: " + i);
                Thread.Sleep(0);
            }
        }
    }
}
