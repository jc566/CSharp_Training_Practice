using System;
using System.Linq;

/*
 * When using PLINQ, you can use ForAll operator to iterate ove a collection when the iteration can also be done
 * in parallel way.
 * */
namespace Using_ForAll
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);

            var parellelResult = numbers.AsParallel().
                Where(i => i % 2 == 0);

            parellelResult.ForAll(e => Console.WriteLine(e));
        }
    }
}

/*
 * In contrast to foreach, ForAll odes not need all results before it starts executing. In this example, ForAll oes, however,
 * remove any sort order that is specified.
 * */
