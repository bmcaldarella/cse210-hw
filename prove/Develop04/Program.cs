using System;
using System.Threading;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");
        Console.WriteLine("4. Quit");

        int choice = int.Parse(Console.ReadLine());
        int duration = 60; // Default duration in seconds

        if (choice == 4)
        {
            Console.WriteLine("Exiting program. Goodbye!");
            return;
        }

        Console.WriteLine("Enter duration (in seconds):");
        duration = int.Parse(Console.ReadLine());

        MindfulnessActivity activity;

        switch (choice)
        {
            case 1:
                activity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                break;
            case 2:
                activity = new ReflectionActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                break;
            case 3:
                activity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting program.");
                return;
        }

        activity.StartActivity(duration);
    }
}
