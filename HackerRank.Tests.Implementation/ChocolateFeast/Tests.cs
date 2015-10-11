using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace HackerRank.Tests.Implementation.ChocolateFeast
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [TestCase(10, 2, 5, 6)]
        [TestCase(12, 4, 4, 3)]
        [TestCase(6, 2, 2, 5)]
        public void TestChocolateFeastSolution(int totalDollars, int pricePerChocolate, int wrappersPerChocolate, int expectedResult)
        {
            // arrange
            Solutions.Implementation.ChocolateFeast.Solution feast = new Solutions.Implementation.ChocolateFeast.Solution();

            // act
            int count = feast.FindNumberOfChocolates(totalDollars, pricePerChocolate, wrappersPerChocolate);

            // assert
            NUnit.Framework.Assert.AreEqual(count, expectedResult);
        }
    }
}

