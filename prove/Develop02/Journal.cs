class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(string prompt, string response)
    {
        DateTime currentDate = DateTime.Now;
        entries.Add(new JournalEntry(currentDate, prompt, response));
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date:yyyy-MM-dd HH:mm:ss};{entry.Prompt};{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear(); // Clear existing entries before loading

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(';');
                if (parts.Length == 3)
                {
                    DateTime date = DateTime.Parse(parts[0]);
                    string prompt = parts[1];
                    string response = parts[2];
                    entries.Add(new JournalEntry(date, prompt, response));
                }
            }
        }
    }
}
