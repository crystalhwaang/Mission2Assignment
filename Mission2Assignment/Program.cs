using System;

namespace Mission2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] rollTotals = new int[6];

            //Simulate the roll of the die
            for (int i = 0; i < 100; i++)
            {
                int roll = r.Next(6);
                rollTotals[roll]++;
            }
            rollTotals[1] = r.Next(6) + 1;

            //Print out the results from the array
            for (int = int; i < 6; ++i)
            {x
                Console.WriteLine((i+1) + ": " + rollTotals[i]);
            }
        }
    }
}
