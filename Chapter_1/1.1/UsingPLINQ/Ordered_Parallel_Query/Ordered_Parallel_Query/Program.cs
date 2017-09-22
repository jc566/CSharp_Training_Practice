using System;
using System.Linq;
/*
 * If you want to ensure that the results are ordered, you can add the AsOrdered operator.
 * Your query is still processed in parallel, but the results are buffered and sorted.
 * */
namespace Ordered_Parallel_Query
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel().AsOrdered().
                Where(i => i % 2 == 0).ToArray();

            foreach(int i in parallelResult)
            {
                Console.WriteLine(i);
            }
        }
    }
}

/*
 * If you have complex query that can benefit from parallel processing but also has some
 * parts that should be done sequentially, you can use the AsSequential to stop your query 
 * from being processed in parallel.
 * */