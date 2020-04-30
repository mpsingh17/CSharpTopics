using System;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = number => number * number;

            Console.WriteLine(square(5));
        }
    }
}
