using System;

namespace FizzBuzzKata
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fz = new FizzBuzz();
            for (int x = 1; x < 101; x++)
            {
                Console.WriteLine(fz.Compute(x));
            }
            Console.ReadKey();

        }
    }
}
