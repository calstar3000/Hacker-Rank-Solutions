using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Collections.Generic;

namespace HackerRank.Tests.Implementation.AcmIcpcTeam
{
    [TestClass]
    public class Tests
    {
        public IEnumerable<TestCaseData> TestCaseSourceData()
        {
            yield return new TestCaseData(4, 5, new List<int[]>() 
            {
                new int[5] { 1, 0, 1, 0, 1 },
                new int[5] { 1, 1, 1, 0, 0 },
                new int[5] { 1, 1, 0, 1, 0 },
                new int[5] { 0, 0, 1, 0, 1 }
            });
        }

        [TestMethod]
        [TestCaseSource("TestCaseSourceData")]
        public void TestAcmIcpcTeamSolution(int numberOfPeople, int numberOfTopics, List<int[]> people)
        {
            // arrange
            HackerRank.Solutions.Implementation.AcmIcpcTeam.Solution solution = new HackerRank.Solutions.Implementation.AcmIcpcTeam.Solution();
            int currentMaxKnownTopics;
            int teamsThatKnownCurrentMax;

            // act
            solution.GetMaxTopicsAndTeamsThatKnownMax(numberOfPeople, numberOfTopics, people, out currentMaxKnownTopics, out teamsThatKnownCurrentMax);

            // assert
            NUnit.Framework.Assert.AreEqual(currentMaxKnownTopics, 5);
            NUnit.Framework.Assert.AreEqual(teamsThatKnownCurrentMax, 2);
        }
    }
}
