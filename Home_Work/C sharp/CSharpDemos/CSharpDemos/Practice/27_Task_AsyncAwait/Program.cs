using System;
using System.Threading;
using System.Threading.Tasks;

namespace Demo27_Task_AsyncAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result;
            Console.WriteLine("--- Starting MAIN on Thread: {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine();

            Console.WriteLine("--- Running Synchronously");
            result = Program.ProcessJob(10);
            Console.WriteLine("Returned: {0}", result);
            Console.WriteLine();

            Console.WriteLine("--- Running Asynchronously using Tasks");
            Task<bool> retVal2 = Program.ProcessJobAsync(100);
            Console.WriteLine("printing something asynchronously..... Result will be displayed once available...");
            retVal2.Wait();
            result = retVal2.Result;
            Console.WriteLine("Returned: {0}", result);
            Console.WriteLine();
        }
        
        private static async Task<bool> ProcessJobAsync(int i)
        {
            // await for the Task to run, and return the returned value from the Task
            return await Task.Run(() => ProcessJob(i));
        }

        private static bool ProcessJob(int i)
        {
            Thread.Sleep(5000);

            Console.WriteLine("ProcessJob called with i = {0} on Thread: {1}",
                i, Thread.CurrentThread.ManagedThreadId);

            return true;
        }
    }
}
