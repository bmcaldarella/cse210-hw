namespace EventPlanning
{
    public class Conference : Event
    {
        private string speaker;
        private int capacity;

        public Conference(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
            : base(title, description, date, time, address)
        {
            this.speaker = speaker;
            this.capacity = capacity;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Conference\nSpeaker: {speaker}\nCapacity: {capacity}";
        }

        public override string GetShortDescription()
        {
            return $"Type: Conference\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
        }
    }
}
