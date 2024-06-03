namespace EventPlanning
{
    public class OutdoorMeeting : Event
    {
        private string weatherForecast;

        public OutdoorMeeting(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
            : base(title, description, date, time, address)
        {
            this.weatherForecast = weatherForecast;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Outdoor Meeting\nWeather Forecast: {weatherForecast}";
        }

        public override string GetShortDescription()
        {
            return $"Type: Outdoor Meeting\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
        }
    }
}
