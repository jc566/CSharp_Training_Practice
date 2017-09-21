using System;
using System.Collections.Concurrent;
/*
 * A ConcurrentDictionary store key and value pairs in a thread-safe manner.
 * You can use methods to add remove items, and to update items in place if they exist.
 * */
namespace Using_A_ConcurrentDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new ConcurrentDictionary<string, int>();

            if(dict.TryAdd("k1",42))
            {
                Console.WriteLine("Added");
            }

            if(dict.TryUpdate("k1", 21, 42))
            {
                Console.WriteLine("42 Updated to 21");
            }

            dict["k1"] = 42; //Overwrite unconditionally

            int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i * 2);
            int r2 = dict.GetOrAdd("k2", 3);
        }
    }
}
/*
 * When working with a ConcurrentDictionary you have methods that can atomically add,
 * get, and update items. 
 * 
 * An Atomic Operation means that it will be started and finished as a single step without other threads interfering.
 * TryUpdate checks to see whether the current value is equal to the existing value before updating it.
 * AddOrUpdate makes sure an item is added if its not there, and updated to a new value if it is.
 * GetOrAdd gets the current value of an item if its available, it adds the new value by using a factory method.
 * */
