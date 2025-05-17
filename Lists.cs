using System;
using System.Collections.Generic;
using System.Linq; // Needed for Min() and Sort()

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int userNumber;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Collect numbers
        do
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        } while (userNumber != 0);

        // Core Requirements
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        float average = (float)sum / numbers.Count;
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenge 1: Smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // Stretch Challenge 2: Sorted list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
