using System;

namespace HackerRank.Solutions.Implementation.UtopianTree
{
    public class Solution
    {
        public void Solve(int numberOfCycles)
        {
            Console.WriteLine(CalculateHeight(numberOfCycles));
        }

        public void Solve()
        {
            int numberOfTests = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfTests; i++)
            {
                int testCase = int.Parse(Console.ReadLine());

                Console.WriteLine(CalculateHeight(testCase));
            }
            
            Console.ReadKey();
        }

        /// <summary>
        /// Find the height of a utopian tree, given a number of cycles.
        /// A utopian tree is planted in Spring at a height of 1m.
        /// It doubles its height in Spring (after one cycle).
        /// It adds 1m to its height in Winter.
        /// </summary>
        /// <param name="numberOfCycles">The number of cycles that have passed</param>
        /// <returns>The height of the tree after n cycles</returns>
        public int CalculateHeight(int numberOfCycles)
        {
            int height = 1;
            bool isSpring = true;

            for (int cycleIndex = 0; cycleIndex < numberOfCycles; cycleIndex++)
            {
                if (isSpring)
                    height *= 2;
                else
                    height += 1;

                isSpring = !isSpring;
            }

            return height;
        }
    }
}
