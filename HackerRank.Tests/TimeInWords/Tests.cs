using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace HackerRank.Tests.TimeInWords
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [TestCase(5, 0, "five o' clock")]
        [TestCase(5, 1, "one minute past five")]
        [TestCase(5, 10, "ten minutes past five")]
        [TestCase(5, 15, "quarter past five")]
        [TestCase(5, 30, "half past five")]
        [TestCase(5, 40, "twenty minutes to six")]
        [TestCase(5, 45, "quarter to six")]
        [TestCase(5, 55, "five minutes to six")]
        [TestCase(5, 59, "one minute to six")]
        public void TestTimeInWordsSolution(int hour, int minute, string expected)
        {
            // Arrange/Act
            string actual = new HackerRank.TimeInWords.Solution().GetTimeInWords(hour, minute);

            // Assert
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }
    }
}
