using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example1
{
    class calculation
    {
        static int num1, num2, result;
        public static void add()
        {
            Console.Write("Enter number 1st.\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 2nd.\t");
            num2 = Convert.ToInt32(Console.ReadLine());

            result = num1 + num2;

            Console.Write("\nAdd = {0}", result);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            calculation.add();
        }
    }
}