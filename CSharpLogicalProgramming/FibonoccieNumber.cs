
using System;
using System.Diagnostics.CodeAnalysis;

namespace BasicCSharpProgramsDemo281Batch_
{
    public class FibonacciSeries
    {
        public static void GenerateFibonacciNumbers(int n)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            Console.WriteLine("Fibonacci Series:");
            Console.Write(firstNumber + " " + secondNumber);

            for (int i = 2; i < n; i++)
            {
                int nextNumber = firstNumber + secondNumber;
                Console.Write(" " + nextNumber);
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
        }

        public static void GenerateFibonacciNumb(int n)
        {
            int numb1 = 0, numb2 = 1;
            int addition = 0;
            Console.WriteLine("Printing fibonoccie series:");
            if (n == 1)
            {
                Console.WriteLine("{0}", numb1);
            }
            else if (n == 2)
            {
                Console.WriteLine("{0} {1}", numb1, numb2);
            }
            else
            {
                Console.WriteLine("{0} {1}", numb1, numb2);
                for (int i = 3; i <= n; i++)
                {
                    addition = numb1 + numb2;
                    Console.WriteLine("{0}", addition);
                    numb1 = numb2;
                    numb2 = addition;
                }
            }
        }
    }
}