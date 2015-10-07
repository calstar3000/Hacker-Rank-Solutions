using System;
using System.Collections.Generic;

namespace HackerRank.CutTheSticks
{
    public class Solution
    {
        public void Solve()
        {
            Console.ReadLine();
            string[] stringStickLengths = Console.ReadLine().Split(' ');
            List<int> stickLengths = new List<int>();

            foreach (string stickLength in stringStickLengths)
            {
                stickLengths.Add(int.Parse(stickLength));
            }

            CutSticks(stickLengths);

            Console.ReadKey();
        }

        public void CutSticks(List<int> stickLengths)
        {
            while (stickLengths.Count > 0)
            {
                Console.WriteLine(stickLengths.Count);

                int minStickLength = FindMinStickLength(stickLengths);

                List<int> remainingStickLengths = PerformCut(stickLengths, minStickLength);

                CutSticks(remainingStickLengths);
            }
        }

        private int FindMinStickLength(List<int> stickLengths)
        {
            int currentMinStickLength = stickLengths[0];

            foreach (int stickLength in stickLengths)
            {
                if (stickLength < currentMinStickLength)
                    currentMinStickLength = stickLength;
            }

            return currentMinStickLength;
        }

        private List<int> PerformCut(List<int> stickLengths, int cutLength)
        {
           stickLengths.RemoveAll(length => (length - cutLength) <= 0);

           return stickLengths;
        }
    }
}
