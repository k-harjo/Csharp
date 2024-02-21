using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine().ToLower();
        string[] words = input.Split();
        var nonDuplicates = words.Distinct().OrderBy(w => w);
        Console.WriteLine("Non-duplicate words (in alphabetical order):");
        foreach (string word in nonDuplicates)
        {
            Console.WriteLine(word);
        }
    }
}