using BasicCSharpProgramsDemo281Batch_;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Basic CSharp Programs Demo 281Batch!");
        Console.WriteLine("Please choose any one Program from below option");
        Console.WriteLine("1. Calculator\n2. Fibonnoci Series");
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
            default:
                Console.WriteLine("Please choose an existing program");
                break;
        }
    }
}