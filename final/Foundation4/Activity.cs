using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private DateTime date;
        private int duration; // en minutos

        public Activity(DateTime date, int duration)
        {
            this.date = date;
            this.duration = duration;
        }

        public DateTime Date
        {
            get { return date; }
        }

        public int Duration
        {
            get { return duration; }
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{Date.ToShortDateString()} {GetType().Name} ({Duration} min): distance {GetDistance():0.0} miles, speed {GetSpeed():0.0} mph, pace: {GetPace():0.0} min per mile";
        }
    }
}
