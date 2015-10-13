using System;

namespace HackerRank.Solutions.Strings
{
    public class Base
    {
        public static void Main()
        {
            //new FunnyString.Solution().Solve();
            Console.WriteLine(new Pangrams.Solution(Console.ReadLine()).IsPangram() ? "pangram" : "not pangram");
            Console.ReadKey();
        }
    }
}
