using System;
/*
 * A For Loop is nothing more than a convenient way to write a WHILE loop that does the checking
 * and incrementing of the counter.
 * */
namespace While_and_DoWhile_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output for implementing_forLoop_with_a_WhileStatement() is : \n");
            implementing_forLoop_with_a_WhileStatement();
            Console.WriteLine("\n");

            Console.WriteLine("Output for do_while_loop() is : \n");
            do_while_loop();
            Console.WriteLine("\n");
        }

        public static void implementing_forLoop_with_a_WhileStatement()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };

            int index = 0;
            while(index < values.Length)
            {
                Console.WriteLine(values[index]);
                index++;
            }
        }

        public static void do_while_loop()
        {
            do
            {
                Console.WriteLine("Executed Once!");
            }
            while (false);
        }
    }
}
