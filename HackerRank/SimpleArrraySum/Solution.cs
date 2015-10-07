using HackerRank.SimpleArrraySum.Interfaces;
using System.Linq;

namespace HackerRank.SimpleArrraySum
{
    public class Solution
    {
        public int[] Numbers { get; set; }

        public Solution(IInputReader reader)
        {
            Numbers = reader.GetInput();
        }

        public int Solve()
        {
            return Numbers.Sum();
        }
    }
}
