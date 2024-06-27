using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");

            bool keepPlaying = true;

            while (keepPlaying)
            {
                PlayGame();
                keepPlaying = AskToPlayAgain();
            }

            Console.WriteLine("Thank you for playing. Goodbye!");
        }

        static void PlayGame()
        {
            Random random = new Random();
            int randomNum = random.Next(1, 11);
            bool correctGuess = false;

            Console.WriteLine("A number between 1 and 10 has been generated.");
            Console.WriteLine("You win if you can guess the correct number.");

            while (!correctGuess)
            {
                int guess = GetGuess();
                correctGuess = CheckGuess(guess, randomNum);
            }

            Console.WriteLine("Well done, you have won.");
        }

        static int GetGuess()
        {
            int guess;
            Console.WriteLine("Please enter your guess:");
            while (!int.TryParse(Console.ReadLine(), out guess) || guess < 1 || guess > 10)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
            }
            return guess;
        }

        static bool CheckGuess(int guess, int randomNum)
        {
            if (guess > randomNum)
            {
                Console.WriteLine("Your guess is too high. Try lower.");
                return false;
            }
            else if (guess < randomNum)
            {
                Console.WriteLine("Your guess is too low. Try higher.");
                return false;
            }
            else
            {
                Console.WriteLine("Your guess is correct!");
                return true;
            }
        }

        static bool AskToPlayAgain()
        {
            Console.WriteLine("Do you want to play again? (y/n)");
            string response = Console.ReadLine().ToLower();
            return response == "y";
        }
    }
}
