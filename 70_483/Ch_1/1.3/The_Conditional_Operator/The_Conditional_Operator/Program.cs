using System;
/*
 * The conditional operator (:?) returns one of two values depending on a Boolean Expression.
 * If the expression is True, the first value is returned, otherwise, the second.
 * */
namespace The_Conditional_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetValue(true));
        }
        private static int GetValue(bool p)
        {
            if(p)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            return p ? 1 : 0;
        }
    }
}
