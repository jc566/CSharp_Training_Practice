using System;
using System.Threading.Tasks;
/*
 * Next to TASK, the .NET Framework also has the TASK<T> class that you can use if a TASK should return a value.
 * */

namespace Using_A_Task_That_Returns_a_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });
            Console.WriteLine(t.Result);
        }
    }
}
/*
 * Attempting to read the RESULT property on a TASK will force the thread thats trying to read the result 
 * to wait until the TASK is finished before continuing.
 * As long as the TASK has not finished, it is impossible to give the result.
 * If the TASK is not finished, this call will block the current thrad.
 * 
 * Because of the object-oriented nature of the TASK object, one thing you can do is add a CONTINUATUON TASK.
 * This means that you want another operation to execute as soon as the TASK finished.
 * */
