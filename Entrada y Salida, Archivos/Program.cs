using System;
using System.IO;

namespace Entrada_y_Salida__Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Ejecutar el programa de la manera: Entrada y Salida Archivos entrada.txt salida.txt");
                return;
            }
            try//Abrimos el try
            {
                //Intentamos abrir el archivo de salida para escribir
                using (var escribir = new StreamWriter(args[1]))//Escribira el archivo con StreamWriter
                {//using ayuda a borrar los objetos declarados despues de su uso
                    using (var leyendo = new StreamReader(args[0]))//Leera el archivo con StreamReader
                    {
                        //Redireccionamos la salida estandar
                        Console.SetOut(escribir);
                        //Redireccionamos la entrada estandar
                        Console.SetIn(leyendo);
                        string line;
                        while ((line = Console.ReadLine()) != null)//si linea no es igual a null entrara al if
                        {
                            string newline = line.Replace(" ", " \t");//remplezara el viejo string que es espacio, por el nuevo que es una tabulacion
                            Console.WriteLine(newline);//escribira en consola la nueva linea
                        }
                    }
                }

            }
            catch (IOException e)//Cachamos la expecion de IOException
            {
                TextWriter errorWriter = Console.Error;
                errorWriter.WriteLine(e.Message);
                return;
            }
            //Regresaremos la salida a pantalla
            var pantallaEstandar = new StreamWriter(Console.OpenStandardOutput());//OpenStandarOutput adquiere el flujo de salida estandar
            pantallaEstandar.AutoFlush = true;
            Console.SetOut(pantallaEstandar);
            Console.WriteLine($"Se ha reemplazado los espacios por tabulaciones en el archivo: {args[1]}.\nFinalizo el programa.");
            return;
        }
    }
}
