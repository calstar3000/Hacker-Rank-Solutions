using System;

namespace HackerRank.Solutions.Implementation.LonelyInteger
{
    public class Solution
    {
        public void Solve()
        {
            // my implementation of template code
            //string[] array = new string[int.Parse(Console.ReadLine())];
            //array = Console.ReadLine().Split(' ');

            // template code
            int res;

            int _a_size = Convert.ToInt32(Console.ReadLine());
            int[] _a = new int[_a_size];
            int _a_item;
            String move = Console.ReadLine();
            String[] move_split = move.Split(' ');
            for (int _a_i = 0; _a_i < move_split.Length; _a_i++)
            {
                _a_item = Convert.ToInt32(move_split[_a_i]);
                _a[_a_i] = _a_item;
            }

            res = lonelyinteger(_a);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        static int lonelyinteger(int[] a)
        {
            int res = 0;

            for (int i = 0; i < a.Length; i++)
            {
                res ^= a[i];
            }

            return res;

            //for (int i = 0; i < a.Length; i++)
            //{
            //    bool isLonely = true;

            //    for (int j = 0; (j < a.Length && isLonely); j++)
            //    {
            //        if (a[i] == a[j] && i != j) isLonely = false;
            //    }

            //    if (isLonely) return a[i];
            //}

            //return 0;
        }
    }
}
