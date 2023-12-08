using System;

class Program
{
    static void Main()
    {
        // Events
        Address address = new Address("123 Main St", "Cityville", "Stateville", "12345");

        Event genericEvent = new Event("Generic Event", "This is a generic event.", DateTime.Now, "10:00 AM", address);
        Lecture lectureEvent = new Lecture("Interesting Lecture", "Learn about interesting topics.", DateTime.Now, "2:00 PM", address, "Pres. Russel M. Nelson", 700);
        Reception receptionEvent = new Reception("Social Reception", "A casual social gathering.", DateTime.Now, "6:00 PM", address, "rsvp@example.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Park Picnic", "Enjoy a day in the park.", DateTime.Now, "12:00 PM", address, "Sunny with a chance of clouds");

        // Marketing messages
        Console.WriteLine("Standard Details:");
        Console.WriteLine(genericEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(outdoorEvent.GetFullDetails());
    }
}