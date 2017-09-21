using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Using_ThreadLocal_T
{
    class Program
    {
        public static ThreadLocal<int> _field =
            new ThreadLocal<int>(() =>
            {
                return Thread.CurrentThread.ManagedThreadId;
            });
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread A: {0}", x);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread B: {0}", x);
                }
            }).Start();

            Console.ReadKey();
        }
    }
    /*
     *  Here you see another feature of the .NET framework. You can use Thread.CurrentThread property
     *  to ask for information about the thread thats executing. This is called the threads execution context.
     *  This property gives you access to properties like the threads current culture, principal, priority, and other info.
     *  
     *  Current Culture (CultureInfo) = associated with the current thread that is used to format dates, times, numbers,
     *  currency values, the sorting order of text, casing conventions, and string comparisons.
     *  
     *  Principal = representing the current security context
     *  
     *  Priority = A value to indicate how the thread should be scheduled by the operating system.
     *  
     *  When a thread is created, the runtime ensures that the initating threads execution context is flowed to the new thread. 
     *  This way the new thread has the same privileges as the parent thread.
     *  
     *  This copying of data does cost coms resources, however. 
     *  If you dont need this data, you can disable this behavior by using ExecutionContext.SuppressFlow method.
     */
}
