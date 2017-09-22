using System;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

/*
 * Instead of waiting until all tasks are finished, you can also wait until one of the tasks is finished.
 * */
namespace Using_Task.WaitAny
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int>[] tasks = new Task<int>[3];

            tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
            tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
            tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 3; });

            while(tasks.Length > 0)
            {
                int i = Task.WaitAny(tasks);
                Task<int> completedTask = tasks[i];

                Console.WriteLine(completedTask.Result);

                var temp = tasks.ToList();
                temp.RemoveAt(i);
                tasks = temp.ToArray();
            }
        }
    }
}
/*
 * In this example, you process a completed TASK as soon as it finishes.
 * By keeping track of which TASKs are finishe, you dont have to wait until all TASKs have completed.
 * */