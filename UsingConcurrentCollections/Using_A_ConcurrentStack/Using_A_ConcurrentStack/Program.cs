using System;
using System.Collections.Concurrent;

/*
 * A stack is LAST IN, FIRST OUT (LIFO) collection.
 * A Queue is FIRST IN, FIRST OUT (FIFO) collection.
 * 
 * ConcurrentStack has two important methods : Push and TryPop.
 * Push is used to add an item to the Stack.
 * TryPop tries to get an item off the stack.
 * You can never be sure whether there are items on the stack because multiple threads might be accessing your collection at the same time.
 * You can also add/remove multiple items at once by using PushRange/TryPopRange.
 * When you enumerate the collection, a snapshot is taken.
 * */

namespace Using_A_ConcurrentStack
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();

            stack.Push(42);
            stack.Push(88);

            int result;

            //takes out the most recently placed item.
            if(stack.TryPop(out result))
            {
                Console.WriteLine("Popped : {0}", result);
            }
            //if uncommented, this will pop out the 2nd most recently placed item
            //if (stack.TryPop(out result))
            //{
            //    Console.WriteLine("Popped : {0}", result);
            //}

            stack.PushRange(new int[] { 10, 20, 30 });
            int[] values = new int[3];
            stack.TryPopRange(values);

            foreach(int i in values)
            {
                Console.WriteLine(i);
            }
        }
    }
}
