using System;
using System.Threading;

/*
 * When working directly with the THREAD class, you create a new thread each time, adnd the thread dies when youre
 * finished with it. 
 * The creation of a thread, however, is something that costs some time and resources.
 * 
 * A THREAD POOL is created to reuse those threads, similar to the way a database connection pooling works.
 * Instead of letting a thread die, you send it bac kto te pool where it can be reused whenever a request comes in.
 * 
 * When you work with a thread pool from .NET, you queue a work item that is then picked
 * up by an available thread from the pool.
 * */
namespace Queuing_some_work_to_Thread_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from the threadpool");
            });

            Console.ReadLine();
        }
    }
}
