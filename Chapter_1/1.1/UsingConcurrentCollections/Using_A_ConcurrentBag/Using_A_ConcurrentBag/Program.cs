using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

/*
 * A ConcurrentBag is just a bag of items. It enables duplicates and it has no particular order.
 * Important Methods are Add, TryTake, TryPeek.
 * */
namespace Using_A_ConcurrentBag
{
    class Program
    {
        static void Main(string[] args)
        {
            //it seems to display the lowest number first regardless of the no particular order info above
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            //Add items to the bag
            bag.Add(42);
            bag.Add(21);
            bag.Add(19);

            int result;

            if(bag.TryTake(out result))
            {
                //takes a look at current item or in the first run, the first item
                Console.WriteLine(result);
            }

            if(bag.TryPeek(out result))
            {
                //look at what is next after current item
                Console.WriteLine("There is a nxt item: {0}", result);
            }
        }
    }
}
/*
 * One thing to keep in mind is that the TryPeek method is not very useful in a multithreaded environment. 
 * It could be that another thread removes the item before you can access it.
 * 
 * ConcurrentBag also implements IEnumberable<T>, so you can iterate over it.
 * This operation is made thread safe by making a snapshot of the collection when you start iterating it,
 * so items added to the collection after you started iterating it wont be visible.
 * 
 */