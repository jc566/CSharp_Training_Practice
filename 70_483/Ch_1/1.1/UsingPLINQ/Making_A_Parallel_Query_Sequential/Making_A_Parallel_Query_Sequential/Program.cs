using System;
using System.Linq;
/*
 * If you have a complex query that can benefit from parallel processing but also has some parts that should
 * be done sequentially, you can use the AsSequential to stop your query from being processed in parallel.
 * 
 * One scenario where this is required is to preserve the ordering of your query.
 * Below example shouls how you can use the AsSequential operator to make sure that the TAKE method
 * doesnt mess up your order.
 * */
namespace Making_A_Parallel_Query_Sequential
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);

            var parallelResult = numbers.AsParallel().AsOrdered()
                                .Where(i => i % 2 == 0).AsSequential();

            foreach(int i in parallelResult.Take(5))
            {
                Console.WriteLine(i);
            }
        }
    }
}
