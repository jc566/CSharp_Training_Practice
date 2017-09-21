using System;
using System.Collections.Concurrent;
/*
 * ConcurrentQueue offers the methods ENQUEUE & TRYDEQUEUE to add/remove items from the collection.
 * It also has TRYPEEK method and it implements IEnumberable by making a snapshot of the data.
 * */
namespace Using_A_ConcurrentQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(99);

            int result;
            if(queue.TryDequeue(out result))
            {
                Console.WriteLine("Dequeued : {0}", result);
            }
        }
    }
}
