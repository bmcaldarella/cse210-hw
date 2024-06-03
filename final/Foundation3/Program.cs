using System;

namespace EventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("1 Mains", "Springfield", "IL", "USA");
            Address address2 = new Address("4 Elm", "Vancouver", "BC", "Canada");
            Address address3 = new Address("23 Oak St", "London", "England", "UK");

            Conference conference = new Conference("Tech Conference", "A conference about the latest in tech.", new DateTime(2024, 8, 10), new TimeSpan(9, 0, 0), address1, "Smith", 150);
            Reception reception = new Reception("Networking Reception", "An evening of networking with industry professionals.", new DateTime(2024, 8, 15), new TimeSpan(18, 0, 0), address2, "lorem@nlorem.com");
            OutdoorMeeting outdoorMeeting = new OutdoorMeeting("Summer Picnic", "A fun outdoor picnic with games and food.", new DateTime(2024, 7, 20), new TimeSpan(12, 0, 0), address3, "Sunny with a chance of showers");

            Console.WriteLine("Conference Details:");
            Console.WriteLine(conference.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(conference.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(conference.GetShortDescription());
            Console.WriteLine();

            Console.WriteLine("Reception Details:");
            Console.WriteLine(reception.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(reception.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(reception.GetShortDescription());
            Console.WriteLine();

            Console.WriteLine("Outdoor Meeting Details:");
            Console.WriteLine(outdoorMeeting.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(outdoorMeeting.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(outdoorMeeting.GetShortDescription());
            Console.WriteLine();
        }
    }
}
