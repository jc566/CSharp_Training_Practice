using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
/*
 * BlockingCollection<T> 
 * This collection is thread safe for adding and removing data. Removing an item from the collection can
 * be blocked until data becomes available. Adding data is fast, but you can set a maximum upper limit. If
 * that limit is reached, adding an item blocks the caling thread until there is room.
 * 
 * Blocking Collection is in reality a wrapper around other collection types. 
 * If you dont give it any specific instructions, it uses the ConcurrentQueue by default.
 * 
 * A regular collection blows up when being used in a multithreaded scenario because an item might
 * be removed by one thread while the other thread is trying to read it.
 * 
 * Below example :
 * One Task listens for new items being added to the collection.
 * It blocks if there are no items available.
 * The other Task adds items to the collection.
 * */
namespace Using_BlockingCollectionT
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<string> col = new BlockingCollection<string>();
            Task read = Task.Run(() =>
            {
                while (true)
                {
                    Console.WriteLine(col.Take());
                }
            });

            Task write = Task.Run(() =>
            {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) break;
                    col.Add(s);
                }
            });

            write.Wait();
        }
    }
}
/*
 * The program terminates when the user doesnt enter any data. Until that, every string
 * entered is added by the write Task and removed by the read Task.
 * */
