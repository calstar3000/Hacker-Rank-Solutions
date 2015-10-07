using System;
using System.Text;

namespace HackerRank.CaesarCipher
{
    public class Solution
    {
        public Solution()
        {
            Solve();
        }

        private void Solve()
        {
            Console.ReadLine();
            string s = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());
            StringBuilder res = new StringBuilder();

            foreach(char c in s)
            {
                char l = c;

                if (char.IsLetter(c))
                {
                    for (int i = 0; i < k; i++)
                    {
                        if (l == 'z') l = 'a';
                        else if (l == 'Z') l = 'A';
                        else l++;
                    }
                }
                
                res.Append(l);
            }

            Console.WriteLine(res.ToString());
            Console.ReadKey();
        }
    }
}
