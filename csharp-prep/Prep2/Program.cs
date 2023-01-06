using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade number: ");
        string valueFromUser = Console.ReadLine();
        int percent = int.Parse(valueFromUser);
        
        if (percent >= 90)
        {
            Console.WriteLine("Your grade is an A");
        }
        
        else if (percent >= 80)
        {
            Console.WriteLine("Your grade is a B");
        }

        else if (percent >= 70)
        {
            Console.WriteLine("Your grade is a C");
        }

        else if (percent >= 60)
        {
            Console.WriteLine("Your grade is a D");
        }

        else if (percent < 60)
        {
            Console.WriteLine("Your grade is an F");
        }
    }
}