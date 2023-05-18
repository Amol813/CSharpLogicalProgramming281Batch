using System;

namespace BasicCSharpProgramsDemo281Batch_
{
    internal class Calculator
    {
        public void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"Addition of {x} and {y} is: {result}");
        }

        public void SubtractTwoNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine($"Subtraction of {x} and {y} is: {result}");
        }

        public void MultiplyTwoNumbers(int x, int y)
        {
            int result = x * y;
            Console.WriteLine($"Multiplication of {x} and {y} is: {result}");
        }

        public void DivideTwoNumbers(int x, int y)
        {
            if (y != 0)
            {
                double result = (double)x / y;
                Console.WriteLine($"Division of {x} and {y} is: {result}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }
    }
}