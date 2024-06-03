namespace EventPlanning
{
    public abstract class Event
    {
        private string title;
        private string description;
        private DateTime date;
        private TimeSpan time;
        private Address address;

        public Event(string title, string description, DateTime date, TimeSpan time, Address address)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.time = time;
            this.address = address;
        }

        public string Title
        {
            get { return title; }
        }

        public string Description
        {
            get { return description; }
        }

        public DateTime Date
        {
            get { return date; }
        }

        public TimeSpan Time
        {
            get { return time; }
        }

        public Address Address
        {
            get { return address; }
        }

        public string GetStandardDetails()
        {
            return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {Address.GetFullAddress()}";
        }

        public abstract string GetFullDetails();
        public abstract string GetShortDescription();
    }
}
