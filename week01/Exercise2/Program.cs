using System;

class Program
{
    static void Main()
    {
        // Ask the user for their percentage grade
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter = "";
        string sign = "";

        // Find the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Figure out the + or - sign
        int lastDigit = grade % 10;

        if (letter != "F" && letter != "A")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && grade < 93)
        {
            sign = "-";
        }

        // Print the full grade
        Console.WriteLine($"Your final grade is: {letter}{sign}");

        // Check if the student passed
        if (grade >= 70)
        {
            Console.WriteLine("You passed! Good job.");
        }
        else
        {
            Console.WriteLine("You didn't pass, but don't give up! Try again.");
        }
    }
}
