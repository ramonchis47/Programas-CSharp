using System;

namespace TipodeValor
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 7;//dato que no cambia aunque lo usemos en la funcion
            Console.WriteLine($"Index antes de llamar Sum4: { index}");
            Console.WriteLine($"Sum4: {Sum4(index)}");
            Console.WriteLine($"Index después de llamar Sum4: {index}");//Aqui el valor de la variale que se dio en el principo no cambia
            Console.ReadLine();//Por que es una tipo de valor 

            //Los de referencia si cambian los originalmente
            Person person = new Person();
            person.Name = "Sergio";//Nombre orriginal
            person.Age = 40;

            Console.WriteLine($"Person Name: {person.Name}");//imprimimos la variable original 
            ChangeName(person);//llamamos a la funcion y este cambiara el nombre
            Console.WriteLine($"Person Name: {person.Name}");//aqui vemos la variable que cambio
            Console.Read();
        }
        public static int Sum4(int number)
        {
            number = number + 4;
            return number;
        }
        public static void ChangeName(Person p)
        {
            p.Name = p.Name + " Change";
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}