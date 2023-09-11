using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string namef = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string namel = Console.ReadLine();

        Console.WriteLine($"Your name is {namel}, {namef} {namel}");
    }
}