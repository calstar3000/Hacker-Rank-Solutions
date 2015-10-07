using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace HackerRank.Tests.FindDigits
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
            HackerRank.FindDigits.Solution fd = new HackerRank.FindDigits.Solution();

            // act
            int count = fd.CountDigitsThatDivideExactly(testCase);

            // assert
            NUnit.Framework.Assert.AreEqual(count, expectedOutput);
        }
    }
}

