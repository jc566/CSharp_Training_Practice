using System;
using System.Threading.Tasks;
/*
 * The CONTINUEWITH method has a couple of overloads that you can use to configure when the continuation will run.
 * This way you can add different continuation methods that will run when an exception happens, the TASK is canceled, or
 * the TASK completes successfully.
 * */
namespace Schedule_diff_Continuation_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });

            t.ContinueWith((i) =>
            {
                Console.WriteLine("cancelled");
            }, TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith((i) =>
            {
                Console.WriteLine("FAULTED");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = t.ContinueWith((i) =>
            {
                Console.WriteLine("CompleteD");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();
        }
    }
}
