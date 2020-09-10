using System;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
        }

        private static int Add(int tal1, int tal2)
        {
            var sum = 0;

            sum = tal1 + tal2;

            return sum;
        }
    }
}
