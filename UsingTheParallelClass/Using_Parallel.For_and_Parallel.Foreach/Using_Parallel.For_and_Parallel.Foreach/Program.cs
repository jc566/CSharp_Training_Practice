using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Using_Parallel.For_and_Parallel.Foreach
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
        }
    }

    /*
     * Parallelism involves taking a certain task and splitting it into a set of related tasks that can
     * be executed concurrently. This also means that you shouldnt go through your code to replace all your loops
     * with parallel loops. You should use the Parallel class only when your code doesnt have to be executed SEQUENTIALLY!
     * 
     * Increasing performance with parallel processing happens only when you have a lot of work to be done that can be executed in parallel.
     * For smaller works sets or for work that has to synchronize access to resources, using the Parallell clas can hurt performance.
     * */
}
