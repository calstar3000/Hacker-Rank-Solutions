using System;
using System.Linq;

namespace HackerRank.Solutions.Warmup.PlusMinus
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
            ComputePlusMinusCountOfArrayElements(array);

            Console.ReadKey();
        }

        private int[] ReadInArrayFromConsole()
        {
            int[] array = new int[int.Parse(Console.ReadLine())];
            array = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();

            return array;
        }

        private void ComputePlusMinusCountOfArrayElements(int[] array)
        {
            double total = array.Length;
            double positiveCount = 0;
            double negativeCount = 0;
            double zeroCount = 0;

            foreach (int num in array)
            {
                if (num > 0) positiveCount += 1;
                else if (num < 0) negativeCount += 1;
                else zeroCount += 1;
            }

            Console.WriteLine(positiveCount / total);
            Console.WriteLine(negativeCount / total);
            Console.WriteLine(zeroCount / total);
        }
    }
}
