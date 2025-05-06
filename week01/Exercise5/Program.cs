using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!\nLet's get started!");
    }

    static string PromptUserName()
    {
        string userName;

        while (true)
        {
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(userName))
            {
                break;
            }
            else
            {
                Console.WriteLine("Your name can't be empty. Please try again.");
            }
        }

        return userName;
    }

    static int PromptUserNumber()
    {
        int userNumber;

        while (true)
        {
            Console.Write("What's your favorite number? ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out userNumber))
            {
                break;
            }
            else
            {
                Console.WriteLine("Oops! That wasn't a number. Please enter a valid number.");
            }
        }

        return userNumber;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"\n{userName}, the square of your favorite number is {squaredNumber}.\n");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();

        int favoriteNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(name, squaredNumber);
    }
}
