using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Solutions.Implementation.KaprekarNumbers
{
    public class Solution
    {
        public void Solve()
        {
            int lowerBound = int.Parse(Console.ReadLine());
            int upperBound = int.Parse(Console.ReadLine());
            int kaprekarNumberCount = 0;

            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (IsKaprekarNumber(i))
                {
                    Console.Write(i + " ");
                    kaprekarNumberCount += 1;
                }
            }

            if (kaprekarNumberCount <= 0)
            {
                Console.WriteLine("INVALID RANGE");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Determine if a number is a kaprekar number. If you create two new numbers from the digits 
        /// of the number's square split in half, do they add to equal the original number
        /// </summary>
        /// <param name="num">The original number</param>
        /// <returns>Whether the number is a kaprekar number or not</returns>
        public bool IsKaprekarNumber(Int64 num)
        {
            Int64 square = (num * num);
            List<int> digits = GetListOfDigitsFromNumber(square);

            int numberOfDigits = digits.Count();
            int middleIndex = (int)Math.Floor((decimal)(numberOfDigits / 2));

            int[] arrLeft = new int[middleIndex];
            int[] arrRight = new int[numberOfDigits - middleIndex];

            arrLeft = digits.GetRange(0, middleIndex).ToArray<int>();
            arrRight = digits.GetRange(middleIndex, numberOfDigits - middleIndex).ToArray<int>();

            int left = 0;
            if (arrLeft.Length > 0) left = int.Parse(string.Join("", arrLeft));

            int right = 0;
            if (arrRight.Length > 0) right = int.Parse(string.Join("", arrRight));

            return (left + right == num);
        }

        private List<int> GetListOfDigitsFromNumber(Int64 number)
        {
            List<int> digits = new List<int>();
            while (number > 0)
            {
                digits.Add((int)(number % 10));
                number /= 10;
            }
            digits.Reverse();

            return digits;
        }
    }
}
