using System;
using System.Linq;

namespace HackerRank.Solutions.Warmup.DiagonalDifference
{
    public class Solution
    {
        public Solution()
        {
            Solve();
        }

        private void Solve()
        {
            int[,] matrix = ReadInMatrixFromConsole();
            PrintMatrix(matrix);
            Console.WriteLine(ComputeDiagonalDifference(matrix));

            Console.ReadKey();
        }

        private int[,] ReadInMatrixFromConsole()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int y = 0; y < n; y++)
            {
                int[] line = new int[n];
                line = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();

                for (int x = 0; x < n; x++)
                {
                    matrix[y, x] = line[x];
                }
            }

            return matrix;
        }

        private int ComputeDiagonalDifference(int[,] matrix)
        {
            int n = (int)Math.Sqrt(matrix.Length);
            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;
            int firstIndex = 0;
            int secondIndex = n - 1;

            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    if (x == firstIndex) firstDiagonalSum += matrix[y, firstIndex];
                    if (x == secondIndex) secondDiagonalSum += matrix[y, secondIndex];
                }

                firstIndex += 1;
                secondIndex -= 1;
            }

            return Math.Abs(firstDiagonalSum - secondDiagonalSum);
        }

        private void PrintMatrix(int[,] matrix)
        {
            int n = (int)Math.Sqrt(matrix.Length);

            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    Console.Write(string.Format("{0} ", matrix[y, x]));
                }

                Console.WriteLine();
            }
        }
    }
}
