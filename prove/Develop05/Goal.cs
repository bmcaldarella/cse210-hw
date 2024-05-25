using System;

namespace EternalQuest.Models
{
    public abstract class Goal
    {
        public string Name { get; private set; }
        public int Points { get; private set; }

        protected Goal(string name, int points)
        {
            Name = name;
            Points = points;
        }

        protected Goal(string serializedGoal)
        {
            string[] parts = serializedGoal.Split(",");
            Name = parts[1];
            Points = int.Parse(parts[2]);
        }

        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public abstract string GetProgress();
        public abstract string ToStringRepresentation();
    }
}
