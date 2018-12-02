using System;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsTrue() ? Get5() : Get7());
        }

        static bool IsTrue()
        {
            return true;
        }

        static int Get5()
        {
            return 5;
        }

        static int Get7()
        {
            return 7;
        }
    }
}
