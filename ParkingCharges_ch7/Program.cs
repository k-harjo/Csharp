using System;

namespace ParkingGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalCharges = 0.0;

            Console.WriteLine("Enter hours parked (or -1 to quit):");

            while (true)
            {
                double hours = Convert.ToDouble(Console.ReadLine());

                if (hours == -1)
                {
                    break;
                }

                double charge = CalculateCharges(hours);

                Console.WriteLine("Customer charge: $" + charge.ToString("0.00"));

                totalCharges += charge;
            }

            Console.WriteLine("Total charges for yesterday: $" + totalCharges.ToString("0.00"));
        }

        static double CalculateCharges(double hours)
        {
            double minimumFee = 2.0;
            double hourlyRate = 0.5;
            double maximumFee = 10.0;

            if (hours <= 3)
            {
                return minimumFee;
            }
            else if (hours <= 24)
            {
                double additionalHours = hours - 3;
                double additionalFee = Math.Ceiling(additionalHours) * hourlyRate;

                return Math.Min(minimumFee + additionalFee, maximumFee);
            }
            else
            {
                return maximumFee;
            }
        }
    }
}
