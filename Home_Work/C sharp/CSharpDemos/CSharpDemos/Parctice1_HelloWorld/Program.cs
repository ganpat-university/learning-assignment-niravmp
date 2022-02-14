using System;

namespace Demo01_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello world");

            Console.Write("Enter Your Name > ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Age > ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Hi {name}. You are {age} years young!");
        }
    }
}
