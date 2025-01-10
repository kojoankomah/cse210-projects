using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        int number;
        string numb = "";

        int sum = 0;
        int numbCount = 0;
        float average;
        int smallestPositiveNumber = 1000000000;

        int maxNumber = 0;

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        while(numb != "0")
        {
            Console.Write("Enter a number :  ");
            numb = Console.ReadLine();
            number = int.Parse(numb);

            if(number < 0 || number > 0){
                numbers.Add(number);
                sum += number;
                numbCount += 1;
            foreach(int num in numbers)
            {
                if (num < smallestPositiveNumber && num > 0){
                    smallestPositiveNumber = num;
                }
            }
            }


        }
        average = ((float)sum)/numbCount;
        for(int i = 0;i < numbers.Count; i++){
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
        }
        // Console.WriteLine($"Number count : {numbCount}");
        Console.WriteLine($"The sum is : {sum} ");
        Console.WriteLine($"The average is : {average} ");
        Console.WriteLine($"The largest number is : {maxNumber} ");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        Console.WriteLine($"The sorted list is: ");

        numbers.Sort();
        for(int i = 0; i < numbers.Count; i++)
            {
            Console.WriteLine(numbers[i]);
            }

    }
}