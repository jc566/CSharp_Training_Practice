using System;

/*
 * To handle an exception, you can use try/catch statement.
 * */
namespace Catching_a_FormatException
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(s)) break;

                try
                {
                    int i = int.Parse(s);
                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("{0} is not a valid number. Please try again", s);
                }
            }
        }
    }
}
/*
 * checking to see if its valid input with limitations/restrictions
 * */

/*
 * You need to surround the code that can potentially throw and exception with a TRY statement.
 * Following the TRY statement, you can add several different CATCH blocks.
 * How much code you put inside each TRY block depends on the situation.
 * If you have multiple statements that can throw the same exceptions that need to be handled differently, they
 * should be in different TRY blocks.
 * 
 * A CATCH block can specify the type of the exception it wants to catch.
 * Because all exceptions in the .NET Framework inerit from System.Exception, you can catch every possible
 * EXCEPTION by catching this base type.
 * You can catch more specific EXCEPTION types by adding extra CATCH blocks.
 * 
 * The CATCH blocks should be specified as most-specific to least-specific because this is the order in which the runtime 
 * will examine them.
 * When an EXCEPTION is thrown, the first matching CATCH block will be executed.
 * If not matching CATCH block can be found, the exception will fall through.
 * */
