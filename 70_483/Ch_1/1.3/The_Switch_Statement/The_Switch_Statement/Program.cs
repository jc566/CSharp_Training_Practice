using System;

namespace The_Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Output for AComplexStatement() is : \n");
            //AComplexIfStatement();
            //Console.WriteLine("\n");

            //Console.WriteLine("Output for ASwitchStatement() is : \n");
            //ASwitchStatement();
            //Console.WriteLine("\n");

            Console.WriteLine("Output for GotoInASwitchStatement() is : \n");
            GotoInASwitchStatement();
            Console.WriteLine("\n");
        }

        public static void AComplexIfStatement()
        {
            Console.WriteLine("Enter a character to see if its a vowel or not...");
            char input = Console.ReadKey().KeyChar;
            if(input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            {
                Console.WriteLine("Input is a Vowel");
            }
            else
            {
                Console.WriteLine("Input is not a Vowel");
            }
        }

        public static void ASwitchStatement()
        {
            /*
             * A switch can use one or multiple switch-sections that contain one or more switch-labels.
             * Below example, all the vowels belong to the same switch-section.
             * You can add a default label if you choose.
             * */
            Console.WriteLine("Enter a character to see if its a vowel or not...");
            char input = Console.ReadKey().KeyChar;

            switch (input)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    {
                        Console.WriteLine("Input is a vowel!!!!!!");
                        break;
                    }
                case 'y':
                    {
                        Console.WriteLine("Input is sometimes a vowel");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Inputs not a vowel ever!");
                        break;
                    }
            }
        }

        public static void GotoInASwitchStatement()
        {
            bool IsValid = false;
            Console.WriteLine("Enter either the number 1 or 2. any other value will do zilch.");
            int i = Int32.Parse(Console.ReadLine());
            
            while(!IsValid)
            {
                if (i == 1 || i == 2)
                {
                    IsValid = true;
                }
                else
                {
                    Console.WriteLine("Enter either the number 1 or 2. any other value will do zilch.");
                    i = Int32.Parse(Console.ReadLine());
                }
            }
            
            
            
            switch(i)
            {
                case 1: Console.WriteLine("Case 1");
                    break;
                case 2: Console.WriteLine("Case 2");
                    break;
                
            }
        }
    }
}
