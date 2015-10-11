using System;

namespace HackerRank.Solutions.Implementation.SherlockAndSquares
{
    public class Solution
    {
        public void Solve()
        {
            int numberOfTests = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfTests; i++)
            {
                string[] range = Console.ReadLine().Trim().Split(' ');
                int min = int.Parse(range[0]);
                int max = int.Parse(range[1]);

                Console.WriteLine(CountSquareIntegersInRange(min, max));
            }

            Console.ReadKey();
        }

        public int CountSquareIntegersInRange(int min, int max)
        {
            double sqrtMin = Math.Sqrt(min);
            double sqrtMax = Math.Sqrt(max);
            int sqrtMinCeil = (int)Math.Ceiling(sqrtMin);
            int sqrtMaxFloor = (int)Math.Floor(sqrtMax);
            int diff = (sqrtMaxFloor - sqrtMinCeil) + 1;

            return diff;
        }
    }
}
