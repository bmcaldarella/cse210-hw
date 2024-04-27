using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main(string[] args) {
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;
        while (number != 0) {
            Console.Write("Enter number: ");
            number = Convert.ToInt32(Console.ReadLine());
            numbers.Add(number);
        }

        numbers.Remove(0); // Remove the last 0 entered

        if (numbers.Count == 0) {
            Console.WriteLine("No numbers entered!");
            return;
        }

        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenge
        List<int> positiveNumbers = numbers.Where(n => n > 0).ToList();
        if (positiveNumbers.Count > 0) {
            int smallestPositive = positiveNumbers.Min();
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        } else {
            Console.WriteLine("No positive numbers entered!");
        }

        List<int> sortedNumbers = numbers.OrderBy(n => n).ToList();
        Console.WriteLine("The sorted list is:");
        foreach (int num in sortedNumbers) {
            Console.WriteLine(num);
        }
    }
}
