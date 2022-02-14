using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace Demo24_Threads
{
    class Demo1
    {
        public static void DoThis()
        {
            Console.WriteLine("-- DoThis() called in Thread: {0}", Thread.CurrentThread.ManagedThreadId);
        }

        public static void RunThis()
        {
            Console.WriteLine("Running in Thread: {0}", Thread.CurrentThread.ManagedThreadId);

            DoThis();

            Console.WriteLine("Doing something else in Thread: {0}", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
