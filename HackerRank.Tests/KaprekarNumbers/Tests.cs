using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace HackerRank.Tests.KaprekarNumbers
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [TestCase(1, true)]
        [TestCase(9, true)]
        [TestCase(45, true)]
        [TestCase(55, true)]
        [TestCase(99, true)]
        [TestCase(77778, true)]
        public void TestKaprekarNumbersSolution(int number, bool expected)
        {
            // Arrange/Act
            bool actual = new HackerRank.KaprekarNumbers.Solution().IsKaprekarNumber(number);

            // Assert
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }
    }
}
