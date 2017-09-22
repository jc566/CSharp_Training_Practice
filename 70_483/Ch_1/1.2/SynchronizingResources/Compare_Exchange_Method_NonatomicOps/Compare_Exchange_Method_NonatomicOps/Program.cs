using System;
using System.Threading;
using System.Threading.Tasks;

/*
 * INTERLOCKED also supports switching values by using EXCHANGE method :
 * 
 * if (Interlocked.Exchange(red isInUse, 1) == 0 ) {}
 * This code retrieves the current value and immediately sets it to the new value in the same operation. 
 * It returns the previous value before changing it.
 * 
 * You can also use the COMPAREEXCHANGE method. This method first checks to see whether the expected value is there;
 * if it is, it replaces it with another value.
 * */
namespace Compare_Exchange_Method_NonatomicOps
{
    class Program
    {
        static int value = 1;

        static void Main(string[] args)
        {
            Task t1 = Task.Run(() =>
            {
                if (value == 1)
                {
                    //Removing the folllwing line will change the output
                    Console.WriteLine("Im about to Execute t1");
                    Thread.Sleep(2000);
                    Console.WriteLine("Executing t1");
                    value = 2;
                }
            });

            Task t2 = Task.Run(() =>
            {
                Console.WriteLine("Executing t2");
                value = 3;
            });

            Task.WaitAll(t1, t2);
            Console.WriteLine(value); //should display 2 if you comment out the other line
        }
    }
}
/*
 * TASK t1 starts running and sees that value is equal to 1.
 * At the same time, t2 changes the value to 3 and then t1 changes it back to 2.
 * To avoid this, you can use the following INTERLOCKED statement.
 * 
 * Interlocked.CompareExchange(ref value, newValue, compareTo);
 * 
 * This makes sure that comparing the value and exchanging it for a new one is an atomic operation.
 * This way, no other thread can change the value between comparing and exchanging it.
 * */
