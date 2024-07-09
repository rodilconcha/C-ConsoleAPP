
using System;

namespace MathOperationsApp
{
    public class MathMethod
    {
        public void PerformMathOperation(int num1, int num2)
        {
            // Perform the math operation (e.g., divide num1 by 2)
            int result = num1 / 2;
            Console.WriteLine($"Result: {result}");
        }
    }
}

// Program.cs
//using System;

namespace MathOperationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMethod mathInstance = new MathMethod();

            Console.Write("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Call the method, passing the user input
            mathInstance.PerformMathOperation(userInput, num2: 0); // num2 doesn't matter here

            
        }
    }
}