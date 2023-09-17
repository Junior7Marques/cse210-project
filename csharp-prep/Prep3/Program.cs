using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 10);
        int shoot = 0;
        int trys = 0;
        while (shoot != number)
        {
        Console.Write("Try to Guess the Number:  ");
        shoot = int.Parse(Console.ReadLine());
        if (shoot == number)
        {
            Console.Write("You guessed it!  ");
            Console.Write($"You tried {trys} times. ");
        }
        if (shoot > number)
        {
            Console.Write("Lower! ");
            trys += 1;
        }
        if (shoot < number)
        {
            Console.Write("Higher! ");
            trys += 1;
        }
        }
    }
}