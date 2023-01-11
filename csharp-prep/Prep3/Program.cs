using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);

        int guess = -1;
        
        while (guess != number)
        {
            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Guess higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Guess lower");
            }
            else
            {
                Console.WriteLine("You guessed it correctly!");
            }
{
            "name": "Foundation 4 (Exercise)",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build-final-Foundation4",
            "program": "${workspaceFolder}/final/Foundation4/bin/Debug/net7.0/Foundation4.dll",
            "args": [],
            "cwd": "${workspaceFolder}/final/Foundation4",
            "console": "integratedTerminal",
            "internalConsoleOptions": "neverOpen",
            "stopAtEntry": false
        },
        }
    }
}