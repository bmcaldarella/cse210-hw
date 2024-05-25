using System;
using EternalQuest.Models;
using EternalQuest.Services;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager manager = new GoalManager();

            manager.AddGoal(new SimpleGoal("Run a marathon", 1000));
            manager.AddGoal(new EternalGoal("Read scriptures", 100));
            manager.AddGoal(new ChecklistGoal("Attend temple", 50, 10, 500));

            manager.RecordEvent("Read scriptures");
            manager.RecordEvent("Attend temple");
            manager.RecordEvent("Attend temple");

            manager.ShowGoals();
            manager.ShowScore();

            string filename = "goals.txt";
            manager.SaveGoals(filename);
            manager.LoadGoals(filename);

            manager.ShowGoals();
            manager.ShowScore();
        }
    }
}
