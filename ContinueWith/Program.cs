using System;
using System.Threading;
using System.Threading.Tasks;

namespace ContinueWith
{
    class Program
    {
        static void Main(string[] args)
        {
            Example1();
            //Example2();
        }

        static void Example1()
        {
            var task1 = Task.Run(() => DoWork(3));
            var task2 = task1.ContinueWith(_ => DoWork(5));
            var task3 = task2.ContinueWith(_ => DoWork(7));
            var task4 = task3.ContinueWith(_ => DoWork(9));

            task4.Wait();
        }

        static void DoWork(int x)
        {
            Console.WriteLine($"Doing work with {x}...");
            Thread.Sleep(1000);
            Console.WriteLine("  done");
        }

        static void Example2()
        {
            var task = Task.Run(() => Generate(1))
                .ContinueWith(t => t.Result + Generate(2))
                .ContinueWith(t => t.Result + Generate(3));

            Console.WriteLine($"Total: {task.Result}");
        }

        static int Generate(int x)
        {
            Console.WriteLine($"Generating {x}...");
            Thread.Sleep(1000);
            Console.WriteLine("  done");
            return x;
        }
    }
}
