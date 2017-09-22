using System;

namespace Throwing_An_ArgumentNullException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static string OpenAndParse(string filename)
        {
            if (string.IsNullOrWhiteSpace(filename))
            {
                throw new ArgumentNullException("filename", "Filename is required");
            }

            /*
             * NOT FINISHED
             * */
            
        }
    }
}
