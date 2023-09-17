using System;

class Program
{
    static void Main(string[] args)
    {
           int Unumber = -1;
        List<int> numbers = new List<int>();
        while (Unumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished:  ");
            Unumber = int.Parse(Console.ReadLine());
            if (Unumber !=0)
            {
                numbers.Add(Unumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"Sum = {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}