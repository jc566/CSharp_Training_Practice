using System;
/*
 * Preventing the FINALLY block from running can be achieved by using Enivornment.FailFast.
 * This method has two different overloads, one that only takes a string and another on that also takes an exception.
 * When this method is called, the message (and optionally the exception) are writen to te Windows application log,
 * and the application is terminated.
 * */
namespace Using_Environment.FailFast
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            try
            {
                int i = int.Parse(s);
                if (i == 42)
                {
                    Environment.FailFast("Special Number Entered");
                }
            }
            finally
            {
                Console.WriteLine("Program Complete");
            }
            
        }
    }
}
/*
 * The line 'Program Complete' wont be executed if the number 42 is entered.
 * Instead the application shuts down immediately.
 * */
