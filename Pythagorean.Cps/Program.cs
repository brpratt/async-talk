using System;

namespace Pythagorean.Cps
{
    class Program
    {
        static void Main(string[] args)
        {
            Pythagorean(3, 4, result =>
                Console.WriteLine($"Result = {result}"));
        }

        static void Sum(int a, int b, Action<int> cont)
        {
            cont(a + b);
        }

        static void Square(int x, Action<int> cont)
        {
            cont(x * x);
        }

        static void Pythagorean(int a, int b, Action<int> cont)
        {
            Square(a, a2 =>
                Square(b, b2 =>
                    Sum(a2, b2, cont)));
        }
    }
}
