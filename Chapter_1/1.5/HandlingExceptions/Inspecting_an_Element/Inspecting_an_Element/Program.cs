using System;
/*
 * When using a CATCH block, you can use both an exception type and a named identifier.
 * This way, you effectively create a variable that will hold the exception for you so you can inspect its properties.
 * */
namespace Inspecting_an_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = ReadAndParse();
                Console.WriteLine("Parsed : {0}", i);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Message : {0}", e.Message);
                Console.WriteLine("StackTrace : {0}", e.StackTrace);
                Console.WriteLine("HelpLink : {0}", e.HelpLink);
                Console.WriteLine("InnerException: {0}", e.InnerException);
                //Console.WriteLine("TargetSite : {0}", e.TargetSite); //shit dont exist no more
                Console.WriteLine("Source : {0}", e.Source);
            }
        }

        private static int ReadAndParse()
        {
            string s = Console.ReadLine();
            int i = int.Parse(s);
            return i;
        }
    }
}
/*
 * Its important to make sure that your FINALLY block does not cause any exceptions.
 * When this happens, contorl immediately leaves the FINALLY block and moves to the next outer TRY block, if any.
 * The original exception is lost and you cant access it anymore.
 * 
 * You should only catch an exception when you can resole the issue or when you want to 
 * log the error. 
 * Because of this, its important to aovid general CATCH blocks at the lower layers of your application.
 * This way, you could accidentally swallow an important exception without even knowing that it happened.
 * Logging should also be done somewhere higher up in your application.
 * That way, you can avoid logging duplicate errors at multiple layers in your application.
 * */