using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EternalQuest.Models;

namespace EternalQuest.Services
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void AddGoal(Goal goal)
        {
            _goals.Add(goal);
        }

        public void RecordEvent(string goalName)
        {
            var goal = _goals.FirstOrDefault(g => g.Name == goalName);
            if (goal != null)
            {
                goal.RecordEvent();
                _score += goal.Points;
                if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
                {
                    _score += checklistGoal.BonusPoints;
                }
            }
        }

        public void ShowGoals()
        {
            foreach (var goal in _goals)
            {
                Console.WriteLine($"{goal.GetProgress()} {goal.Name}");
            }
        }

        public void ShowScore()
        {
            Console.WriteLine($"Current Score: {_score}");
        }

        public void SaveGoals(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score);
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.ToStringRepresentation());
                }
            }
        }

        public void LoadGoals(string filename)
        {
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                _score = int.Parse(lines[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(",");
                    string goalType = parts[0];

                    Goal goal = goalType switch
                    {
                        "SimpleGoal" => new SimpleGoal(lines[i]),
                        "EternalGoal" => new EternalGoal(lines[i]),
                        "ChecklistGoal" => new ChecklistGoal(lines[i]),
                        _ => throw new Exception("Unknown goal type")
                    };

                    _goals.Add(goal);
                }
            }
        }
    }
}
