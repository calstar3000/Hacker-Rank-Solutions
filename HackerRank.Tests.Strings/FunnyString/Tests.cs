using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace HackerRank.Tests.Strings.FunnyString
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [TestCase("acxz", true)]
        [TestCase("bcxz", false)]
        public void TestFunnyStringSolution(string text, bool expected)
        {
            // Act
            Solutions.Strings.FunnyString.Solution solution = new Solutions.Strings.FunnyString.Solution(text);

            // Arrange
            bool actual = solution.IsFunnyString();

            // Assert
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }
    }
}
