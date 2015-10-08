using System;

namespace HackerRank.TimeInWords
{
    public class Solution
    {
        static string[] HOURS = new string[13] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve" };
        static string[] MINUTES = new string[30] { 
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
            "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen",
            "twenty", "twenty one", "twenty two", "twenty three", "twenty four", "twenty five", "twenty six", "twenty seven", "twenty eight", "twenty nine"
        };

        public void Solve()
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            Console.WriteLine(GetTimeInWords(hour, minute));
        }

        /// <summary>
        /// Convert an hour and minute to the time in sentence form
        /// </summary>
        /// <param name="hour">The hour of the day</param>
        /// <param name="minute">The minutes past the hour</param>
        /// <returns>The time in sentence form</returns>
        public string GetTimeInWords(int hour, int minute)
        {
            string timeInWords = "";

            if (minute == 0)
            {
                timeInWords = string.Format("{0} o' clock", HOURS[hour]);
            }
            else if (minute == 1)
            {
                timeInWords = string.Format("one minute past {0}", HOURS[hour]);
            }
            else if (minute == 15)
            {
                timeInWords = string.Format("quarter past {0}", HOURS[hour]);
            }
            else if (minute < 30)
            {
                timeInWords = string.Format("{0} minutes past {1}", MINUTES[minute], HOURS[hour]);
            }
            else if (minute == 30)
            {
                timeInWords = string.Format("half past {0}", HOURS[hour]);
            }
            else if (minute < 45 || (minute > 45 && minute < 59))
            {
                timeInWords = string.Format("{0} minutes to {1}", MINUTES[60 - minute], HOURS[hour + 1]);
            }
            else if (minute == 45)
            {
                timeInWords = string.Format("quarter to {0}", HOURS[hour + 1]);
            }
            else if (minute == 59)
            {
                timeInWords = string.Format("one minute to {0}", HOURS[hour + 1]);
            }

            return timeInWords;
        }
    }
}
