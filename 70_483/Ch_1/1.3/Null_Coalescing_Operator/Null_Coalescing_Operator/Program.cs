using System;
/*
 * The ?? operator is called the NULL-COALESCING operator.
 * You can use it to provide a default vlaue for nullable value types or for reference types.
 * The operator returns the left value if its not NULL, otherwise, the right operand.
 * */
namespace Null_Coalescing_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The output for TheNullCoalescingOperator(): \n");
            TheNullCoalescingOperator();
            Console.WriteLine("\n");

            Console.WriteLine("The output for NestingTheNullCoalescingOperator(): \n");
            NestingTheNullCoalescingOperator();
            Console.WriteLine("\n");
        }

        public static void TheNullCoalescingOperator()
        {
            int? x = null;
            int y = x ?? -1;

            Console.WriteLine("The value of variable X is :" + x);
            Console.WriteLine("The value of variable Y is :" + y);
        }

        public static void NestingTheNullCoalescingOperator()
        {
            int? x = null;
            int? z = null;
            int y = x ??
                    z ??
                    -1;
            Console.WriteLine("The value of variable X is :" + x);
            Console.WriteLine("The value of variable Y is :" + y);
            Console.WriteLine("The value of variable Z is :" + z);

            /*
             * Of course you can achieve the same with and if satement but the null-coalescing operator can 
             * shorten your code and improve its readability.
             * */
        }
    }
}
