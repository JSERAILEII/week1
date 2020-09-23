using System;

namespace week1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            // Ask the user to enter two numbers. we did something like this in the last lab for Batting Average
            // add the two numbers
           
            int num1 = Utils.GetNumber("what is your number?");
            int num2 = Utils.GetNumber("what is your second number?");
             sum = num1 + num2;
            Console.WriteLine("{0} = {1} plus {2}", sum, num1, num2);
            sum = num1 * num2;
            Console.WriteLine("{0} = {1} multiply {2}", sum, num1, num2);
            sum = num1 % num2;
            Console.WriteLine("{0} = {1} divide {2}", sum, num1, num2);
           
        }
    }
}
