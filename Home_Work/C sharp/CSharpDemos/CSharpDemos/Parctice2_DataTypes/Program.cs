using System;

namespace Demo02_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 110;
            bool b = true;
            string s = "my name is nirav";
            char c = 'A';

            int j = int.MaxValue;
            i = j + 1;

            long l = j;                 // implicit type-casting int value to long.

            l = long.MaxValue;
            // j = l;
            j = (int)l;                 // explicit type-casting long value to int

            Console.WriteLine("l (long) = {0}, j (int) = {1}", l, j);

            
        }
    }
}
