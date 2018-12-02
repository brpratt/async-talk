using System;

namespace Pythagorean
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Pythagorean(3, 4);

            Console.WriteLine($"Result = {result}");
        }

        static int Pythagorean(int a, int b)
        {
            return Sum(Square(a), Square(b));
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Square(int x)
        {
            return x * x;
        }
    }
}
