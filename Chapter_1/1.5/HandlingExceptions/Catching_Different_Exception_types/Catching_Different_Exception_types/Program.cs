using System;
/*
 * If the string S is null, an ArgumentNullException will be thrown.
 * If the string S is not a number, a FormatException will be thrown.
 * By using different CATCH blocks, you can handle those exceptions each in their own way.
 * */
namespace Catching_Different_Exception_types
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();

                try
                {
                    int i = int.Parse(s);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("You need to enter a value");
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0} is not a valid number. Please try again", s);
                }
            }
        }
    }
}
/*
 * In C# 1, you could also use a CATCH block without an exception type.
 * This could be used to catch exceptions that were thrown from other languages like C++ that dont inherit 
 * from System.Exception (in C++ you can throw exceptions of any type).
 * Nowadays, each exception that doesnt inherit from System.Exception is automatically wrapped in
 * a System.Runtime.CompilerServices.RuntimeWrappedException.
 * Since this exception inherits from System.Exception, there is no need for the empty CATCH block anymore.
 * 
 * Its important to make sure that your application is in the correct state when the CATCH bock finishes.
 * This could mean that you need to revert changes that your TRY block made before the exception was thrown.
 * 
 * Another important feature of exception handling is the ability to specify that certain code should
 * always run in case of an exception.
 * This can be done by using the FINALLY block together with a TRY or TRY/CATCH statement.
 * The FINALLY block will execute whether an exception happens or not.
 * */