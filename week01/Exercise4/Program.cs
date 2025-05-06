using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Welcome! Let's collect a list of numbers.");
        Console.WriteLine("Type '0' when you're finished.\n");

        while (true)
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input == 0) break;
                numbers.Add(input);
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers entered. Exiting program.");
            return;
        }

        int sum = CalculateSum(numbers);
        double average = CalculateAverage(sum, numbers.Count);
        int max = FindMax(numbers);
        int smallestPositive = FindSmallestPositive(numbers);

        DisplayResults(sum, average, max, smallestPositive, numbers);
    }

    static int CalculateSum(List<int> numbers)
    {
        int sum = 0;
        foreach (var num in numbers) sum += num;
        return sum;
    }

    static double CalculateAverage(int sum, int count)
    {
        return (count > 0) ? (double)sum / count : 0;
    }

    static int FindMax(List<int> numbers)
    {
        int max = numbers[0];
        foreach (var num in numbers)
        {
            if (num > max) max = num;
        }
        return max;
    }

    static int FindSmallestPositive(List<int> numbers)
    {
        int smallestPositive = int.MaxValue;
        foreach (var num in numbers)
        {
            if (num > 0 && num < smallestPositive)
                smallestPositive = num;
        }
        return smallestPositive == int.MaxValue ? -1 : smallestPositive;
    }

    static void DisplayResults(int sum, double average, int max, int smallestPositive, List<int> numbers)
    {
        Console.WriteLine("\n--- Results ---");
        Console.WriteLine($"Total sum of numbers: {sum}");
        Console.WriteLine($"Average of numbers: {average:F2}");
        Console.WriteLine($"Largest number: {max}");

        if (smallestPositive != -1)
        {
            Console.WriteLine($"Smallest positive number: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }

        numbers.Sort();
        Console.WriteLine("\nSorted numbers:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
