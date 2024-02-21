using System;

namespace MileageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles = 0;
            int gallons = 0;
            int totalMiles = 0;
            int totalGallons = 0;

            Console.WriteLine("Enter miles driven and gallons used (or -1 to quit):");

            while (true)
            {
                Console.Write("Miles: ");
                miles = Convert.ToInt32(Console.ReadLine());

                if (miles == -1)
                {
                    break;
                }

                Console.Write("Gallons: ");
                gallons = Convert.ToInt32(Console.ReadLine());

                double mpg = (double)miles / gallons;
                double totalMpg = (double)totalMiles / totalGallons;

                Console.WriteLine("Miles per gallon for this tankful: " + mpg.ToString("0.00"));
                Console.WriteLine("Combined miles per gallon up to this point: " + totalMpg.ToString("0.00"));

                totalMiles += miles;
                totalGallons += gallons;
            }
        }
    }
}
