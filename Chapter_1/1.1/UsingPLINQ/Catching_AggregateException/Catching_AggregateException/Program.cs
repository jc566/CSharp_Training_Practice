using System;
using System.Linq;
/*
 * It can happen that some of the operations in your parallel query throw and exception.
 * The .NET Framework handles this by aggregating all exceptions into one AggregateException.
 * This exception exposes a list of all exceptions that have happened during parallel execution.
 * */
namespace Catching_AggregateException
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);

            try
            {
                var parallelResult = numbers.AsParallel()
                                            .Where(i => IsEven(i));
                parallelResult.ForAll(e => Console.WriteLine(e));
            }
            catch(AggregateException e)
            {
                Console.WriteLine("There where {0} exceptions", e.InnerExceptions.Count);
            }
        }
        public static bool IsEven(int i)
        {
            if (i % 10 == 0) throw new ArgumentException("i");
            return i % 2 == 0;
        }
    }
}
/*
 * As you can see, two exceptions were thrown while processing the data.
 * You can inspect those exceptions by looping through the InnerExceptions property.
 * */