using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//shows how to start a new Task and wait until its finished

namespace Starting_A_New_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.WriteLine(x);
                }
            });

            t.Wait();
        }
        /*
         * This example creates a new Task and immediately starts it. 
         * Calling Wait is equivalent to calling Join on a thread.
         * It waits till the Task is finished before exiting the application.
         * */
    }
}
