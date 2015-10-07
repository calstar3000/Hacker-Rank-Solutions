using System;

namespace HackerRank.Sherlock
{
    public class Solution
    {
        public Solution()
        {
            Solve();
        }

        private void Solve()
        {
            int numberOfTests = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfTests; i++)
            {
                int testCase = int.Parse(Console.ReadLine());

                FindDecentNumber(testCase);
            }
            
            Console.ReadKey();
        }

        private void FindDecentNumber(int n)
        {
            int pivot = FindPivot(n);

            if (pivot < 0)
                Console.Write("-1");
            else
            {
                int repeat = (pivot / 3);

                while (repeat-- > 0)
                    Console.Write("555");

                repeat = ((n - pivot) / 5);

                while (repeat-- > 0)
                    Console.Write("33333");
            }

            Console.WriteLine();
        }

        private int FindPivot(int n)
        {
            while (n > 0)
            {
                if (n % 3 == 0)
                    break;

                n -= 5;
            }

            return n;
        }
    }
}
