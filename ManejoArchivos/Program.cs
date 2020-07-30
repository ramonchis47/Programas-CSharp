using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"C:\Users\erick\OneDrive\Documentos\Programas\C#\ArchivoC#.txt";//La ruta a utilizar que tiene secuencias de escape
            //Secuencias de escape es que ignora las secuencias como el salto de linea (\n) en el string para poder acceder a la ruta de forma correcta
            if (!File.Exists(ruta))//si archivo no exite en la ruta, lo crea
            {
                using (StreamWriter sw = File.CreateText(ruta))//using hace que los elimine despues de utilizarlos
                {
                    sw.WriteLine("Hola");//Escribimos en el archivo
                    sw.WriteLine("Es algo dificil");
                    sw.WriteLine("Manejar archivos");
                    sw.WriteLine("Se hace con StreamWriter para escribir");
                    sw.WriteLine("Y para leer es con StreamReader");
                    sw.WriteLine("Fin del comunicado");
                }
            }
            Console.WriteLine("Crear archivo/Escribir en el completo!.\n");
            //Abrimos el archivo y ponemos en consola lo que contiene
            using (StreamReader sr = File.OpenText(ruta))
            {
                string s;
                while ((s = sr.ReadLine()) != null)//lee linea de caracteres hasta que mande null (se acabe)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
