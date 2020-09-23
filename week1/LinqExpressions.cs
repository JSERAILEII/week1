using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace week1
{
    class LinqExpressions
    {
        static void Main(string[] args)
        {
            // let's play with arrays of numbers using the LINQ statements
            double total;
            double biggest, littlest, average;
            double[] numbers = { 12, 3, 2, 743, 6, 2, 302, 2242, 2, 5, 3312, 3, 621, 2, 5, 4 };

            // get the average number of all elements in the array
            // do you want to do it like this
            total = 0;
            foreach (var n in numbers)
            {
                total += n;
            }
            average = total / numbers.Length;
            Console.WriteLine($"The average is: {average}");
            // or would you rather be very clever and do it with one line of code?
            average = numbers.Average();
            Console.WriteLine($"The average is: {average}");
            bool allPositive = numbers.All(nextNum => nextNum > 0);
            bool anyPositive = numbers.Any(nextNum => nextNum > 0);

            bool contains5 = numbers.Contains(5);
            var unique = numbers.Distinct().OrderByDescending(n => n);
            var firstNum = numbers.First();
            var lastNum = numbers.Last();
            Console.WriteLine();
            //All, Any, Average, Contains, Count, Distinct, ElementAt, Empty, First, Last, 
            //Max, Min, OrderBy(Descending), Reverse, Skip, Sum, Take, TakeLast, Where

            int[] randomNums = { 43, 6, 31, 84, -21, -8, 5, 6, -21, 64, 6, 43, -8, -100, -8, 874, 42 };
            var reverse = randomNums.Reverse();
            var skip = reverse.Skip(5);
            var take = skip.Take(5);
            take = randomNums.OrderBy(n => n).Skip(5).Take(5);
            Console.WriteLine();
            // what is the largest number in the array
            var max = randomNums.Max();
            // what is the smallest number
            var min = randomNums.Min();
            // what is the total of all of the randomNums
            var sum = randomNums.Sum();
            // get a list of all numbers WHERE  the number is > 45
            var where = randomNums.Where(nextNum => nextNum > 45);
            // total all numbers ? 45
            var sum2 = where.Sum();

            //  Given this list of numbers, do the following problems and print the result for each.

            int[] smallNumbers = { 5,3,3,6,3,4,6,3,5,7,8,5 };

            //  (3 pts) What is the smallest number ?
            int smallNums = smallNumbers.Min();
            // (3 pts) What is the largest number ?
            int largeNums = smallNumbers.Max();
            // (3 pts) Count the numbers
            int numsCount = smallNumbers.Count();
            // (3 pts) What is the last number in the list?
            int numsLast = smallNumbers.Last();
            //(3 pts) Skip the first 5 numbers, take the next 5 numbers
            var searchSkip = smallNumbers.Skip(5).Take(5);
            //(3 pts) Are any numbers bigger than 7 ?
            var numsBigger = smallNumbers.Where(nextNum => nextNum > 7);
            //(3 pts) Create a list of the numbers greater than or equal to 7
            var numsGreater = smallNumbers.Any(nextNum => nextNum >= 7);
            //(3 pts) What is the sum of all the numbers in the list?
            var numsSum = smallNumbers.Sum();
            //(3 pts) Do this with Sum and do it with Aggregate
            total = smallNumbers.Aggregate((total, num) => total += num);
            //(3 pts) Create a list of the unique elements of the list
            var numsUnique = smallNumbers.Distinct().OrderByDescending(n => n);
            string[] animals = { "moose", "ferret", "gnu", "ant", "cow", "emu", "deer", "hippo", "bear", "jackalop", "lama" };

            //  how many animals are longer than 4
            int animalCnt = animals.Where(a => a.Length > 4).Count();
            //  find animals that end with 'u'. use your method to print them
            var endsWithU = animals.Where(a => a.EndsWith("u"));
            //  order the animals alphabetically and print
            var alphaOrder = animals.OrderBy(n => n);
            //  what is the longest name
            string longest = animals.Aggregate("", (max, nextAnimal) => max.Length > nextAnimal.Length ? max : nextAnimal);
            
            longest = animals.OrderByDescending(s => s.Length).First();
            var sorted = animals.OrderByDescending(s => s.Length);

        }
    }
}
