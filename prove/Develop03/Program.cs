using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            new Scripture(new Reference("Alma", 32, 21), "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true."),
        };

        Random random = new Random();
        int randomIndex = random.Next(0, scriptures.Count);
        Scripture randomScripture = scriptures[randomIndex];

        Console.WriteLine(randomScripture.GetText());
        randomScripture.HideWord();
        Console.WriteLine(randomScripture.GetText());

        bool allWordsHidden = false;

        while (UserWantsToContinue() && !allWordsHidden)
        {
            randomScripture.HideWord();
            Console.WriteLine(randomScripture.GetText());
            allWordsHidden = randomScripture.AllWordsHidden();
        }
    }

    static bool UserWantsToContinue()
    {
        Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
        string input = Console.ReadLine();
        return input != "quit";
    }
}