using System;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Demo25_Parallel
{
    internal class Program
    {
        private static void displayNumber(int i)
        {
            System.Threading.Thread.Sleep(100);         // 100 milliseconds
            Console.WriteLine("i = {0} on Thread: {1}", i, Thread.CurrentThread.ManagedThreadId);
        }

        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("---- Synchronous version of the ForEach Loop");
            stopwatch.Start();
            foreach(int i in arr)
            {
                displayNumber(i);
            }
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} milliseconds [ {1} ] ",
                stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);

            Console.WriteLine();

            //  (running Parallelly for each element in array)
            Console.WriteLine("---- Asynchronous Version of the ForEach Loop");
            stopwatch.Restart();
            Parallel.ForEach(arr, i =>
            {
                displayNumber(i);
            });
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} milliseconds [ {1} ] ",
                stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);

            Console.WriteLine();

            Console.WriteLine("--- Sysnchronous version of the FOR LOOP");
            stopwatch.Restart();
            for (int i = 0; i < arr.Length; i++)
            {
                displayNumber(arr[i]);
            }
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} milliseconds [ {1} ] ",
                stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);

            Console.WriteLine();

            Console.WriteLine("---- Aysnchronous version of the FOR LOOP");
            stopwatch.Restart();
            Parallel.For(0, arr.Length, i =>
            {
                displayNumber(arr[i]);
            });
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} milliseconds [ {1} ] ",
                stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);
            Console.WriteLine();
        }


    }
}
