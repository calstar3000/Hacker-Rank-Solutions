using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace HackerRank.Tests.Implementation.MatrixRotation
{
    [TestClass]
    public class Tests
    {
        public IEnumerable<TestCaseData> TestCaseSourceData1()
        {
            yield return new TestCaseData(4, 4, 1,
                new Int64[4, 4] 
                {
                    { 2, 1, 5, 9 },
                    { 3, 7, 6, 13 },
                    { 4, 11, 10, 14 },
                    { 8, 12, 16, 15 }
                },
                new Int64[4, 4] 
                {
                    { 1, 5, 9, 13 },
                    { 2, 6, 10, 14 },
                    { 3, 7, 11, 15 },
                    { 4, 8, 12, 16 }
                });
        }

        public IEnumerable<TestCaseData> TestCaseSourceData2()
        {
            yield return new TestCaseData(5, 4, 7, 
                new Int64[4, 5] 
                {
                    { 28, 22, 16, 10, 4 },
                    { 27, 9, 8, 14, 3 },
                    { 26, 15, 21, 20, 2 },
                    { 25, 19, 13, 7, 1 }
                },
                new Int64[4, 5] 
                {
                    { 1, 7, 13, 19, 25 },
                    { 2, 8, 14, 20, 26 },
                    { 3, 9, 15, 21, 27 },
                    { 4, 10, 16, 22, 28 }
                });
        }

        public IEnumerable<TestCaseData> TestCaseSourceData3()
        {
            yield return new TestCaseData(2, 2, 1,
                new Int64[2, 2] 
                {
                    { 2, 1 },
                    { 4, 3 }
                },
                new Int64[2, 2] 
                {
                    { 1, 3 },
                    { 2, 4 }
                });
        }

        [TestMethod]
        [TestCaseSource("TestCaseSourceData1")]
        [TestCaseSource("TestCaseSourceData2")]
        [TestCaseSource("TestCaseSourceData3")]
        public void TestMatrixRotationSolution(Int64 rows, Int64 cols, Int64 rotations, Int64[,] expectedMatrix, Int64[,] actualMatrix)
        {
            // Arrange/Act
            actualMatrix = new Solutions.Implementation.MatrixRotation.Solution().GetRotatedMatrix(rows, cols, rotations, actualMatrix);

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedMatrix, actualMatrix);
        }
    }
}
