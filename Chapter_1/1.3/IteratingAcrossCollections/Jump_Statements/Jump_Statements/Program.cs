using System;
/*
 * Another type of statement that can be used to influence program flow is a JUMP STATEMENT.
 * You have already looked at two of those statements, BREAK & CONTINUE.
 * A JUMP statement unconditionally transfers control to another location in your code.
 * 
 * Another JUMP statement can be used to change the flow of a program is GOTO.
 * The GOTO statement moves control to a staatement that is marked by a label.
 * If the label cant be found or ist not within the scope of the GOTO statement, a compiler error occurs.
 * */
namespace Jump_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            if (x == 3) goto customLabel;
            x++;

            customLabel:
            Console.WriteLine(x);
        }
    }
}
/*
 * You cannot make a jump to a label thats not in scope.
 * This means you cannot transfer to another block of code thats outside of your current block.
 * The compiler also makes sure that any FINALLY blocks that intervene are executed.
 * */
