using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;


namespace Async_and_Await
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = DownloadContent().Result;
            Console.WriteLine(result);
        }

        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }
    }
}
/*
 * You use the ASYNC keyword to mark a method for asynchronous operations. This way,
 * you signal to the compiler that something asynchronous is going to happen. The compiler
 * responds to this by transforming your code ito a STATE MACHINE.
 * 
 * A method marked async just starts running synchronously on the current thread.
 * What it does enable the method to be split into multiple pieces. The boundaries of these
 * pieces are market with the AWAIT keyword.
 * 
 * When you use the AWAIT keyword, the compiler generates code that will see whether your asynchronous operation is already finished.
 * If it is, your method just continues running synchronously. If its not yet completed, the state machine will hook up a continuation
 * method that should run when the Task completes. Your method yields control to the calling thread, and this thread can be used to do other work.
 * */
