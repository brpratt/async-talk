using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tcs
{
    class Program
    {
        static void Main(string[] args)
        {
            var tcs = new TaskCompletionSource<int>();

            var task1 = tcs.Task;
            var task2 = task1.ContinueWith(t => PrintResult(t.Result));

            Console.WriteLine("Waiting...");
            Thread.Sleep(5000);

            Console.WriteLine($"Was it finished? {(task2.IsCompleted ? "Yes" : "No")}");
            
            Console.WriteLine("Setting result...");
            tcs.SetResult(123);

            task2.Wait();
        }

        static void PrintResult(int result)
        {
            Console.WriteLine($"Result = {result}");
        }
    }
}
