using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Demo26_Task
{
    class Demo1
    {
        public static void Run()
        {
            //ThreadStart t
            //    = new ThreadStart(()
            //    =>
            //    {
            //        Console.WriteLine("hello from Thread: {0}", Thread.CurrentThread.ManagedThreadId);
            //    });

            Task.Factory.StartNew(() 
                =>
                {
                    Console.WriteLine("hello from Thread: {0}", Thread.CurrentThread.ManagedThreadId);
                });
            Task.WaitAll();
            Console.WriteLine();
        }
    }
}
