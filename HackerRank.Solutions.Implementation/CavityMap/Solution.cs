using System;

namespace HackerRank.Solutions.Implementation.CavityMap
{
    public class Solution
    {
        public void Solve()
        {
            int sizeOfMap = int.Parse(Console.ReadLine());
            int[,] map = GetInputMap(sizeOfMap);
            string[,] cavityMap = FindCavityMap(map, sizeOfMap);

            PrintCavityMap(cavityMap, sizeOfMap);

            Console.ReadKey();
        }

        public int[,] GetInputMap(int sizeOfMap)
        {
            int[,] map = new int[sizeOfMap, sizeOfMap];

            for (int rowIndex = 0; rowIndex < sizeOfMap; rowIndex++)
            {
                string mapDataRow = Console.ReadLine().Trim();

                for (int cellIndex = 0; cellIndex < sizeOfMap; cellIndex++)
                {
                    char charDepthOfCell = mapDataRow[cellIndex];

                    int depthOfCell = int.Parse(charDepthOfCell.ToString());

                    map[rowIndex, cellIndex] = depthOfCell;
                }
            }

            return map;
        }

        public void PrintCavityMap(string[,] cavityMap, int sizeOfMap)
        {
            for (int rowIndex = 0; rowIndex < sizeOfMap; rowIndex++)
            {
                for (int cellIndex = 0; cellIndex < sizeOfMap; cellIndex++)
                {
                    Console.Write(cavityMap[rowIndex, cellIndex]);

                    if (cellIndex == (sizeOfMap - 1))
                        Console.WriteLine();
                }
            }
        }

        public string[,] FindCavityMap(int[,] map, int sizeOfMap)
        {
            string[,] cavityMap = new string[sizeOfMap, sizeOfMap];

            for (int rowIndex = 0; rowIndex < sizeOfMap; rowIndex++)
            {
                for (int cellIndex = 0; cellIndex < sizeOfMap; cellIndex++)
                {
                    bool isOnEdge = ((rowIndex == 0) || (rowIndex == (sizeOfMap - 1)) || (cellIndex == 0) || (cellIndex == (sizeOfMap - 1)));

                    if (isOnEdge)
                    {
                        cavityMap[rowIndex, cellIndex] = map[rowIndex, cellIndex].ToString();
                    } 
                    else
                    {
                        int cellDepth = map[rowIndex, cellIndex];
                        int depthTop = map[rowIndex - 1, cellIndex];
                        int depthRight = map[rowIndex, cellIndex + 1];
                        int depthBottom = map[rowIndex + 1, cellIndex];
                        int depthLeft = map[rowIndex, cellIndex - 1];
                        bool isCavity = (cellDepth > depthTop) && (cellDepth > depthRight) && (cellDepth > depthBottom) && (cellDepth > depthLeft);
                        
                        if (isCavity)
                            cavityMap[rowIndex, cellIndex] = "X";
                        else
                            cavityMap[rowIndex, cellIndex] = map[rowIndex, cellIndex].ToString();
                    }                    
                }
            }

            return cavityMap;
        }
    }
}
