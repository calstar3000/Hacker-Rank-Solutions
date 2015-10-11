using HackerRank.Solutions.Warmup.SimpleArrraySum.Interfaces;
using System.Linq;

namespace HackerRank.Solutions.Warmup.SimpleArrraySum
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
