using System;
using System.Text.RegularExpressions;

namespace Collapse_Multiple_Spaces_RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex(@"[ ]{2,}", options); //theres a space between the [ and ]

            string input = "1 2 3 4     5";
            string result = regex.Replace(input, " ");

            Console.WriteLine(result);
        }
    }
}
/*
 * Although regex looks more difficult than writing the validation code in plain C#,
 * its definitely worth learning how it works.
 * A regular expression can dramatically simplify your code and its worth examining if you are in a situation requiring validation.
 * */