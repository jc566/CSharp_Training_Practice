using System;
using System.Threading;
using System.Threading.Tasks;
//using System.Threading.Volatile; //Seems to no longer be a valid extension, maybe regular System.Threading includes it now.
/*
 * The compiler can remove complete statements if it discovers that certain code would never be executed.
 * 
 * The compiler sometimes changes the order of statements in your code. 
 * Normally, this wouldnt be a problem in a single-threaded environment.
 * */
namespace Volatile_Class
{
    class Program
    {
        //private static int _flag = 0;
        private static int _value = 0;

        //volatile
        private static volatile int _flag = 0;

        static void Main(string[] args)
        {
          
                Thread1();
                Thread2();

        }
        public static void Thread1()
        {
            _value = 5;
            _flag = 1;
        }
        public static void Thread2()
        {
            if (_flag ==1)
                Console.WriteLine(_value);
        }
    }
}
/*
 * Normally if you run Thread1 & Thread2 you would expect no output or an output of 5.
 * It could be, however, that the compiler switches the two lines in Thread1.
 * If Thread2 then executes, it could be that _flag has a value of 1 and a _value has a value of 0.
 * 
 * You can use locking to fix this, but there is also a .NET framework that you can use called 'System.Threading.Volatile'
 * This class has a special WRITE & READ method, and those methods disable the compiler optimizations so you can force the correct order in your code.
 * Using these methods in the correct order can be quite complex, so .NET offers the volatile keyword that you can apply to a field.
 * You would then change the declaration of your field to this : private static volatile int _flag = 0;
 * 
 * Its good to be aware of the xistence of the volatile keyword, but its something you should use ONLY if you really need it.
 * Because it disables certain compiler optimizations, it will hurt performance.
 * Its also not something that is supported by all .NET languages (Visual Basic does not support) so it hinders language interoperability.
 * */