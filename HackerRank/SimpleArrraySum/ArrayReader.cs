using HackerRank.SimpleArrraySum.Interfaces;

namespace HackerRank.SimpleArrraySum
{
    /// <summary>
    /// An array reader gets its input via the array that's passed to its constructor
    /// </summary>
    public class ArrayReader : IInputReader
    {
        public int[] Numbers { get; set; }

        public ArrayReader(int[] numbers)
        {
            Numbers = numbers;
        }

        public int[] GetInput()
        {
            return Numbers;
        }
    }
}
