using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Threading_Example
{
    public class MyThread
    {
        //float num1 = 1, num2 = 2, num3 = 3, num4 = 4, num5 = 5, answer;
        float answer;

        public float addTwoNums(float num1, float num2)
        {


            answer = ((num1 * num2) + 40);
            Console.WriteLine(answer);
            return answer;
        }

        public float doALotMore(float num1, float num2, float num3, float num4, float num5)
        {


            answer = (((num1 + num2 + num3 + num4) * 10) * num5);
            Console.WriteLine(answer);

            return answer;
        }

        public float doEvenMore(float num1, float num2, float num3, float num4, float num5)
        {
            answer = ((num1 * num2 * num3 * num4 * num5) / num2) + (num5 * num3);
            Console.WriteLine(answer);

            return answer;
        }

        public void showThread()
        {
            for (int i = 0; i < 3; i++)
            {
                Thread thr = Thread.CurrentThread;

                Console.WriteLine(thr.Name + "= Iteration number " + i);
                Thread.Sleep(1000);

            }
        }

    }
}
