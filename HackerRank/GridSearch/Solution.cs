using System;

namespace HackerRank.GridSearch
{
    public class Solution
    {
        public void Solve()
        {
            int numberOfTests = int.Parse(Console.ReadLine());

            for (int testCase = 0; testCase < numberOfTests; testCase++)
            {
                int[] dimensions = GetDimensions();
                int gridRows = dimensions[0];
                int gridColumns = dimensions[1];
                int[,] grid = GetInputGrid(gridRows, gridColumns);

                dimensions = GetDimensions();
                int patternRows = dimensions[0];
                int patternColumns = dimensions[1];
                int[,] pattern = GetInputGrid(patternRows, patternColumns);

                bool patternInGrid = CheckMatch(grid, gridRows, gridColumns, pattern, patternRows, patternColumns);

                Console.WriteLine(patternInGrid ? "YES" : "NO");
            }

            Console.ReadKey();
        }

        public int[] GetDimensions()
        {
            int[] res = new int[2];
            string[] dimensions = Console.ReadLine().Split(' ');
            int rows = int.Parse(dimensions[0]);
            int columns = int.Parse(dimensions[1]);

            res[0] = rows;
            res[1] = columns;

            return res;
        }

        public int[,] GetInputGrid(int rows, int columns)
        {
            int[,] grid = new int[rows, columns];

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                string rowData = Console.ReadLine();

                for (int colIndex = 0; colIndex < rowData.Length; colIndex++)
                {
                    string cell = rowData[colIndex].ToString();

                    grid[rowIndex, colIndex] = int.Parse(cell);
                }
            }

            return grid;
        }

        public bool CheckMatch(int[,] grid, int gridRows, int gridColumns, int[,] pattern, int patternRows, int patternColumns)
        {
            int gridX = 0;
            int gridY = 0;

            // while pattern isn't beyond bottom right-hand corner of grid
            while ((gridX + patternColumns <= gridColumns) && (gridY + patternRows <= gridRows))
            {
                bool stopLooking = false;

                for (int curX = 0; curX < patternColumns; curX++)
                {
                    for (int curY = 0; curY < patternRows; curY++)
                    {
                        int patternVal = pattern[curY, curX];
                        int gridVal = grid[curY + gridY, curX + gridX];

                        if (patternVal != gridVal)
                        {
                            stopLooking = true;
                            break;
                        }
                        else
                        {

                        }

                        if (curX == (patternColumns - 1) && curY == (patternRows - 1))
                            return true;
                    }

                    if (stopLooking)
                        break;
                }

                gridX++; // move right

                if (gridX + patternColumns > gridColumns) // beyond end of a row
                {
                    gridX = 0;
                    gridY++; // move down
                }
            }

            return false;
        }

        public void PrintGrid(int[,] grid, int rows, int columns)
        {
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                for (int cellIndex = 0; cellIndex < columns; cellIndex++)
                {
                    Console.Write(grid[rowIndex, cellIndex]);

                    if (cellIndex == (columns - 1))
                        Console.WriteLine();
                }
            }
        }
    }
}
