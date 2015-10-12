using System;
using System.Linq;

namespace HackerRank.Solutions.Strings.FunnyString
{
    public class Solution
    {
        public string Text { get; set; }
        public string Reverse { get; set; }

        public Solution() { }
        public Solution(string text)
        {
            Text = text;
            Reverse = string.Join("", text.Reverse());
        }

        public void Solve()
        {
            int numberOfTestCases = int.Parse(Console.ReadLine());

            for (int testCaseIndex = 0; testCaseIndex < numberOfTestCases; testCaseIndex++)
            {
                Text = Console.ReadLine();
                Reverse = string.Join("", Text.Reverse());
                Console.WriteLine(IsFunnyString() ? "Funny" : "Not Funny");
            }
        }

        /// <summary>
        /// A string is funny if the absolute value of the ASCI code of each character minus the previous character
        /// is the same as result of the same operation on the corresponding characters in the same string reversed
        /// </summary>
        /// <returns>True if the string is funny, or false if it's not funny</returns>
        public bool IsFunnyString()
        {
            for (int charIndex = 1; charIndex < Text.Length; charIndex++)
            {
                if (Math.Abs((int)Text[charIndex] - (int)Text[charIndex - 1]) !=
                    Math.Abs((int)Reverse[charIndex] - (int)Reverse[charIndex - 1]))
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}
