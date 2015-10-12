using System;
using System.Linq;

namespace HackerRank.Solutions.Implementation.ServiceLane
{
    public class Solution
    {
        public int[] ServiceLane { get; set; }

        public Solution()
        {
        }

        public Solution(int[] serviceLane)
        {
            ServiceLane = serviceLane;
        }

        public void Solve()
        {
            int[] freewayLengthAndNumberOfTestCases = Console.ReadLine().Split(' ').Select(int.Parse).ToArray<int>();
            int freewayLength = freewayLengthAndNumberOfTestCases[0];
            int numberOfTestCases = freewayLengthAndNumberOfTestCases[1];
            int[] serviceLane = new int[freewayLength];
            serviceLane = Console.ReadLine().Split(' ').Select(int.Parse).ToArray<int>();
            ServiceLane = serviceLane;

            for (int testCaseIndex = 0; testCaseIndex < numberOfTestCases; testCaseIndex++)
            {
                int[] entryRange = Console.ReadLine().Split(' ').Select(int.Parse).ToArray<int>();
                int entryIndex = entryRange[0];
                int exitIndex = entryRange[1];

                Console.WriteLine(FindLocalMinimum(entryIndex, exitIndex));
            }
        }

        /// <summary>
        /// Find the minimum value in the array between two indexes
        /// </summary>
        /// <param name="entryIndex">The index to start from</param>
        /// <param name="exitIndex">The index to finish at</param>
        /// <returns>The lowest value in the service lane array between the two indexes</returns>
        public int FindLocalMinimum(int entryIndex, int exitIndex)
        {
            int maxVehicleWidth = 3;

            for (int segmentIndex = entryIndex; segmentIndex <= exitIndex; segmentIndex++)
            {
                int currentSegmentWidth = ServiceLane[segmentIndex];

                if (currentSegmentWidth < maxVehicleWidth)
                {
                    maxVehicleWidth = currentSegmentWidth;
                }
            }

            return maxVehicleWidth;
        }
    }
}
