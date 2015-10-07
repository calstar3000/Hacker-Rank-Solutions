using System;

namespace HackerRank.ChocolateFeast
{
    public class Solution
    {
        public void Solve()
        {
            int numberOfTests = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfTests; i++)
            {
                string[] testCaseData = Console.ReadLine().Trim().Split(' ');
                int dollars = int.Parse(testCaseData[0]);
                int price = int.Parse(testCaseData[1]);
                int wrappers = int.Parse(testCaseData[2]);

                Console.WriteLine(FindNumberOfChocolates(dollars, price, wrappers));
            }

            Console.ReadKey();
        }

        public int FindNumberOfChocolates(int totalDollars, int pricePerChocolate, int wrappersPerChocolate)
        {
            int chocolatesBought = (totalDollars / pricePerChocolate);
            int wrappersLeft = chocolatesBought;

            while (wrappersLeft >= wrappersPerChocolate)
            {
                int extraChocolates = (wrappersLeft / wrappersPerChocolate);
                wrappersLeft = (wrappersLeft - (extraChocolates * wrappersPerChocolate)) + extraChocolates;
                chocolatesBought += extraChocolates;
            }

            return chocolatesBought;
        }
    }
}
