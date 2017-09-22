using System;
using System.Threading;
using System.Threading.Tasks;
/*
 * You need to be careful to avoid deadlocks in your code. You can avoid a deadlock by making sure that locks are requested
 * in the same order. That way, the first thread can finish its work, after which the second thread can continue.
 * */
namespace Gen_Code_from_Lock_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            object gate = new object();
            bool _lockTaken = false;
            try
            {
                Monitor.Enter(gate, ref _lockTaken);
            }
            finally
            {
                if( _lockTaken)
                {
                    Monitor.Exit(gate);
                }
            }
        }
    }
}
/*
 * You shouldnt write this code by hand; let the compiler generate it for you.
 * The compiler takes care of tricky edge cases that can happen.
 * Its important to use a LOCK statement with a reference object that is private to the class.
 * A public object could be used by other threads to acquire a lock without your code knowing.
 * 
 * It should also be reference type because a value type would get boxed each time you 
 * acquire a lock.
 * In practice, this generates a completely new lock each time, losing the locking mechanism.
 * Fortunately, the compiler helps by raising an error when you accidentally use a value type for the LOCK statement.
 * 
 * You should also avoid locking on the THIS variable because that variable could be used by other coe to create a lock, causing deadlocks.
 * 
 * For the same reason, you should not lock on a string.
 * Becaues of string-interning you could suddenly be asking for a lock on an object that is used in multiple places.
 * 
 * String-Interning = The process in which the compiler creates one object for several strings that have the same content.
 * */
