using System;

namespace Working_with_Booleans
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output for usingEqualityOperators() : \n");
            usingEqualityOperators();
            Console.WriteLine("\n");

            Console.WriteLine("Output for BoolOrOperator() :  \n");
            BoolOrOperator();
            Console.WriteLine("\n");

            Console.WriteLine("Output for usingTheAndOperator() :  \n");
            usingTheAndOperator();
            Console.WriteLine("\n");

            Console.WriteLine("Output for usingTheXORoperator() :  \n");
            usingTheXORoperator();
            Console.WriteLine("\n");
        }
        
        public static void usingEqualityOperators()
        {
            int x = 42;
            int y = 1;
            int z = 42;

            Console.WriteLine(x == y);
            Console.WriteLine(x == z);
        }

        public static void BoolOrOperator()
        {
            bool x = false;
            bool y = true;

            bool result = x || y;
            Console.WriteLine(result);

            /*
             * If the runtime notices that the left part of your OR operation is TRUE, 
             * it doesnt have to evaluate the right part of your expression.
             * This is called SHORT CIRCUITING.
             * */
        }
        public static void usingTheAndOperator()
        {
            int value = 42;
            bool result = (0 < value) && (value < 100);
            /*
             * Just as with the OR operator, the runtime applies SHORT-CIRCUITING.
             * Next to being a performance optimization, you can also use it  to your advantage when wokring 
             * with null values.
             * */
        }
        public static void usingTheXORoperator()
        {
            bool a = true;
            bool b = false;

            Console.WriteLine(a ^ a);
            Console.WriteLine(a ^ b);
            Console.WriteLine(b ^ b);
            /*
             * XOR operator has to check that exactly one of the operands is true, it doesnt apply short circuiting.
             * */
        }
    }

}
