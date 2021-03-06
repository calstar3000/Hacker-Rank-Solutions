﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace HackerRank.Tests.Implementation.SongOfPi
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [TestCase("Can I have a large container of coffee right now", true)]
        [TestCase("Can I have a large container of tea right now", false)]
        [TestCase("Now I wish I could recollect pi Eureka cried the great inventor Christmas Pudding Christmas Pie Is the problems very center", true)]
        public void TestSongOfPiSolution(string testCase, bool expectedOutput)
        {
            // arrange
            Solutions.Implementation.SongOfPi.Solution song = new Solutions.Implementation.SongOfPi.Solution();

            // act
            bool isSongOfPi = song.IsSongOfPi(testCase);

            // assert
            NUnit.Framework.Assert.AreEqual(isSongOfPi, expectedOutput);
        }
    }
}

