namespace EternalQuest.Models
{
    public class EternalGoal : Goal
    {
        private int _timesRecorded;

        public EternalGoal(string name, int points) : base(name, points)
        {
            _timesRecorded = 0;
        }

        public EternalGoal(string serializedGoal) : base(serializedGoal)
        {
            _timesRecorded = int.Parse(serializedGoal.Split(",")[3]);
        }

        public override void RecordEvent()
        {
            _timesRecorded++;
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override string GetProgress()
        {
            return $"Recorded {_timesRecorded} times";
        }

        public override string ToStringRepresentation()
        {
            return $"EternalGoal,{Name},{Points},{_timesRecorded}";
        }
    }
}
