using System;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
/*
 * You can cancel the loop by using the PARALLELLOOPSTATE object.
 * You have two option to do this : Break or Stop
 * 
 * Break ensures that all iterations that are currently running will be finished.
 * Stop terminates everything.
 * */
namespace Using_Parallel.Break
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 10, i =>
            {
                Thread.Sleep(1000);
            });

            var numbers = Enumerable.Range(0, 10);

            Parallel.ForEach(numbers, i =>
            {
                Thread.Sleep(1000);
            });

            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
            {
                if (i == 500)
                {
                    Console.WriteLine("Breaking Loop");
                    loopState.Break();
                }
                return;
            });
        }
    }
}
/*
 * When breaking the parallel loop, the result variable has an IsCompleted value of false and a LowestBreakIteration of 500.
 * When you use the Stop method, the LowestBreakIteration is null.
 * */