using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
/*
 * Next to calling WAIT on a single TASK, you can also use the method WAITALL to wait for multiple TASKS to finish
 * before continuing execution.
 * */
namespace Using_Task.WaitAll
{
    class Program
    {
        static void Main(string[] args)
        {
            Task[] tasks = new Task[3];

            tasks[0] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("1");
                return 1;
            });

            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("2");
                return 2;
            });

            tasks[2] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("3");
                return 3;
            });

            Task.WaitAll(tasks);
        }

        /*
         * In this case, all three Tasks are executed simultaneously, and the whole run takes approximately 1000ms instead of 3000.
         * Next to WaitAll, you also have a WhenAll method thatyou can use to schedule a continuation method after all Tasks have finished.
         * */
    }
}
