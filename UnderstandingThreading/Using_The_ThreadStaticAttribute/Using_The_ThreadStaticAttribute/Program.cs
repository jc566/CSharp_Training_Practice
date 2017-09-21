using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Using_The_ThreadStaticAttribute
{
    class Program
    {
        [ThreadStatic] //if you remove [ThreadStatic] Attribute, the value of _field will equal 20 instead of the intended amount
        public static int _field; //does not have to be in the form of _field. It can just be FIELD or field etc
        static void Main(string[] args)
        {

            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    //increase the field value from 0 to 1 for aestethics purpose
                    _field++;
                    //each thread will have its own int called _field that will 'reset' for each thread
                    Console.WriteLine("Thread A : {0}", _field);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }).Start();

            Console.ReadKey();
        }
        /**********************************************************************************************************************
         *  My understanding is that ThreadStatic _field will take whatever the value is stated within the thread definition. *
         *********************************************************************************************************************/
    }
}
