using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Collections.Generic;

namespace HackerRank.Tests.ServiceLane
{
    [TestClass]
    public class Tests
    {
        public IEnumerable<TestCaseData> TestCaseSourceData1()
        {
            yield return new TestCaseData(new int[8] { 2, 3, 1, 2, 3, 2, 3, 3 }, 0, 3, 1);
        }

        public IEnumerable<TestCaseData> TestCaseSourceData2()
        {
            yield return new TestCaseData(new int[8] { 2, 3, 1, 2, 3, 2, 3, 3 }, 4, 6, 2);
        }

        public IEnumerable<TestCaseData> TestCaseSourceData3()
        {
            yield return new TestCaseData(new int[8] { 2, 3, 1, 2, 3, 2, 3, 3 }, 6, 7, 3);
        }

        public IEnumerable<TestCaseData> TestCaseSourceData4()
        {
            yield return new TestCaseData(new int[8] { 2, 3, 1, 2, 3, 2, 3, 3 }, 3, 5, 2);
        }

        public IEnumerable<TestCaseData> TestCaseSourceData5()
        {
            yield return new TestCaseData(new int[8] { 2, 3, 1, 2, 3, 2, 3, 3 }, 0, 7, 1);
        }

        [TestMethod]
        [TestCaseSource("TestCaseSourceData1")]
        [TestCaseSource("TestCaseSourceData2")]
        [TestCaseSource("TestCaseSourceData3")]
        [TestCaseSource("TestCaseSourceData4")]
        [TestCaseSource("TestCaseSourceData5")]
        public void TestServiceLaneSolution(int[] widthArray, int entryIndex, int exitIndex, int expectedMaxWidth)
        {
            // Arrange
            Solutions.Implementation.ServiceLane.Solution solution = new Solutions.Implementation.ServiceLane.Solution(widthArray);

            //Act
            int actualMaxWidth = solution.FindLocalMinimum(entryIndex, exitIndex);

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedMaxWidth, actualMaxWidth);
        }
    }
}
