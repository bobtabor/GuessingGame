using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
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

                if (response.ToLower() == "q") {
                    break;
                }

                if (int.TryParse(response, out int userAnswer)) {
                    if (userAnswer == correctAnswer) {
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"You win!  It took you {counter} guesses.");
                        Console.ResetColor();
                        break;
                    } else if (userAnswer > correctAnswer) {
                        Console.WriteLine("Guess was too high.  Try again!");
                    } else {
                        Console.WriteLine("Guess was too low.  Try again.");
                    }
                } else {
                    Console.WriteLine("Invalid response.  Type a number between 1 and 10!");
                }

            } while (true);

        }
    }
}
