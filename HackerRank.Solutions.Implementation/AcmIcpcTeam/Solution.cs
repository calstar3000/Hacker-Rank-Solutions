using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Solutions.Implementation.AcmIcpcTeam
{
    public class Solution
    {
        public void Solve()
        {
            int[] teamAndTopics = new int[2];
            teamAndTopics = Console.ReadLine().Split(' ').Select(int.Parse).ToArray<int>();
            int numberOfPeople = teamAndTopics[0];
            int numberOfTopics = teamAndTopics[1];

            List<int[]> people = GetPeopleTopicKnowledge(numberOfPeople);

            int currentMaxKnownTopics;
            int teamsThatKnownCurrentMax;
            GetMaxTopicsAndTeamsThatKnownMax(numberOfPeople, numberOfTopics, people, out currentMaxKnownTopics, out teamsThatKnownCurrentMax);

            Console.WriteLine(currentMaxKnownTopics);
            Console.WriteLine(teamsThatKnownCurrentMax);
        }

        /// <summary>
        /// For the list of people, get the max number of topics and two people know,
        /// and the max number of two-person teams that know the max number of topics.
        /// </summary>
        /// <param name="numberOfPeople">The number of people to create teams from</param>
        /// <param name="numberOfTopics">The number of topics each person can know</param>
        /// <param name="people">The list of people</param>
        /// <param name="currentMaxKnownTopics">The max number of topics and two-person team knows</param>
        /// <param name="teamsThatKnownCurrentMax">The number of two-person teams that know the max number of topics</param>
        public void GetMaxTopicsAndTeamsThatKnownMax(int numberOfPeople, int numberOfTopics, List<int[]> people, out int currentMaxKnownTopics, out int teamsThatKnownCurrentMax)
        {
            currentMaxKnownTopics = 0;
            teamsThatKnownCurrentMax = 0;
            for (int personAIndex = 0; personAIndex < numberOfPeople; personAIndex++)
            {
                for (int personBIndex = personAIndex + 1; personBIndex < numberOfPeople; personBIndex++)
                {
                    int currentKnownTopics = GetKnownTopics(people[personAIndex], people[personBIndex], numberOfTopics);

                    if (currentKnownTopics > currentMaxKnownTopics)
                    {
                        currentMaxKnownTopics = currentKnownTopics;
                        teamsThatKnownCurrentMax = 1;
                    }
                    else if (currentKnownTopics == currentMaxKnownTopics)
                    {
                        teamsThatKnownCurrentMax++;
                    }
                }
            }
        }

        /// <summary>
        /// Get the list of people and their topic knowledge from the input data. 
        /// Each person is represented by a binary array of topic knowledge.
        /// A '1' denotes knowledge of the topic. A '0' denotes no knowledge.
        /// </summary>
        /// <param name="numberOfPeople">The number of people to add to the list</param>
        /// <returns>The list of people and their knowledge of each topic</returns>
        private List<int[]> GetPeopleTopicKnowledge(int numberOfPeople)
        {
            List<int[]> people = new List<int[]>();

            for (int personIndex = 0; personIndex < numberOfPeople; personIndex++)
            {
                string topicKnowledgeString = Console.ReadLine();
                int[] personTopicKnowledge = new int[topicKnowledgeString.Length];
                personTopicKnowledge = topicKnowledgeString.ToCharArray().Select(c => int.Parse(c.ToString())).ToArray<int>();
                people.Add(personTopicKnowledge);
            }
            return people;
        }

        /// <summary>
        /// Get the number of known topics across two teams
        /// </summary>
        /// <param name="teamA">The first team</param>
        /// <param name="teamB">The second team</param>
        /// <param name="numberOfTopics">The number of topics</param>
        /// <returns>The number of known topics across each team</returns>
        private int GetKnownTopics(int[] teamA, int[] teamB, int numberOfTopics)
        {
            int topicCount = 0;

            for (int topicIndex = 0; topicIndex < numberOfTopics; topicIndex++)
            {
                if (teamA[topicIndex] == 1 || teamB[topicIndex] == 1)
                {
                    topicCount++;
                }
            }

            return topicCount;
        }
    }
}
