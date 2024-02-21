using System;

namespace OddIntegersProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int product = 1;

            for (int i = 1; i <= 7; i += 2)
            {
                product *= i;
            }

            Console.WriteLine("Product of the odd integers from 1 to 7 is: " + product);
        }
    }
}
