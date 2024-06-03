using System;

namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        private int laps;

        public Swimming(DateTime date, int duration, int laps)
            : base(date, duration)
        {
            this.laps = laps;
        }

        public override double GetDistance()
        {
            return laps * 50 / 1000.0 * 0.62; // Convertir a millas
        }

        public override double GetSpeed()
        {
            return (GetDistance() / Duration) * 60;
        }

        public override double GetPace()
        {
            return Duration / GetDistance();
        }

        public override string GetSummary()
        {
            return $"{Date.ToShortDateString()} Swimming ({Duration} min): distance {GetDistance():0.0} miles, speed {GetSpeed():0.0} mph, pace: {GetPace():0.0} min per mile, laps: {laps}";
        }
    }
}
