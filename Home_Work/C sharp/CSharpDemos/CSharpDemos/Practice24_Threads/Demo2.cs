using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace Demo24_Threads
{
    class Demo2
    {
        public static void DoThis()
        {
            Console.WriteLine("-- DoThis() called in Thread: {0}", Thread.CurrentThread.ManagedThreadId);
        }

        public static void RunThis()
        {
            Console.WriteLine("Running in Thread: {0}", Thread.CurrentThread.ManagedThreadId);

            Thread t = new Thread(new ThreadStart(Demo2.DoThis));
            t.Start();


            Console.WriteLine("Doing something else in Thread: {0}", Thread.CurrentThread.ManagedThreadId);

            Thread t2 = new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("-- anonymous method called in Thread: {0}", Thread.CurrentThread.ManagedThreadId);
            });
            t2.Start();

            Console.WriteLine("-- back in main Thread: {0}", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
