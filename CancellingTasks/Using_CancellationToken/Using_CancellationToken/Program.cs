using System;
using System.Threading;
using System.Threading.Tasks;
/*
 * When working with multithread code such as TPL, the PARALLEL class, or PLINQ, you often have long running tasks.
 * The .NET Framework offers a special class that can help you in canceling these tasks : CancellationToken.
 * 
 * You pass a CancellationToken to a Task, which then periodically monitors the token to see whether cancellation is requested.
 * */
namespace Using_CancellationToken
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() =>
            {
              while(!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(2000);
                }
                
                
            }, token);

            Console.WriteLine("Press Enter to stop the task");
            Console.ReadLine();
            cancellationTokenSource.Cancel();

            Console.WriteLine("Press Enter to end the application");
            Console.ReadLine();
        }
    }
}
/*
 * The CancellationToken is used in asynchronous Task. The CancellationTokenSource is used to signal that the Task should cancel itself.
 * 
 * In this case, the operation will just end when cancellation is requested. 
 * Outside users of the Task wont see anything different because the TASK will just have a RanToCompletion state.
 * If you want to signal to outside users that your task has been cancelled, you can do this by throwing 
 * an OperationCanceledException.
 * */

