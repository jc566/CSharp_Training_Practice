﻿using System;
using System.Threading;
using System.Threading.Tasks;
namespace Throwing_OperationCanceledException
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.WriteLine("*");
                    Thread.Sleep(2000);
                }
                token.ThrowIfCancellationRequested();

            }, token);

            try
            {
                Console.WriteLine("Press Enter to stop the task");
                Console.ReadLine();

                cancellationTokenSource.Cancel();
                task.Wait();
            }
            catch(AggregateException e)
            {
                Console.WriteLine(e.InnerExceptions[0].Message);
            }
            Console.WriteLine("Press Enter to end the application");
            Console.ReadLine();
        }
    }
}
