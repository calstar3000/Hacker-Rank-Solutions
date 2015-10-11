using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace HackerRank.Tests.Implementation.UtopianTree
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
            Solutions.Implementation.UtopianTree.Solution tree = new Solutions.Implementation.UtopianTree.Solution();

            // act
            int estimatedHeight = tree.CalculateHeight(numberOfCycles);

            // assert
            NUnit.Framework.Assert.AreEqual(estimatedHeight, expectedHeight);
        }
    }
}

