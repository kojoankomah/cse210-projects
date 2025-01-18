using System.ComponentModel.DataAnnotations;

public class Journal{
    private List<Entry> _entries = new List<Entry>();
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one lesson I learned today?",
        "What am I most grateful for today?"
    };

    public void AddEntry()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine(prompt);
        Console.Write("Your response:  ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-mm-dd");
        Console.Write("From where are you making this entry? : ");
        string location = Console.ReadLine();
        
         _entries.Add(new Entry(prompt, response, date, location));

        Console.WriteLine("Entry successfully added!");
    }

    public void DisplayJournal(){
        if(_entries.Count == 0){
            Console.WriteLine("No entries to display.");
            return;
        }
        Console.WriteLine();
        Console.WriteLine("----------------START------------------");
        Console.WriteLine("Journal Entries: ");
        Console.WriteLine();

        foreach (var entry in _entries)
        {
            entry.Display();
        }
        
        Console.WriteLine("------------------END-------------------");
    }

    public void SaveToFile()
    {
        Console.Write("Enter the filename to save (eg. record.txt): ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach(var entry in _entries)
            {
                writer.WriteLine($"Date: {entry.Date}");
                writer.WriteLine($"Prompt: {entry.Prompt}");
                writer.WriteLine($"Response: {entry.Response}");
                writer.WriteLine($"Location: {entry.Location}");
                writer.WriteLine();
            }
        }

        Console.WriteLine("Journal saved successfully to a text file!");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter the filename to load (eg. record.txt):  ");
        string filename = Console.ReadLine();

        if(!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();

        using(StreamReader reader = new StreamReader(filename))
        {
            string line;
            string date = "", prompt = "", response = "", location = "";
            while((line =reader.ReadLine()) != null)
            {
                if(line.StartsWith("Date: "))
                {
                    date = line.Substring(6);
                }
                else if (line.StartsWith("Prompt: "))
                {
                    prompt = line.Substring(8);
                }
                else if (line.StartsWith("Response: "))
                {
                    response = line.Substring(10);
                }
                else if(line.StartsWith("Location: ")){
                    location = line.Substring(10);
                }
                else if (string.IsNullOrWhiteSpace(line))
                {
                    _entries.Add(new Entry(prompt, response, date, location));
                }
            }
        }

        Console.WriteLine("Journal loaded successfully from a text file!");
    }
}