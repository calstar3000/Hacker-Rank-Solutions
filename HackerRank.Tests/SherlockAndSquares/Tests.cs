using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace HackerRank.Tests.SherlockAndSquares
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [TestCase(3, 9, 2)]
        [TestCase(17, 24, 0)]
        public void TestSherlockAndSquaresSolution(int min, int max, int expectedCount)
        {
            // arrange
            HackerRank.SherlockAndSquares.Solution sherlock = new HackerRank.SherlockAndSquares.Solution();

            // act
            int actualCount = sherlock.CountSquareIntegersInRange(min, max);

            // assert
            NUnit.Framework.Assert.AreEqual(actualCount, expectedCount);
        }
    }
}

