using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace HackerRank.Tests.Implementation.SherlockAndSquares
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
            Solutions.Implementation.SherlockAndSquares.Solution sherlock = new Solutions.Implementation.SherlockAndSquares.Solution();

            // act
            int actualCount = sherlock.CountSquareIntegersInRange(min, max);

            // assert
            NUnit.Framework.Assert.AreEqual(actualCount, expectedCount);
        }
    }
}

