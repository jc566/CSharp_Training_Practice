using System;
using System.Threading;
using System.Threading.Tasks;
//DOESNT SEEM TO BE WORKING AT THE MOMENT

/*
 * Instead of cathcing the exception, you can also add a continuation TASK that executes only when the TASK is canceled. 
 * In this TASK, you have access to the exception that was thrown, and you can choose to handle it if thats appropriate.
 * */
namespace Add_Continuation_For_Canceled_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

           Task task = Task.Run(() =>
           {
               while (!token.IsCancellationRequested)
               {
                   Console.WriteLine("*");
                   Thread.Sleep(2000);
               }
               throw new OperationCanceledException();
           }, token).ContinueWith((t) =>
           {
               t.Exception.Handle((e) => true);
               Console.WriteLine("You have canceled the task");
           }, TaskContinuationOptions.OnlyOnCanceled);
        }
    }
}
