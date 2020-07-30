 using System;
using System.Collections.Generic;


namespace Hashset__Sortedset_y_diccionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashSet
            Console.ForegroundColor = ConsoleColor.White;
            HashSet<int> Hashset = new HashSet<int>();//No acepta objetos repetidos, es como una lista
            Console.WriteLine("No acepta objetos repetidos y es como una lista");
            Hashset.Add(4);
            Hashset.Add(8);
            Hashset.Add(4);
            Hashset.Add(6);
            Hashset.Add(0);
            Hashset.Add(2);
            Hashset.Add(10);
            foreach (var item in Hashset)
            {
                Console.WriteLine(item);
            }
            //Sortedset organiza los elementos de forma ascendete
            Console.ForegroundColor = ConsoleColor.Cyan;
            SortedSet<int> s = new SortedSet<int>();
            Console.WriteLine("Sortedset organizara de forma ascendente");
            s.Add(4);
            s.Add(8);
            s.Add(4);
            s.Add(6);
            s.Add(0);
            s.Add(2);
            s.Add(10);
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            //Disctionary es una lista de llaves valor
            Console.ForegroundColor = ConsoleColor.Red;
            Dictionary<string, float> Frutas = new Dictionary<string, float>();
            Console.WriteLine("Disctionary es una lista de llaves/valor");
            Frutas.Add("Manzana", 5.5f);
            Frutas.Add("Pera", 10.5f);
            Console.WriteLine("La manzana cuesta " + Frutas["Manzana"] + "$");
            Console.WriteLine("La pera cuesta " + Frutas["Pera"] + "$");
        }
    }
}
