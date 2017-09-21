using System;
using System.Threading;
using System.Threading.Tasks;
/*
 * If uou want to cancel a TASK after a certain amount of time, you can use an overload of Task.WaitAny that takes a timeout.
 * */
namespace Set_A_Timeout_on_a_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Task longRunning = Task.Run(() =>
            {
                Thread.Sleep(100000);
            });

            int index = Task.WaitAny(new[] { longRunning }, 1000);

            if(index == -1)
            {
                Console.WriteLine("Task timed out");
            }
        }
    }
}
