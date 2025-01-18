using System;
using System.Dynamic;


// To exceed requirements I save other information in the journal entry.
// The new information saved is the location the entry was made from
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string userInput = "";

        while(userInput != "5")
        {
            Console.WriteLine("What action do you want to perform with your journal? ");
            Console.WriteLine("1.  Write new entry");
            Console.WriteLine("2.  Display journal");
            Console.WriteLine("3.  Save journal to file");
            Console.WriteLine("4.  Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? :  ");
            userInput = Console.ReadLine();

            if(userInput == "1")
            {
                journal.AddEntry();
            }
            else if(userInput == "2")
            {
                journal.DisplayJournal();
            }
            else if(userInput == "3")
            {
                journal.SaveToFile();

            }
            else if (userInput == "4")
            {
                journal.LoadFromFile();

            }
            else if (userInput == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else{
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}