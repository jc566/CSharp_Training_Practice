using System;
using System.Threading;
using System.Threading.Tasks;
/*
 * The below is an example of Deadlock
 * */
namespace Creating_A_Deadlock
{
    class Program
    {
        static void Main(string[] args)
        {
            object lockA = new object();
            object lockB = new object();

            var up = Task.Run(() =>
            {
                Thread.Sleep(1000);
                lock (lockB)
                {
                    Console.WriteLine("Locked A & B");
                }
            });

            lock (lockB)
            {
                lock (lockA)
                {
                    Console.WriteLine("Locked B & A");
                }
            }

            up.Wait();
        }
    }
}
/*
 * Because both locks are taken in reverse order, a deadlock occurs.
 * The first Task locks A and waits for B to become free.
 * The main thread, however, has B locked and is waiting for A to be released.
 * */
