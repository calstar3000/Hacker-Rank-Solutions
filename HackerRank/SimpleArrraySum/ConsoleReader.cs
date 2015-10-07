using HackerRank.SimpleArrraySum.Interfaces;
using System;
using System.Linq;

namespace HackerRank.SimpleArrraySum
{
    /// <summary>
    /// Console reader gets its input via the console
    /// Line 1: Size of the array
    /// Line 2: Space-separated list of integers in the array
    /// </summary>
    public class ConsoleReader : IInputReader
    {
        public int[] GetInput()
        {
            int[] numbers = new int[int.Parse(Console.ReadLine())];

            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray<int>();

            return numbers;
        }
    }
}
