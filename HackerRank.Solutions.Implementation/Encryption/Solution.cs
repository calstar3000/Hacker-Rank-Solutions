using System;

namespace HackerRank.Solutions.Implementation.Encryption
{
    public class Solution
    {
        /// <summary>
        /// Solve the problem using command line input
        /// </summary>
        public void Solve()
        {
            string decryptedText = Console.ReadLine();
            
            Console.WriteLine(GetSolution(decryptedText));
        }

        /// <summary>
        /// Given some decrypted text, encrypt it using an encryption grid
        /// </summary>
        /// <param name="decryptedText">The text to encrypt</param>
        /// <returns>The encrypted text</returns>
        public string GetSolution(string decryptedText)
        {
            int textLength = decryptedText.Length;
            int rows = (int)Math.Ceiling(Math.Sqrt((double)textLength));
            int columns = (int)Math.Ceiling(Math.Sqrt((double)textLength));
            char[,] grid = GetEncryptionGrid(decryptedText, textLength, rows, columns);

            return GetEncryptedText(grid, rows, columns);
        }

        /// <summary>
        /// Get the encryption grid from the decrypted text. 
        /// Rows and columns are the square root of the text length.
        /// Text characters are placed in the grid row by row, then read column by column to encrypt.
        /// </summary>
        /// <param name="decryptedText">The text to encrpyt</param>
        /// <param name="textLength">The lenght of the text</param>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="columns">The number of columns in the grid</param>
        /// <returns>The character grid used for encryption</returns>
        public char[,] GetEncryptionGrid(string decryptedText, int textLength, int rows, int columns)
        {
            char[,] grid = new char[rows, columns];

            int charIndex = 0;
            bool gridFilled = false;
            for (int colIndex = 0; colIndex < columns && !gridFilled; colIndex++)
            {
                for (int rowIndex = 0; rowIndex < rows && !gridFilled; rowIndex++)
                {
                    grid[rowIndex, colIndex] = decryptedText[charIndex];
                    charIndex++;
                    gridFilled = (charIndex == textLength);
                }
            }
            
            return grid;
        }

        /// <summary>
        /// Get the encrypted text from the encryption grid. 
        /// Characters are read from the grid by traversing each column, adding a space at the end
        /// of each column. Empty cells are ignored.
        /// </summary>
        /// <param name="grid">The grid of the decrypted text's characters</param>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="columns">The number of columns in the grid</param>
        /// <returns>The encrypted text</returns>
        public string GetEncryptedText(char[,] grid, int rows, int columns)
        {
            string encryptedText = "";

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                for (int colIndex = 0; colIndex < columns; colIndex++)
                {
                    if (grid[rowIndex, colIndex] != '\0') // don't add empty cell
                    {
                        encryptedText += grid[rowIndex, colIndex];
                    }
                }

                encryptedText += " ";
            }

            return encryptedText.Trim();
        }
    }
}
