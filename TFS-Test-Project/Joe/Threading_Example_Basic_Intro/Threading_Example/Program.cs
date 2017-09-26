using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            //multi threading
            //MyThread thr1 = new MyThread();
            //MyThread thr2 = new MyThread();

            //MyThread thr1 = new MyThread();

            //Thread tid1 = new Thread(new ThreadStart(thr1.addTwoNums));
            //Thread tid2 = new Thread(new ThreadStart(thr1.doALotMore));
            //Thread tid3 = new Thread(new ThreadStart(thr1.doEvenMore));
            //tid1.Name = "Thread 1";
            //tid2.Name = "Thread 2";
            //tid3.Name = "Thread 3";
            //tid3.Start();
            //tid2.Start();
            //tid1.Start();


            /*doing it with 2 instances*/
            MyThread thr1 = new MyThread();
            MyThread thr2 = new MyThread();

            //Thread tid1 = new Thread(new ThreadStart(thr1.addTwoNums));
            //Thread tid2 = new Thread(new ThreadStart(thr1.doALotMore));
            //Thread tid3 = new Thread(new ThreadStart(thr1.doEvenMore));

            //Thread tid4 = new Thread(new ThreadStart(thr2.addTwoNums));
            //Thread tid5 = new Thread(new ThreadStart(thr2.doALotMore));
            //Thread tid6 = new Thread(new ThreadStart(thr2.doEvenMore));

            Thread tid1 = new Thread(new ThreadStart(thr1.showThread));
            Thread tid2 = new Thread(new ThreadStart(thr1.showThread));
            Thread tid3 = new Thread(new ThreadStart(thr1.showThread));

            Thread tid4 = new Thread(new ThreadStart(thr2.showThread));
            Thread tid5 = new Thread(new ThreadStart(thr2.showThread));
            Thread tid6 = new Thread(new ThreadStart(thr2.showThread));


            tid1.Name = "Thread 1";
            tid2.Name = "Thread 2";
            tid3.Name = "Thread 3";
            tid4.Name = "Thread 4";
            tid5.Name = "Thread 5";
            tid6.Name = "Thread 6";

            //tid1.Start();
            //tid4.Start();
            //tid2.Start();
            //tid5.Start();
            //tid3.Start();
            //tid6.Start();

            
            
            


            try
            {
                tid1.Start();
                tid6.Start();
                tid3.Start();
                tid4.Start();
                tid2.Start();
                tid5.Start();
            }
            catch (ThreadStateException te)
            {
                Console.WriteLine(te.ToString());
            }


            tid1.Join();
            tid2.Join(new TimeSpan(0, 0, 2));
            tid3.Join(new TimeSpan(0, 0, 1));
            tid4.Join(new TimeSpan(0, 0, 2));
            tid5.Join(new TimeSpan(0, 0, 1));
            tid6.Join(new TimeSpan(0, 0, 2));



            Console.ReadKey();
            
        }
    }
}
