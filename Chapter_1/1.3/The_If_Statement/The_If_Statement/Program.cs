using System;

namespace The_If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output for BasicIfStatement() : \n");
            BasicIfStatement();
            Console.WriteLine("\n");

            Console.WriteLine("Output for IfStatementWithCodeBlock() : \n");
            IfStatementWithCodeBlock();
            Console.WriteLine("\n");

            Console.WriteLine("Output for UsingElseStatement() : \n");
            UsingElseStatement();
            Console.WriteLine("\n");

            Console.WriteLine("Output for UsingMultipleIfElseStatements() : \n");
            UsingMultipleIfElseStatements();
            Console.WriteLine("\n");

            Console.WriteLine("Output for MoreReadableNestedIfStatement() : \n");
            MoreReadableNestedIfStatement();
            Console.WriteLine("\n");
        }

        public static void BasicIfStatement()
        {
            bool b = true;
            if(b)
                Console.WriteLine("This is a real example in the textbook....");
        }

        public static void IfStatementWithCodeBlock()
        {
            bool b = true;
            if(b)
            {
                Console.WriteLine("Both these lines");
                Console.WriteLine("Will be executed...What joke example");
            }
        }

        public static void CodeBlocksAndScoping()
        {
            bool b = true;
            if(b)
            {
                int r = 42;
                b = false;
                //r can only be accessed inside this IF statement............................................
            }
        }

        public static void UsingElseStatement()
        {
            bool b = false;

            if(b)
            {
                Console.WriteLine("The Bool is true yo");
            }
            else
            {
                Console.WriteLine("The Bool is false yo");
            }
        }

        public static void UsingMultipleIfElseStatements()
        {
            bool b = false;
            bool c = true;

            if(b)
            {
                Console.WriteLine("Bool B is true yo");
            }
            else if (c)
            {
                Console.WriteLine("Bool C is true too");
            }
            else
            {
                Console.WriteLine("Bool B & C are False");
            }
        }

        public static void MoreReadableNestedIfStatement()
        {
            bool x = true;
            bool y = false;
            if(x)
            {
                if(y)
                {
                    Console.WriteLine("Run some functions");
                }
                else
                {
                    Console.WriteLine("Run some other functions");
                }
            }
            Console.WriteLine("\nThis statement can be declared in the following way :\n" +
                "if(x) if(y) someFunction(); else someOtherFunction();");
        }
    }
}
