using BasicCSharpProgramsDemo281Batch_;
using CsharpLogicalProgramming;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Basic CSharp Programs Demo 281Batch!");
        Console.WriteLine("Please choose any one Program from below option");
        Console.WriteLine("1. Calculator\n2. Fibonacci Series\n3. Reverse a Word\n4. Reverse Each Word At Same Position\n5.PrimeNumber\n6.PerfectNumber");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.WriteLine("Welcome to Basic C# Programs");
                Calculator calculator = new Calculator();
                Console.WriteLine("Please enter the first number");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                int y = Convert.ToInt32(Console.ReadLine());
                calculator.AddTwoNumbers(x, y);
                calculator.SubtractTwoNumbers(x, y);
                calculator.MultiplyTwoNumbers(x, y);
                calculator.DivideTwoNumbers(x, y);
                break;
            case 2:
                Console.WriteLine("Please enter how many numbers you want to generate in the Fibonacci series");
                int n = Convert.ToInt32(Console.ReadLine());
                FibonacciSeries.GenerateFibonacciNumbers(n);
                //FibonacciSeries.GenerateFibonacciNumb(n);
                break;
            case 3:
                Console.WriteLine("Please Enter Any Word");
                string word = Console.ReadLine();
                ReverseProgram.ReverseWord(word);
                break;
            case 4:
                Console.WriteLine("Please Enter word");
                word = Console.ReadLine();
                ReverseProgram.ReverseEachWordInSamePosition(word);
                break;
            case 5:
                PrimeNumber prime = new PrimeNumber();
                Console.Write("Enter a number to check if it's a prime number: ");
                int primeInput = Convert.ToInt32(Console.ReadLine());
                bool isPrime = prime.IsPrimeNumber(primeInput);
                if (isPrime)
                {
                    Console.WriteLine(primeInput + " is a prime number.");
                }
                else
                {
                    Console.WriteLine(primeInput + " is not a prime number.");
                }
                break;
            case 6:
                PerfectNumber perf = new PerfectNumber();
                Console.Write("Enter a number to check if it's a perfect number: ");
                int input = Convert.ToInt32(Console.ReadLine());
                bool isPerfect = perf.IsPerfectNumber(input);
                if (isPerfect)
                {
                    Console.WriteLine(input + " is a perfect number.");
                }
                else
                {
                    Console.WriteLine(input + " is not a perfect number.");
                }
                break;

            default:
                Console.WriteLine("Please choose an existing program");
                break;
        }
    }
}