using HackerRank.Solutions.Warmup.SimpleArrraySum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace HackerRank.Tests.Warmup.SimpleArraySum
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [TestCase(new int[1] { 0 }, 0)]
        [TestCase(new int[3] { 1, 2, 3 }, 6)]
        [TestCase(new int[6] { 1, 2, 3, 4, 10, 11 }, 31)]
        public void TestSimpleArraySumSolution(int[] numbers, int expected)
        {
            // Arrange
            int actual;
            
            // Act
            actual = new Solutions.Warmup.SimpleArrraySum.Solution(new ArrayReader(numbers)).Solve();

            // Assert
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }
    }
}
