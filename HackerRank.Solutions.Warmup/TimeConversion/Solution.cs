using System;

namespace HackerRank.Solutions.Warmup.TimeConversion
{
    public class Solution
    {
        const string MIDNIGHT_1 = "12:00:00AM";
        const string MIDNIGHT_2 = "00:00:00";
        const string MIDDAY = "12:00:00";

        public Solution()
        {
            Solve();
        }

        private void Solve()
        {
            string time = Console.ReadLine();
            
            if (time == MIDNIGHT_1 || time == MIDNIGHT_2)
                Console.WriteLine(MIDNIGHT_2);
            else if (time == MIDDAY)
                Console.WriteLine(MIDDAY);
            else
            {
                string[] t = time.Split(':');

                int hh = int.Parse(t[0]);
                string amPm = t[2].Substring(2, 2);

                if (amPm == "PM" && hh != 12) 
                    t[0] = (hh + 12).ToString();
                
                if (amPm == "AM" && hh + 12 == 24)
                    t[0] = "00";

                Console.WriteLine(String.Join(":", t).Substring(0, 8));
            }
            
            Console.ReadKey();
        }
    }
}
