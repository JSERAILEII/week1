using System;
using System.Collections.Generic;
using System.Text;

namespace week1
{
    class Project1
    {
        static void Main(string[] args)
        {
            
            double dblHeight, dblWeight, dblBMI;
            dblHeight = Utils.GetNumber("Enter Height in inches: ");
            dblWeight = Utils.GetNumber("Enter Weight in pounds: ");
            dblBMI = (dblWeight * 703) / (dblHeight * dblHeight);

            //issue result and message
         //   Console.WriteLine("Your BMI is " + db1BMI);
        //   if (db1BMI < 18.5)
            {
                Console.WriteLine("BMI < 18.5 - Underweight");
            }
         //   else if (db1BMI <= 24.9)
            {
                Console.WriteLine("BMI between 18.5 and 24.9 - Normal");
            }
         //   else if (db1BMI <= 29.9)
            {
                Console.WriteLine("BMI >= 30 - Obese");
            }
            Console.ReadLine();
        }
    
        }
    }

