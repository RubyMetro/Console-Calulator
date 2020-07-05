using System;
using System.Collections.Generic;

namespace Console_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the console calculator! This program is pretty simple, it will let you do basic math.");
            bool tryAgain = true;
            var history = new List<string> {};
            string one;
            string two;
            double nOne;
            double nTwo;
            double answer;
            while (tryAgain == true)
            {
                Console.WriteLine("-a     add\n-s     subtract\n-m     multiply\n-d     divide\n-h     view history\n-e     exit\nthese will all only add 2 numbers.");
                string selectedOption = Console.ReadLine();
                selectedOption = selectedOption.ToLower();
                if (selectedOption == "a")
                {
                    Console.Clear();
                    Console.WriteLine("You have entered add mode, please type the first numer to add");
                    one = Console.ReadLine();
                    while(!double.TryParse(one, out nOne))
                    {
                        Console.WriteLine("Whoops! thats not a number, can you try that again?");
                        one = Console.ReadLine();
                    }
                    Console.WriteLine("ok, and now the second number?");
                    two = Console.ReadLine();
                    while (!double.TryParse(two, out nTwo))
                    {
                        Console.WriteLine("Whoops! thats not a number, can you try that again?");
                        two = Console.ReadLine();
                    }
                    answer = nOne + nTwo;
                    Console.WriteLine($"The answer is {answer}");
                    history.Add($"{answer}: {nOne} + {nTwo}");
                    Console.WriteLine("Would you like to calulate something else? (y/n)");
                    string tAgain = Console.ReadLine();
                    tAgain = tAgain.ToLower();
                    while (tAgain != "y" && tAgain != "n")
                    {
                        Console.WriteLine("Lets try that again, would you like to calulate something else? (y/n)");
                        tAgain = Console.ReadLine();
                    }
                    if (tAgain == "y")
                    {
                        Console.Clear();
                    }
                    else if (tAgain == "n")
                    {
                        Console.Clear();
                        tryAgain = false;
                    }
                }
                else if (selectedOption == "s")
                {
                    Console.Clear();
                    Console.WriteLine("You have entered subtract mode, please type the first numer to subtract");
                    one = Console.ReadLine();
                    while (!double.TryParse(one, out nOne))
                    {
                        Console.WriteLine("Whoops! thats not a number, can you try that again?");
                        one = Console.ReadLine();
                    }
                    Console.WriteLine("ok, and now the second number?");
                    two = Console.ReadLine();
                    while (!double.TryParse(two, out nTwo))
                    {
                        Console.WriteLine("Whoops! thats not a number, can you try that again?");
                        two = Console.ReadLine();
                    }
                    answer = nOne - nTwo;
                    Console.WriteLine($"The answer is {answer}");
                    history.Add($"{answer}: {nOne} - {nTwo}");
                    Console.WriteLine("Would you like to calulate something else? (y/n)");
                    string tAgain = Console.ReadLine();
                    tAgain = tAgain.ToLower();
                    while (tAgain != "y" && tAgain != "n")
                    {
                        Console.WriteLine("Lets try that again, would you like to calulate something else? (y/n)");
                        tAgain = Console.ReadLine();
                    }
                    if (tAgain == "y")
                    {
                        Console.Clear();
                    }
                    else if (tAgain == "n")
                    {
                        Console.Clear();
                        tryAgain = false;
                    }
                }
                else if (selectedOption == "m")
                {
                    Console.Clear();
                    Console.WriteLine("You have entered multiply mode, please type the first numer to multiply");
                    one = Console.ReadLine();
                    while (!double.TryParse(one, out nOne))
                    {
                        Console.WriteLine("Whoops! thats not a number, can you try that again?");
                        one = Console.ReadLine();
                    }
                    Console.WriteLine("ok, and now the second number?");
                    two = Console.ReadLine();
                    while (!double.TryParse(two, out nTwo))
                    {
                        Console.WriteLine("Whoops! thats not a number, can you try that again?");
                        two = Console.ReadLine();
                    }
                    answer = nOne * nTwo;
                    Console.WriteLine($"The answer is {answer}");
                    history.Add($"{answer}: {nOne} * {nTwo}");
                    Console.WriteLine("Would you like to calulate something else? (y/n)");
                    string tAgain = Console.ReadLine();
                    tAgain = tAgain.ToLower();
                    while (tAgain != "y" && tAgain != "n")
                    {
                        Console.WriteLine("Lets try that again, would you like to calulate something else? (y/n)");
                        tAgain = Console.ReadLine();
                    }
                    if (tAgain == "y")
                    {
                        Console.Clear();
                    }
                    else if (tAgain == "n")
                    {
                        Console.Clear();
                        tryAgain = false;
                    }
                }
                else if (selectedOption == "d")
                {
                    Console.Clear();
                    Console.WriteLine("You have entered divide mode, please type the first numer to divide");
                    one = Console.ReadLine();
                    while (!double.TryParse(one, out nOne) || one == "0")
                    {
                        Console.WriteLine("Whoops! either thats not a number or you tried to divide by 0, can you try that again?");
                        one = Console.ReadLine();
                    }
                    Console.WriteLine("ok, and now the second number?");
                    two = Console.ReadLine();
                    while (!double.TryParse(two, out nTwo) || two == "0")
                    {
                        Console.WriteLine("Whoops! either thats not a number or you tried to divide by 0, can you try that again?");
                        two = Console.ReadLine();
                    }
                    answer = nOne / nTwo;
                    Console.WriteLine($"The answer is {answer}");
                    history.Add($"{answer}: {nOne} / {nTwo}");
                    Console.WriteLine("Would you like to calulate something else? (y/n)");
                    string tAgain = Console.ReadLine();
                    tAgain = tAgain.ToLower();
                    while (tAgain != "y" && tAgain != "n")
                    {
                        Console.WriteLine("Lets try that again, would you like to calulate something else? (y/n)");
                        tAgain = Console.ReadLine();
                    }
                    if (tAgain == "y")
                    {
                        Console.Clear();
                    }
                    else if (tAgain == "n")
                    {
                        Console.Clear();
                        tryAgain = false;
                    }
                }
                else if (selectedOption == "h")
                {
                    Console.Clear();
                    if (history.Count == 0)
                    {
                        Console.Write("No history yet, press any key to continue");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Ok, here's this session's history.");
                        foreach (string calculation in history)
                        {
                            Console.WriteLine($"{calculation}");
                        }
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else if (selectedOption == "e")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("unknown command, please try again.");
                }
            }
        }
    }
}