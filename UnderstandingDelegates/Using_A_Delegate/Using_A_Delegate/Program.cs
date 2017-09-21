using System;

/*
 * In C# Delegates form the basic building blocks for events.
 * A DELEGATE is a type that defines a method signature.
 * In C++ for example, you would do this with a function pointer.
 * In C# you can instantiate a delegate and let it point to another method.
 * You can invoke the method through DELEGATE.
 * */
namespace Using_A_Delegate
{
    class Program
    {
        public delegate int Calculate(int x, int y);
        public static int Add(int x, int y) { return x + y; }
        public static int Multiply(int x, int y) { return x * y; }

        public static void UseDelegate()
        {
            Calculate calc = Add;
            Console.WriteLine(calc(3,4));

            calc = Multiply;
            Console.WriteLine(calc(3, 4));
        }
        static void Main(string[] args)
        {
            UseDelegate();

        }
    }
}
/*
 * As you can see, you use the special DELEGATE keyword to tell the compiler tha you are creating a delegate type.
 * DELEGATES can be nested in other types and they can then be used as a nested type.
 * */
