using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number between 1 and 10.");
            Console.Write("What is your guess? ");

            string response;
            response = Console.ReadLine();

            Console.WriteLine("You responded: " + response);

            Console.WriteLine("You win!");
        }
    }
}
