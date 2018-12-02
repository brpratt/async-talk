using System;
using System.Threading;
using System.Threading.Tasks;

namespace Speedy
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 2, 3 };

            Parallel.ForEach(
                nums,
                num => DoWork(num));

            Console.WriteLine("Done!");
        }

        static void DoWork(int x)
        {
            Console.WriteLine($"Starting - {x}");
            Thread.Sleep(1000);
            Console.WriteLine($"  Finished - {x}");
        }
    }
}
