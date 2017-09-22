using System;
using System.Threading;
using System.Threading.Tasks;
/*
 * Making operations ATOMIC is the job of the INTERLOCKED class that can be found in the System.Threading namespace.
 * When using Interlocked.Increment & Interlocked.Decrement, you create an atomic operation.
 * */
namespace Interlocked_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    Interlocked.Increment(ref n);
                }
            });

            for (int i = 0; i < 1000000; i++)
            {
                Interlocked.Decrement(ref n);
            }

            up.Wait();
            Console.WriteLine(n);
        }
    }
}
/*
 * INTERLOCKED guarantees that the increment and decrement operations are executed atomically.
 * No other thread will see any intermediate results.
 * Of course, adding and subtracting is a simple operation.
 * If you have more complex operations, you would still have to use a LOCK.
 * */