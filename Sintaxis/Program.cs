using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis
{
    class Program
    {
        static void Main(string[] args)
        {
            string Mensaje = String.Empty;//Declaramos una variable vacia
            Console.WriteLine("Hola... Escriba a un mensaje por favor: ");
            Mensaje = Console.ReadLine();//ReadLine es igual a un Scanner

            if(Mensaje != String.Empty)
            {
                Console.WriteLine("Su mensaje fue: " + Mensaje);
            }
            else
            {
                Console.WriteLine("NohayMensaje");
            }

            try
            {
                Console.WriteLine("ingrese un numero: ");
                int uno = 0;
                uno = int.Parse(System.Console.ReadLine());
                
                Console.WriteLine("El resultado es: " + (10 / uno));
            }
            catch
            {
                Console.WriteLine("No se puede dividir entre 0.");
            }
        }
    }
}
