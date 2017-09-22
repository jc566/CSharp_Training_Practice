using System;
using System.Threading.Tasks;

namespace Access_SharedData_in_MultiThread_app
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    n++;
                }
            });
            for (int i = 0; i < 1000000; i++)
            {
                n--;
            }
            up.Wait();
            Console.WriteLine(n);
        }
    }
}
/*
 * When you run this application, you get a different output each time.
 * This is because the operation is not ATOMIC.
 * It consists of both a read and a write that happen at different moments.
 * This is why access to the data youre working with needs to be SYNCHRONIZED, so you can reliably predict how your data is affected.
 * */
