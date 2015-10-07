using System;

namespace HackerRank.SongOfPi
{
    public class Solution
    {
        const string PI = "31415926535897932384626433833";

        public void Solve()
        {
            int numberOfTests = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfTests; i++)
            {
                string testCase = Console.ReadLine().Trim();

                if (IsSongOfPi(testCase))
                    Console.WriteLine("It's a pi song.");
                else
                    Console.WriteLine("It's not a pi song.");
            }

            Console.ReadKey();
        }

        public bool IsSongOfPi(string song)
        {
            string[] words = song.Split(' ');
            
            for (int wordIndex = 0; wordIndex < words.Length; wordIndex++)
            {
                string word = words[wordIndex];
                int wordLength = word.Length;
                char charAtPosition = PI[wordIndex];
                int charLength = int.Parse(charAtPosition.ToString());

                if (wordLength != charLength)
                    return false;
            }

            return true;
        }
    }
}
