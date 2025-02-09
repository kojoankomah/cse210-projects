using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment assignment1 = new Assignment("Kojo Ankomah", "Statistical Modeling");
        // Console.WriteLine(assignment1.GetSummary());
        MathAssignment mathAssignment1 = new MathAssignment("Kojo Ankomah", "Statistical Modeling", "7.3", "8-19");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeWorkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Kojo Ankomah","Europian History", "The Causes of World War II");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}