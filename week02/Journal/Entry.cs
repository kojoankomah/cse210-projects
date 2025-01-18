using System.IO.Compression;

public class Entry{
    public string Prompt{get; set;}
    public string Response {get; set;}
    public string Date {get; set;}
    public string Location {get; set;}

    public Entry(string prompt, string response , string date , string location)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
        Location = location;

    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine($"Location :  {Location}");
        Console.WriteLine();
    }

    public string ToCsv()
    {
        string escape(string text) => $"\"{text.Replace("\"", "\"\"")}\"";
        return $"{escape(Date)}, {escape(Prompt)}, {escape(Response)}";

    }

    public static Entry FromCsv (string csvLine)
    {
        var parts = csvLine.Split(',');
        return new Entry(parts[3].Trim('\"').Replace("\"", "\""), parts[2].Trim('\"').Replace("\"", "\""), parts[1].Trim('\"').Replace("\"", "\""), parts[0].Trim('\"').Replace("\"", "\""));
    }
}