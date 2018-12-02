using System;

namespace Conditional.Cps
{
    class Program
    {
        static void Main(string[] args)
        {
            IsTrue(b =>
                Conditional<int>(
                    b,
                    c => Get5(c),
                    c => Get7(c),
                    v => Console.WriteLine(v)
                ));
        }

        static void Conditional<T>(
            bool b, 
            Action<Action<T>> cns, 
            Action<Action<T>> alt, 
            Action<T> cont)
        {
            if (b) 
                cns(cont);
            else 
                alt(cont);
        }

        static void IsTrue(Action<bool> cont)
        {
            cont(false);
        }

        static void Get5(Action<int> cont)
        {
            cont(5);
        }

        static void Get7(Action<int> cont)
        {
            cont(7);
        }
    }
}
