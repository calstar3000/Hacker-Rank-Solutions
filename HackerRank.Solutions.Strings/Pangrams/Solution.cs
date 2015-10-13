using System;
using System.Linq;

namespace HackerRank.Solutions.Strings.Pangrams
{
    public class Solution
    {
        const int LOWERLIMIT = 97;
        const int UPPERLIMIT = 122;

        public int[] RequiredCodes { get; set; }
        public int[] ProvidedCodes { get; set; }

        public Solution(string sentence)
        {
            int[] requiredCodes = new int[26];

            for (int i = LOWERLIMIT; i <= UPPERLIMIT; i++)
            {
                requiredCodes[i - LOWERLIMIT] = i;
            }

            RequiredCodes = requiredCodes;
            ProvidedCodes = sentence.Replace(" ", "").ToLower().ToCharArray().Select(c => (int)c).ToArray<int>();
        }

        public bool IsPangram()
        {
            return (RequiredCodes.All(i => ProvidedCodes.Contains(i)));
        }
    }
}
