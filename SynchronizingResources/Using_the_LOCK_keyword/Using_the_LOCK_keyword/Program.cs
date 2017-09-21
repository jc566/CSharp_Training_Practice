using System;
using System.Threading.Tasks;
/*
 * One feature the C# language offers is the LOCK operator, which is some syntactic sugar that the compiler translate in call
 * to System.Thread.Monitor
 * */

namespace Using_the_LOCK_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            object _lock = new object();

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 10000000; i++)
                {
                    lock (_lock)
                        n++;
                }
            });

            for (int i = 0; i < 10000000; i++)
            {
                lock (_lock)
                    n--;
            }

            up.Wait();
            Console.WriteLine(n);
        }
    }
}
/*
 * The program always outputs 0 because access to the variable n is now synchronized.
 * There is no way on thread could change the value while the other thread is working with it.
 * 
 * IT could still lead to DEADLOCK however.
 * */