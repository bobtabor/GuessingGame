using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number between 1 and 10.");
            Console.Write("What is your guess? ");
            Console.ReadLine();
            Console.WriteLine("You win!");
        }
    }
}
