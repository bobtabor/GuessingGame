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

            int correctAnswer = 7;
            // int userAnswer = int.Parse(response);
            
            if (int.TryParse(response, out int userAnswer)) {

                if (userAnswer == correctAnswer) {
                    Console.WriteLine("You win!");    
                } else {
                    Console.WriteLine("You lose!");
                }

            } else {
                Console.WriteLine("Cannot work with your response.  You lose!");
            }
            
        }
    }
}
