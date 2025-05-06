using System;

class Program
{
    static void Main()
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int userGuess = 0;
            int guessCount = 0;

            Console.WriteLine("Welcome to the Guess My Number game!");

            while (userGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());

                guessCount++;

                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! The magic number was {magicNumber}. It took you {guessCount} guesses.");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}
