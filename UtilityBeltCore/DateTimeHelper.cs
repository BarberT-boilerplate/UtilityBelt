using System;

namespace UtilityBeltCore
{
    public static class DateTimeHelper
    {
        public static DateTime GetNextWeekday(DateTime start)
        {
            DateTime nextWeekday = start.AddDays(((((int)start.DayOfWeek % 5) + ((int)start.DayOfWeek > 5 ? 0 : 1)) - (int)start.DayOfWeek + 7) % 7);
            return nextWeekday;
        }
    }
}
