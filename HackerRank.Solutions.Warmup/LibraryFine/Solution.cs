using System;

namespace HackerRank.Solutions.Warmup.LibraryFine
{
    public class Solution
    {
        public Solution()
        {
            Solve();
        }

        private void Solve()
        {
            string[] actual = Console.ReadLine().Split(' ');
            string[] expected = Console.ReadLine().Split(' ');

            int aD = int.Parse(actual[0]);
            int aM = int.Parse(actual[1]);
            int aY = int.Parse(actual[2]);
            int eD = int.Parse(expected[0]);
            int eM = int.Parse(expected[1]);
            int eY = int.Parse(expected[2]);

            if (aY < eY) // year before
            {
                Console.WriteLine(0);
            }
            else if (aY == eY) // same year
            {
                if (aM < eM) // month before
                {
                    Console.WriteLine(0);
                }
                else if (aM == eM) // same month
                {
                    if (aD <= eD)
                    {
                        Console.WriteLine(0); // same day or before
                    }
                    else
                    {
                        Console.WriteLine(15 * (aD - eD)); // day after
                    }
                }
                else // month after
                {
                    Console.WriteLine(500 * (aM - eM));
                }
            }
            else // year after
            {
                Console.WriteLine(10000);
            }

            Console.ReadKey();
        }
    }
}
