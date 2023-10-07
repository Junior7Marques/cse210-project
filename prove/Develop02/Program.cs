class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Add a new entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Type your choice (1-5): ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Select a prompt:");
                        string[] prompts = {
                            "Who was the most interesting person I interacted with today?",
                            "What was the best part of my day?",
                            "How did I see the hand of the Lord in my life today?",
                            "What was the strongest emotion I felt today?",
                            "If I had one thing I could do over today, what would it be?"
                        };
                        for (int i = 0; i < prompts.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {prompts[i]}");
                        }
                        Console.Write("Enter the prompt number: ");
                        int promptNumber;
                        if (int.TryParse(Console.ReadLine(), out promptNumber) && promptNumber >= 1 && promptNumber <= prompts.Length)
                        {
                            string selectedPrompt = prompts[promptNumber - 1];
                            Console.Write("Enter your response: ");
                            string response = Console.ReadLine();
                            journal.AddEntry(selectedPrompt, response);
                            Console.WriteLine("Entry added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid prompt number.");
                        }
                        break;
                    case 2:
                        journal.DisplayEntries();
                        break;
                    case 3:
                        Console.Write("Enter a filename to save the journal: ");
                        string saveFilename = Console.ReadLine();
                        journal.SaveToFile(saveFilename);
                        Console.WriteLine("Journal saved to file successfully.");
                        break;
                    case 4:
                        Console.Write("Enter a filename to load the journal: ");
                        string loadFilename = Console.ReadLine();
                        journal.LoadFromFile(loadFilename);
                        Console.WriteLine("Journal loaded from file successfully.");
                        break;
                    case 5:
                        continueRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
