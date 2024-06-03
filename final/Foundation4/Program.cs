using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>
            {
                new Running(new DateTime(2024, 6, 1), 30, 3.0),
                new Cycling(new DateTime(2024, 6, 2), 45, 15.0),
                new Swimming(new DateTime(2024, 6, 3), 60, 20)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
                Console.WriteLine();
            }
        }
    }
}
