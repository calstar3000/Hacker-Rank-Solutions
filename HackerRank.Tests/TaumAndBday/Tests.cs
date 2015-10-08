using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace HackerRank.Tests.TaumAndBday
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [TestCase(10, 10, 1, 1, 1, 20)]
        [TestCase(5, 9, 2, 3, 4, 37)]
        [TestCase(3, 6, 9, 1, 1, 12)]
        [TestCase(7, 7, 4, 2, 1, 35)]
        [TestCase(3, 3, 1, 9, 2, 12)]
        [TestCase(27984, 1402, 619246, 615589, 247954, 18192035842)]
        [TestCase(95677, 39394, 86983, 311224, 588538, 20582630747)]
        [TestCase(68406, 12718, 532909, 315341, 201009, 39331944938)]
        [TestCase(15242, 95521, 712721, 628729, 396706, 70920116291)]
        [TestCase(21988, 67781, 645748, 353796, 333199, 38179353700)]
        [TestCase(22952, 80129, 502975, 175136, 340236, 25577754744)]
        [TestCase(38577, 3120, 541637, 657823, 735060, 22947138309)]
        [TestCase(5943, 69851, 674453, 392925, 381074, 31454478354)]
        [TestCase(62990, 61330, 310144, 312251, 93023, 38686324390)]
        [TestCase(11152, 43844, 788543, 223872, 972572, 18609275504)]
        public void TestTaumAndBdaySolution(Int64 blackQuota, Int64 whiteQuota, Int64 blackCost, Int64 whiteCost, Int64 conversionCost, Int64 expected)
        {
            // Arrange/Act
            Int64 actual = new HackerRank.TaumAndBday.Solution().ComputeTotalCost(blackQuota, whiteQuota, blackCost, whiteCost, conversionCost);

            // Assert
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }
    }
}
