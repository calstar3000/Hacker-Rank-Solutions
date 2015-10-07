using System;
using System.Linq;

namespace HackerRank.Staircase
{
    public class Solution
    {
        public Solution()
        {
            Solve();
        }

        private void Solve()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(String.Concat(Enumerable.Repeat(" ", (n - i))) + String.Concat(Enumerable.Repeat("#", i)));
            }
            
            Console.ReadKey();
        }
    }
}
