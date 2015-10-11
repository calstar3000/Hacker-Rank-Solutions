using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace HackerRank.MatrixRotation
{
    public class Solution
    {
        public void Solve()
        {
            Int64[] dimensions = Console.ReadLine().Split(' ').Select(Int64.Parse).ToArray<Int64>();
            Int64 rows = dimensions[0];
            Int64 cols = dimensions[1];
            Int64 rotations = dimensions[2];
            Int64[,] matrix = GetMatrix(rows, cols);

            matrix = GetRotatedMatrix(rows, cols, rotations, matrix);

            PrintMatrix(rows, cols, matrix);        
        }

        public Int64[,] GetMatrix(Int64 rows, Int64 cols)
        {
            Int64[,] matrix = new Int64[cols, rows];

            for (Int64 rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                Int64[] rowData = new Int64[cols];
                string input = Console.ReadLine();
                rowData = input.Split(' ').Select(Int64.Parse).ToArray<Int64>();

                for (Int64 colIndex = 0; colIndex < cols; colIndex++)
                {
                    matrix[colIndex, rowIndex] = rowData[colIndex];
                }
            }

            return matrix;
        }

        /// <summary>
        /// Rotate the matrix into its final position. The perimeter of progressively smaller bounding rectangles 
        /// are each rotated the minimum number of rotations to achive the result (we only need to rotate a given
        /// rectangle up to one full rotation). We stop rotating once we've finished with the inner-most (smallest)
        /// bounding rectangle, whereby one of its dimensions will be of size 2.
        /// </summary>
        /// <param name="rows">The number of rows in the matrix</param>
        /// <param name="cols">The number of columns in the matrix</param>
        /// <param name="rotations">The number of rotations to execute</param>
        /// <param name="matrix">The matrix to rotate</param>
        /// <returns>The rotated matrix</returns>
        public Int64[,] GetRotatedMatrix(Int64 rows, Int64 cols, Int64 rotations, Int64[,] matrix)
        {
            Int64 minX = 0;
            Int64 maxX = cols;
            Int64 minY = 0;
            Int64 maxY = rows;
            Int64 adjustedRotations = rotations;

            while (AtLeastOneDimensionIsGreaterThanOne(minX, maxX, minY, maxY))
            {
                Int64 fullRotation = GetBoundingRectanglePerimeter(minX, maxX, minY, maxY);

                // we only need to bother with up to one full rotation
                if (rotations > fullRotation)
                {
                    adjustedRotations = rotations % fullRotation;
                }

                // rotate the bounding rectangle for each adjusted rotation
                for (Int64 rotationIndex = 0; rotationIndex < adjustedRotations; rotationIndex++)
                {
                    RotateMatrixBoundingRectangle(minX, maxX, minY, maxY, ref matrix);
                }

                // move down a row and across a column
                minX++;
                maxX--;
                minY++;
                maxY--;
            }

            return matrix;
        }

        public bool AtLeastOneDimensionIsGreaterThanOne(Int64 minX, Int64 maxX, Int64 minY, Int64 maxY)
        {
            return (maxX - minX > 1) && (maxY - minY > 1);
        }

        public Int64 GetBoundingRectanglePerimeter(Int64 minX, Int64 maxX, Int64 minY, Int64 maxY)
        {
            return ((2 * (maxY - minY)) + (2 * (maxX - minX)) - 4);
        }

        public enum DirectionType
        {
            Down = 1,
            Right = 2,
            Up = 3,
            Left = 4
        }

        /// <summary>
        /// Execute one anti-clockwise rotation of a bounding rectangle within the matrix eg. the very outer most rows and columns.
        /// </summary>
        /// <param name="minX">The minimum x coordinate value allowed</param>
        /// <param name="maxX">The maxium x coordinate value allowed</param>
        /// <param name="minY">The minimum y coordinate value allowed</param>
        /// <param name="maxY">The maxium y coordinate value allowed</param>
        /// <param name="matrix">The matrix to rotate</param>
        public void RotateMatrixBoundingRectangle(Int64 minX, Int64 maxX, Int64 minY, Int64 maxY, ref Int64[,] matrix)
        {
            DirectionType currentDirection = DirectionType.Down;
            Int64 x = minX;
            Int64 y = minY; 
            Int64 nextX = minX;
            Int64 nextY = minY;
            Int64 currentVal = matrix[x, y];
            Int64 nextVal;

            while (nextX >= minX)
            {
                // move down until we hit the bottom left, then move right
                if (currentDirection == DirectionType.Down)
                {
                    nextX = x;
                    nextY = y + 1;

                    if (nextY >= maxY) // bottom left
                    {
                        currentDirection = DirectionType.Right;
                    }
                }

                // move right until we hit the bottom right, then move up
                if (currentDirection == DirectionType.Right)
                {
                    nextX = x + 1;
                    nextY = y;

                    if (nextX >= maxX) // bottom right
                    {
                        currentDirection = DirectionType.Up;
                    }
                }

                // move up until we hit the top right, then move left
                if (currentDirection == DirectionType.Up)
                {
                    nextX = x;
                    nextY = y - 1;

                    if (nextY < minY) // top right
                    {
                        currentDirection = DirectionType.Left;
                    }
                }

                // move left until we hit the top left
                if (currentDirection == DirectionType.Left)
                {
                    nextX = x - 1;
                    nextY = y;
                }

                // only shift if haven't gone past the top left
                if (nextX >= minX)
                {
                    // save out the next value we're about to overwrite
                    nextVal = matrix[nextX, nextY];

                    // shift the value
                    matrix[nextX, nextY] = currentVal;

                    x = nextX;
                    y = nextY;
                    currentVal = nextVal;
                }
            }
        }

        /// <summary>
        /// Print the matrix out to the console
        /// </summary>
        /// <param name="rows">The number of rows in the matrix</param>
        /// <param name="cols">The number of columns in the matrix</param>
        /// <param name="matrix">The matrix to print</param>
        public void PrintMatrix(Int64 rows, Int64 cols, Int64[,] matrix)
        {
            for (Int64 rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                for (Int64 colIndex = 0; colIndex < cols; colIndex++)
                {
                    Console.Write(matrix[colIndex, rowIndex] + (colIndex == (cols - 1) ? "\n" : " "));
                }
            }
        }
    }
}
