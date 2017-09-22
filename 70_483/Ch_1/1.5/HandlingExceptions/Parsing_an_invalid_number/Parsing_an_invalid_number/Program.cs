using System;

namespace Parsing_an_invalid_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "NaN";
            int i = int.Parse(s);
        }
    }
}
/*
 * The int.Parse method throws and exception of type FormatException when the string is not a vlaid number.
 * Throwing an exception halts the execution of your application.
 * Instead of continuing to the following line, the runtime starts searching for a location in which you
 * handle the exception.
 * If such a location cannot be found, the exception is UNHANDLED and will terminate the application.
 * */