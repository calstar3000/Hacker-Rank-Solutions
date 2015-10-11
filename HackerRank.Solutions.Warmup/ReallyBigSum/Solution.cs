using System;
using System.Linq;

namespace HackerRank.Solutions.Warmup.ReallyBigSum
{
    public class Solution
    {
        public Solution()
        {
            Solve();
        }

        private void Solve()
        {
            int[] array = ReadInArrayFromConsole();
            long res = ComputeSumOfArrayElements(array);

            Console.WriteLine(res);
            Console.ReadKey();
        }

        private int[] ReadInArrayFromConsole()
        {
            int[] array = new int[int.Parse(Console.ReadLine())];
            array = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();

            return array;
        }

        private long ComputeSumOfArrayElements(int[] array)
        {
            long res = 0;

            foreach (int num in array)
            {
                res += num;
            }

            return res;
        }
    }
}
