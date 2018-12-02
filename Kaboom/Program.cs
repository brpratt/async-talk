using System;
using System.Threading.Tasks;

namespace Kaboom
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(async () => await DoWork()).Wait();
        }

        static async Task DoWork()
        {
            Console.WriteLine("Starting work...");

            await Task.Delay(1000);
            // throw new Exception("kaboom");
            await Task.Delay(1000);

            Console.WriteLine("Done!");
        }
    }
}
