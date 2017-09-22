using System;
using System.Linq;
/*
 * You can also limit the amount of parallelism that is used with the WithDegreeOfParallelism method.
 * You pass that method an integer that represents the number of processors that you want to use.
 * Nomrally, PLINQ uses all processors (upto 64), but you can limit it with this method if you want.
 * 
 * One thing to keep in mind is that parallel processing does not guarantee any particular order.
 * */
namespace Unordered_Parallel_query
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel()
                                        .Where(i => i % 2 == 0)
                                        .ToArray();

            foreach(int i in parallelResult)
            {
                Console.WriteLine(i);
            }
        }
    }
}
