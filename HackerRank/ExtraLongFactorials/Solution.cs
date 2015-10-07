using System;
using System.Numerics;

namespace HackerRank.ExtraLongFactorials
{
    public class Solution
    {
        public Solution()
        {
            Solve(int.Parse(Console.ReadLine()));
        }

        public Solution(int n)
        {
            Solve(n);
        }

        private void Solve(int n)
        {    
            BigInteger res = n;

            for (int i = n - 1; i > 0; i--)
            {
                res *= i;
            }

            Console.WriteLine(res);
        }
    }
}
