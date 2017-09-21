using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
/*
 * ConcurrentBag also implements IEnumberable<T>, so you can iterate over it.
 * This operation is made thread-safe by making a snapshot of the collection when you start iterating it,
 * so items added to the collection after you started iterating it wont be visible.
 * */
namespace Enumerating_A_ConcurrentBah
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            Task.Run(() =>
            {
                bag.Add(55);
                Thread.Sleep(1000);
                bag.Add(21);
            });

            Task.Run(() =>
            {
                foreach (int i in bag)
                {
                    Console.WriteLine(i);
                }
            }).Wait();
        }
    }
}
/*
 * The initial value of 55 is only displayed because the other value is added after iterating over the bag has started.
 * */