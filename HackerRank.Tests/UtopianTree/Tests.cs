using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace HackerRank.Tests.UtopianTree
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(4, 7)]
        public void TestUtopianTreeSolution(int numberOfCycles, int expectedHeight)
        {
            // arrange
            HackerRank.UtopianTree.Solution tree = new HackerRank.UtopianTree.Solution();

            // act
            int estimatedHeight = tree.CalculateHeight(numberOfCycles);

            // assert
            NUnit.Framework.Assert.AreEqual(estimatedHeight, expectedHeight);
        }
    }
}

