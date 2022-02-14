using System;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.Write("Enter your Full name: ");
            person.Name = Console.ReadLine();

            Console.Write("Enter your age Here: ");
            person.Age = int.Parse( Console.ReadLine() );

            Console.WriteLine();
            Console.WriteLine($"You entered: {person.Name} {person.Age}"); ;
        }
    }
}
