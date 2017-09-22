using System;
using System.Linq;
namespace Using_AsParallel
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 100000000);
            var parallelResult = numbers.AsParallel().
            Where(i => i % 2 == 0).
            ToArray();
        }
        /*
         * The runtime determines whether it makes sense to turn your query into a parallel one.
         * When doing this, it generates Task objects and starts executing them. If you want to force
         * PLINQ into a parallel query, you can use the WithExecutionMode method and specify that it 
         * should always exeute the query in parallel.
         * */
    }
}
