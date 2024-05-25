namespace EternalQuest.Models
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, int points) : base(name, points)
        {
            _isComplete = false;
        }

        public SimpleGoal(string serializedGoal) : base(serializedGoal)
        {
            _isComplete = bool.Parse(serializedGoal.Split(",")[3]);
        }

        public override void RecordEvent()
        {
            _isComplete = true;
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetProgress()
        {
            return _isComplete ? "[X]" : "[ ]";
        }

        public override string ToStringRepresentation()
        {
            return $"SimpleGoal,{Name},{Points},{_isComplete}";
        }
    }
}
