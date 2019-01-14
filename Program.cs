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

            string correctAnswer = "7";

            Console.WriteLine("You responded: " + response);

            if (response == correctAnswer) {
                Console.WriteLine("You win!");    
            } else {
                Console.WriteLine("You lose!");
            }

            
        }
    }
}
