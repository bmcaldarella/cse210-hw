namespace EternalQuest.Models
{
    public class ChecklistGoal : Goal
    {
        private int _target;
        private int _timesCompleted;
        private int _bonusPoints;

        public ChecklistGoal(string name, int points, int target, int bonusPoints) : base(name, points)
        {
            _target = target;
            _timesCompleted = 0;
            _bonusPoints = bonusPoints;
        }

        public ChecklistGoal(string serializedGoal) : base(serializedGoal)
        {
            string[] parts = serializedGoal.Split(",");
            _target = int.Parse(parts[3]);
            _timesCompleted = int.Parse(parts[4]);
            _bonusPoints = int.Parse(parts[5]);
        }

        public override void RecordEvent()
        {
            _timesCompleted++;
        }

        public override bool IsComplete()
        {
            return _timesCompleted >= _target;
        }

        public override string GetProgress()
        {
            return $"Completed {_timesCompleted}/{_target} times";
        }

        public override string ToStringRepresentation()
        {
            return $"ChecklistGoal,{Name},{Points},{_target},{_timesCompleted},{_bonusPoints}";
        }

        public int BonusPoints
        {
            get { return _bonusPoints; }
        }
    }
}
