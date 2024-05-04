class Journal
{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

 public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter the filename to save: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter the filename to load: ");
        string filename = Console.ReadLine();
        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            DateTime date = DateTime.Parse(parts[0]);
            string prompt = parts[1];
            string response = parts[2];

            entries.Add(new Entry(prompt, response, date));
        }
        Console.WriteLine("Journal loaded successfully.");
    }



 public void WriteNewEntry()
    {
        Console.WriteLine("Select a prompt for your entry:");
        for (int i = 0; i < prompts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {prompts[i]}");
        }
        Console.Write("Enter the number of the prompt: ");
        int promptIndex = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Enter your response: ");
        string response = Console.ReadLine();
        entries.Add(new Entry(prompts[promptIndex], response, DateTime.Now));
        Console.WriteLine("Entry added successfully.");
    }
}