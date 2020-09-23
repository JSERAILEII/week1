using System;
using System.Collections.Generic;
using System.Text;

namespace week1
{
    class HW1
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int ans;
            
            Random rand = new Random();
            string strUserChoice;
            while (true)
            {
                strUserChoice = Utils.GetInput("Want anothe math problem? ");
                if (strUserChoice == "Y")
                {
                    num1 = rand.Next();
                    num2 = rand.Next();
                     ans = Utils.GetNumber("What is the sum of " + num1 + " + " + num2);
                }
                else
                {
                    break;
                }
                if (ans == num1 + num2)
                {
                    Console.WriteLine("Correct answer");
                }
                else
                {
                    Console.WriteLine("Try Again");

                }
            }
        }
    }
}
