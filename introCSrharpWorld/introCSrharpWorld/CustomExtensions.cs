using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introCSrharpWorld
{
    public static class CustomExtensions
    {
        public static string ToTitleCase(this string value)
        {
            var wordArray = value.Split(' ');
            List<string> collection = new List<string>();
            foreach (var item in wordArray)
            {
                collection.Add(item.Substring(0, 1).ToUpper() + item.Substring(1).ToLower());
            }

            return string.Join(" ", collection);
        }

        public static bool IsWeekend(this DateTime value)
        {
            switch (value.DayOfWeek)
            {
                case DayOfWeek.Sunday:                                       
                case DayOfWeek.Saturday:
                    return true;
                default:
                    return false;
            }
        }
    }
}
