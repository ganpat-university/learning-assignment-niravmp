using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo26_Task
{
    class Demo2
    {
        private static void DoSomething()
        {
            Console.WriteLine("hello Task Library!");
        }

        public static void Run()
        {
            Task t1 = Task.Factory.StartNew(Demo2.DoSomething);
            Task t2 = Task.Factory.StartNew(Demo2.DoSomething);
            Task t3 = Task.Factory.StartNew(Demo2.DoSomething);

            // Wait for all the tasks to complete.
            Task.WaitAll(t1, t2, t3);
            Console.WriteLine("--- finished the first three tasks!");
            Console.WriteLine();

            // Fluid Code / Chain Calls
            // execute second taks after the first task has completed.
            Task.Factory
                .StartNew(Demo2.DoSomething)
                .ContinueWith((t) =>
                {
                   Console.WriteLine("Continued into Step 2");
                })
                .ContinueWith((t) =>
                {
                    Console.WriteLine("continued again into Step 3");
                });

        }
    }
}
