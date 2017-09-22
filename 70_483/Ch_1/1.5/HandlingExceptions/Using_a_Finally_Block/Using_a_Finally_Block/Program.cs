using System;
/*
 * Another important feature of exception handling is the ability to specify that certain code should
 * always run in case of an exception.
 * This can be done by using the FINALLY block together with a TRY or TRY/CATCH statement.
 * The FINALLY block will execute whether an exception happens or not.
 * */
namespace Using_a_Finally_Block
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            try
            {
                int i = int.Parse(s);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("you need to enter a value");
            }
            catch(FormatException)
            {
                Console.WriteLine("{0} is not a valid number. Please try again");
            }
            finally
            {
                Console.WriteLine("Program Complete");
            }
        }
    }
}
/*
 * Of course, there are sstill situations in which a FINALLY block wont run.
 * For example, when the TRY block goes into an infinite loop, it will never exit the TRY block and never enter 
 * the FINALLY block.
 * And in situations such as a power outage, no other code will run.
 * The whole operating system will just terminate.
 * 
 * There is one other situation that you can use to prevent a FINALLY block from running.
 * Of course, this isnt something you want to use on a regular basis, but you many have a situation 
 * in which just shutting down the application is safer than running FINALLY blocks.
 * 
 * Preventing the FINALLY block from running can be achieved by using Enivornment.FailFast.
 * This method has two different overloads, one that only takes a string and another on that also takes an exception.
 * When this method is called, the message (and optionally the exception) are writen to te Windows application log,
 * and the application is terminated.
 * 
 * */