using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace HackerRank.Tests.Strings.Pangrams
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [TestCase("We promptly judged antique ivory buckles for the next prize", true)]
        [TestCase("We promptly judged antique ivory buckles for the prize", false)]
        public void TestPangramsSolution(string sentence, bool expected)
        {
            // Arrange
            Solutions.Strings.Pangrams.Solution solution = new Solutions.Strings.Pangrams.Solution(sentence);

            // Act
            bool actual = solution.IsPangram();

            // Assert
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }
    }
}
