

using System;

class AirlineReservationSystem
{
    static bool[] seats = new bool[10];

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please type 1 for First Class or 2 for Economy:");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                if (AssignSeat(0, 4))
                    break;
                else if (AskForUpgrade())
                    AssignSeat(0, 4);
            }
            else if (choice == 2)
            {
                if (AssignSeat(5, 9))
                    break;
                else if (AskForUpgrade())
                    AssignSeat(0, 4);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        Console.WriteLine("Thank you for using our airline reservation system!");
        Console.ReadLine();
    }

    static bool AssignSeat(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            if (!seats[i])
            {
                seats[i] = true;
                Console.WriteLine($"Seat {i + 1} has been assigned.");
                return true;
            }
        }

        Console.WriteLine("Sorry, there are no seats available in that section.");
        return false;
    }

    static bool AskForUpgrade()
    {
        Console.WriteLine("Would you like to be placed in the other section? (Y/N)");
        string choice = Console.ReadLine().ToLower();

        if (choice == "y")
            return true;
        else if (choice == "n")
            Console.WriteLine("Next flight leaves in 3 hours.");
        else
            Console.WriteLine("Invalid choice. Next flight leaves in 3 hours.");

        return false;
    }
}
