using RentalPortal.Data.Models;
using System;
using System.Collections.Generic;

namespace RentalPortal.Service.Helpers
{
    public static class DataHelpers
    {
        public static IEnumerable<string> HumanizeBusinessHours(IEnumerable<BranchHours> branchHours)
        {
            var hours = new List<string>();

            foreach (var time in branchHours)
            {
                var day = HumanizeDayOfWeek(time.DayOfWeek);
                var openTime = HumanizeTime(time.OpeningTime);
                var closeTime = HumanizeTime(time.ClosingTime);
                var timeEntry = $"{day} {openTime} to {closeTime}";
                hours.Add(timeEntry);
            }

            return hours;
        }

        private static string HumanizeDayOfWeek(int number)
            => Enum.GetName(typeof(DayOfWeek), number);

        private static string HumanizeTime(int time)
            => TimeSpan.FromHours(time).ToString("hh':'mm");
    }
}