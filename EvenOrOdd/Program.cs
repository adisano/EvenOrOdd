using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Acquire user input
            Console.WriteLine("Enter a number:");
            string inputNumberStr = Console.ReadLine();

            //convert user input from string to integer
            int inputNumberInt = int.Parse(inputNumberStr);

            //Check the remainder of the integer
            int remainNumberInt = inputNumberInt % 2;

            //Assign a value to the string
            string evenOdd = (remainNumberInt == 0) ? "Even" : "Odd";

            //Output result
            Console.WriteLine("The number you entered was {0}", evenOdd);
            Console.ReadLine();
        }
    }
}
