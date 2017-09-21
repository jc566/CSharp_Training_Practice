using System;
using System.Threading.Tasks;
/*
 * Attempting to read the RESULT property on a TASK will force the thread thats trying to read the result 
 * to wait until the TASK is finished before continuing.
 * As long as the TASK has not finished, it is impossible to give the result.
 * If the TASK is not finished, this call will block the current thrad.
 * 
 * Because of the object-oriented nature of the TASK object, one thing you can do is add a CONTINUATUON TASK.
 * This means that you want another operation to execute as soon as the TASK finished.
 * */
namespace Adding_A_Continuation
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });

            Console.WriteLine(t.Result);
        }
    }
}
/*
 * The CONTINUEWITH method has a couple of overloads that you can use to configure when the continuation will run.
 * This way you can add different continuation methods that will run when an exception happens, the TASK is canceled, or
 * the TASK completes successfully.
 * */