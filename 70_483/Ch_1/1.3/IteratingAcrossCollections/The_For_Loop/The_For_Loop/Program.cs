using System;

namespace The_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output for BasicForLoop() is : \n");
            BasicForLoop();
            Console.WriteLine("\n");

            Console.WriteLine("Output for For_Loop_With_Multiple_Loop_Variables() is : \n");
            For_Loop_With_Multiple_Loop_Variables();
            Console.WriteLine("\n");

            Console.WriteLine("Output for For_Loop_with_a_custom_increment() is : \n");
            For_Loop_with_a_custom_increment();
            Console.WriteLine("\n");

            Console.WriteLine("Output for For_Loop_with_a_Break_Statement() is : \n");
            For_Loop_with_a_Break_Statement();
            Console.WriteLine("\n");

            Console.WriteLine("Output for For_Loop_with_a_Continue_Statement() is : \n");
            For_Loop_with_a_Continue_Statement();
            Console.WriteLine("\n");
        }

        public static void BasicForLoop()
        {
            /*
             * You can use a for loop when you need to iterate over a collection until a specific condition is reached.
             * */
            int[] values = { 10 ,20 ,30 ,40 , 50, 60 };
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
        }

        public static void For_Loop_With_Multiple_Loop_Variables()
        {
            /*
             * Its also not required to let the loop value increment or decrement with 1.
             * */
            int[] values = { 10, 20, 30, 40, 50 };

            for (int x = 0, y = values.Length - 1;
                ((x < values.Length) && (y >= 0));
            x++, y--)
            {
                Console.Write(values[x]);
                Console.Write(values[y]);
            }
        }

        public static void For_Loop_with_a_custom_increment()
        {
            int[] values = { 10, 20, 30, 40, 50 };
            for(int index = 0; index < values.Length; index +=2)
            {
                Console.WriteLine(values[index]);
            }
        }

        public static void For_Loop_with_a_Break_Statement()
        {
            /*
             * Manually break out of a For loop using BREAK or RETURN
             * */
            int[] values = { 10, 20, 30, 40, 50 };
            for(int index = 0; index < values.Length;index++)
            {
                if(values[index] == 40)
                { break; }
                Console.WriteLine(values[index]);
            }
            /*
             * Next to breaking the loop completely, you can also instruct the FOR loop to continue to the next item by 
             * using the CONTINUE STATEMENT!!!!!!!!!!!!!!
             * */
        }

        public static void For_Loop_with_a_Continue_Statement()
        {
            int[] values = { 10, 20, 30, 40, 50 };
            for(int index = 0; index < values.Length;index++)
            {
                if(values[index] == 40)
                { continue; }
                Console.WriteLine(values[index]);
            }
        }
    }
}
