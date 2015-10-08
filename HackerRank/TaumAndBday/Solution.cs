using System;
using System.Linq;

namespace HackerRank.TaumAndBday
{
    public class Solution
    {
        public void Solve()
        {
            int numberOfTestCases = int.Parse(Console.ReadLine());

            for (int testCaseIndex = 0; testCaseIndex < numberOfTestCases; testCaseIndex++)
            {
                Int64[] blackWhiteQuota = new Int64[2];
                blackWhiteQuota = Console.ReadLine().Split(' ').Select(Int64.Parse).ToArray<Int64>();
                Int64 blackQuota = blackWhiteQuota[0];
                Int64 whiteQuota = blackWhiteQuota[1];

                Int64[] blackWhiteConversionCosts = new Int64[3];
                blackWhiteConversionCosts = Console.ReadLine().Split(' ').Select(Int64.Parse).ToArray<Int64>();
                Int64 blackCost = blackWhiteConversionCosts[0];
                Int64 whiteCost = blackWhiteConversionCosts[1];
                Int64 conversionCost = blackWhiteConversionCosts[2];

                Console.WriteLine(ComputeTotalCost(blackQuota, whiteQuota, blackCost, whiteCost, conversionCost));
            }
        }

        /// <summary>
        /// Get the total cost of buying the quota of whites and blacks based on the cost of each,
        /// and the cost of converting one to the other. If it's cheaper to convert than to buy a
        /// unit of one colour, the cost will be calculated by the other unit plus the conversion cost.
        /// </summary>
        /// <param name="blackQuota">Number of black units to buy</param>
        /// <param name="whiteQuota">Number of white units to buy</param>
        /// <param name="blackCost">Cost of a black unit</param>
        /// <param name="whiteCost">Cost of white unit</param>
        /// <param name="conversionCost">Cost of converting a black to a white or vice versa</param>
        /// <returns>The total cost of buying the black and white quota of units</returns>
        public Int64 ComputeTotalCost(Int64 blackQuota, Int64 whiteQuota, Int64 blackCost, Int64 whiteCost, Int64 conversionCost)
        {
            Int64 totalCost = 0;

            // convert all whites to black if it's cheaper than buying blacks
            if ((whiteCost + conversionCost) < blackCost)
            {
                totalCost += ((whiteCost + conversionCost) * blackQuota);
            }
            else
            {
                totalCost += (blackCost * blackQuota);
            }

            // convert all blacks to white if it's cheaper than buying whites
            if ((blackCost + conversionCost) < whiteCost)
            {
                totalCost += ((blackCost + conversionCost) * whiteQuota);
            }
            else
            {
                totalCost += (whiteCost * whiteQuota);
            }

            return totalCost;
        }
    }
}
