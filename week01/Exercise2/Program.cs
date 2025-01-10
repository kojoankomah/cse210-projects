using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage :   ");
        string gradePercentage = Console.ReadLine();

        int grade = int.Parse(gradePercentage);

        string letter;

        if(grade >= 90)
        {
            if (grade % 10 >= 5)
            {
                letter = "A";
            }
            else{
                letter = "A-";
            }
        }
        else if(grade >= 80)
        {
            if (grade % 10 >= 7)
            {
                letter = "B+";
            }else if(grade % 10 >= 3)
            {
                letter = "B-";
            }
            else{
                letter = "B";
            }        }
        else if(grade >= 70)
        {
            if (grade % 10 >= 7)
            {
                letter = "C+";
            }else if(grade % 10 >= 3)
            {
                letter = "C-";
            }
            else{
                letter = "C";
            }        }
        else if(grade >= 60)
        {
            if (grade % 10 >= 7)
            {
                letter = "D+";
            }else if(grade % 10 >= 3)
            {
                letter = "D-";
            }
            else{
                letter = "D";
            }        }
        else if(grade < 60)
        {
            letter = "F";
        }
        else{
            Console.WriteLine("Enter a valid grade percentage");
            letter = "";
        }

        Console.WriteLine($"You have earned a grade of {letter}!");


        if(grade >= 70)
        {
            Console.Write("Congratulation!! You passed the class keep it up!");
        }
        else{
            Console.Write("Sorry you did not pass the class best of luck in your next attempt!");
        }
    }
}