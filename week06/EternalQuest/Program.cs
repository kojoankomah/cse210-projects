// To show creativity 
// Instead of clearing the the console before displaying goals, I print a separator line for readability and also access to past result
// I included a leveling feature based on points as a motivational addition. It encourages users to keep completing goals.


using System;

class Program
{
    static void Main(string[] args)
    {

        GoalManager newProgram = new GoalManager();
        newProgram.Start();
    }
}