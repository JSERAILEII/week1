using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class ExtraPrac
    {
        static void Main(string[] args)
        {
            int size = week1.Utils.GetNumber("Enter Array size: ");
            int[] arrayOfNums = new int[size];
            for (int i = 0; i < size; i++)
            {
                arrayOfNums[i] = week1.Utils.GetNumber($"#{i}: ");
            }
            int largest = arrayOfNums[0];
            int smallest = arrayOfNums[0];
            foreach (var num in arrayOfNums)
            {
                if (num < smallest)
                {
                    smallest = num;
                }

                if (num < largest)
                {
                    largest = num;
                }
            }
            Console.WriteLine(String.Join("", arrayOfNums));
            Console.WriteLine($"This is the smallest number {smallest}");
            Console.WriteLine($"This is the largest number {largest}");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.WriteLine(i + " "+arrayOfNums [i] );
            }
        }
    }
}

