using System;

namespace HackerRank.FindDigits
{
    public class Solution
    {
        public void Solve()
        {
            int numberOfTests = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfTests; i++)
            {
                string testCase = Console.ReadLine().Trim();

                Console.WriteLine(CountDigitsThatDivideExactly(testCase));
            }

            Console.ReadKey();
        }

        public int CountDigitsThatDivideExactly(string testCase)
        {
            int divisor = int.Parse(testCase);
            int count = 0;

            foreach (char character in testCase)
            {
                int numerator = int.Parse(character.ToString());

                if (numerator > 0 && DividesExactly(numerator, divisor))
                    count += 1;
            }

            return count;
        }

        public bool DividesExactly(int numerator, int divisor)
        {
            return (divisor % numerator == 0);
        }
    }
}
