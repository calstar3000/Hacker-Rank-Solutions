using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace HackerRank.Tests.Implementation.FindDigits
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [TestCase("12", 2)]
        [TestCase("1012", 3)]
        public void TestFindDigitsSolution(string testCase, int expectedOutput)
        {
            // arrange
            Solutions.Implementation.FindDigits.Solution fd = new Solutions.Implementation.FindDigits.Solution();

            // act
            int count = fd.CountDigitsThatDivideExactly(testCase);

            // assert
            NUnit.Framework.Assert.AreEqual(count, expectedOutput);
        }
    }
}

