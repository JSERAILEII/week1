using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Project:    Lab 2 Calculate Batting Average
            Date:        to/da/y
            Author:     You the big new programmer
            Notes:      This program reads in a baseball player's name,
            number of hits and number of at bats.
            The player's batting average is calculated and displayed
            */
            // Variable declaration
            string strPlayerName;
            double dblhits, nAtBats; // later we will see the need to change this to dboule dblHits, dblAtBats
            double dblBattingAverage;
            Console.WriteLine("Hello World!");
            Console.WriteLine("This program calculates a baseball player's batter average");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Enter player's name: ");
            strPlayerName = Console.ReadLine();                 //  or we could use the Utils class strPlayerName = Utils.GetInput("Enter player's name");

            //  prompt for hits and at bats
            Console.Write("Enter the player's # of hits: ");
            dblhits = Convert.ToInt32(Console.ReadLine());        //  or we could use the Utils class hHits = Utils.GetNumber("Enter the player's # of hits: ");
            Console.Write("Enter the player's # of at bats: ");
            nAtBats = Convert.ToInt32(Console.ReadLine()); // or we could use the Utils class hHits = Utils.GetNumber("Enter the player's # of at bats: ");
                                                           // calculation
            dblBattingAverage = dblhits / nAtBats;
            Console.WriteLine($"{strPlayerName}'s batting averate is {dblBattingAverage}");
        }
    }
}
