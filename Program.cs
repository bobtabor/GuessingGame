using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number between 1 and 10.");

            Random random;
            random = new Random();
            int correctAnswer = random.Next(1, 11);

            int counter = 0;

            do {

                // counter = counter + 1;
                counter++;

                Console.Write($"Guess #{counter}? ");
                string response;
                response = Console.ReadLine();

                if (int.TryParse(response, out int userAnswer)) {
                    if (userAnswer == correctAnswer) {
                        Console.WriteLine($"You win!  It took you {counter} guesses.");
                        break;
                    } else {
                        Console.WriteLine("Nope.  Guess again!");
                    }
                } else {
                    Console.WriteLine("Cannot work with your response.  You lose!");
                }

            } while (true);

        }
    }
}
