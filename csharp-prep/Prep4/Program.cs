using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");

            string response = Console.ReadLine();
            number = int.Parse(response);

            if (number != 0)
            {
                numbers.Add(number);
            }

        }
        int sum = 0;
        foreach (int answernumber in numbers)
        {
            sum += answernumber;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int answernumber in numbers)
        {
            if (answernumber > max)
            {
                max = answernumber;
            }

        }

        Console.WriteLine($"The max is: {max}");
    
    } 
}