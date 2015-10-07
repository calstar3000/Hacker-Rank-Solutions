using System;

namespace HackerRank.AngryProfessor
{
    public class Solution
    {
        public Solution()
        {
            Solve();
        }

        private void Solve()
        {
            int numberOfTestCases = int.Parse(Console.ReadLine());

            for (int testCaseIndex = 0; testCaseIndex < numberOfTestCases; testCaseIndex++)
            {
                string[] testCaseInfo = Console.ReadLine().Split(' ');
                string[] testCase = Console.ReadLine().Split(' ');
                int numberOfStudents = int.Parse(testCaseInfo[0]);
                int minimumStudentsOnTime = int.Parse(testCaseInfo[1]);
                int onTimeStudents = 0;

                for (int studentIndex = 0; studentIndex < numberOfStudents; studentIndex++)
                {
                    if (int.Parse(testCase[studentIndex]) <= 0) onTimeStudents += 1;
                }

                Console.WriteLine(onTimeStudents < minimumStudentsOnTime ? "YES" : "NO");
            }
            
            Console.ReadKey();
        }
    }
}
