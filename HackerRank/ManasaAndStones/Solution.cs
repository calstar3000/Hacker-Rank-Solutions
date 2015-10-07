using System;
using System.Collections.Generic;

namespace HackerRank.ManasaAndStones
{
    public class Solution
    {
        public void Solve()
        {
            int numberOfTestCases = int.Parse(Console.ReadLine());

            for (int testCaseIndex = 0; testCaseIndex < numberOfTestCases; testCaseIndex++)
            {
                SolveTestCase();
            }
        }

        public void SolveTestCase()
        {
            int numberOfStones = int.Parse(Console.ReadLine()) - 1;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            List<int> answers = new List<int>();

            for (int stoneIndex = 0; stoneIndex <= numberOfStones; stoneIndex++)
            {
                int aPart = (a * stoneIndex);
                int bPart = (b * (numberOfStones - stoneIndex));

                if (!answers.Contains(aPart + bPart)) 
                    answers.Add(aPart + bPart);
            }

            answers.Sort();

            Console.WriteLine(String.Join(" ", answers));
        }
    }
}
