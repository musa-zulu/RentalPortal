using NUnit.Framework;
using RentalPortal.Data.Models;
using RentalPortal.Service.Helpers;
using RentalPortal.Tests.Common.Builders.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RentalPortal.Tests.Services.Helpers
{
    [TestFixture]
    public class TestDataHelpers
    {
        [Test]
        public void HumanizeBusinessHours_GivenAnEmptyList_ShouldReturnAnEmptyList()
        {
            //---------------Set up test pack-------------------
            var branchHours = new List<BranchHours>();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var result = DataHelpers.HumanizeBusinessHours(branchHours);
            //---------------Test Result -----------------------
            Assert.AreEqual(0, result.Count());
        }

        [Test]
        public void HumanizeBusinessHours_GivenAListWithOneItem_ShouldReturnThatItem()
        {
            //---------------Set up test pack-------------------
            var branchHour = BranchHoursBuilder.BuildRandom();
            var branchHours = new List<BranchHours>
            {
                branchHour
            };
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var result = DataHelpers.HumanizeBusinessHours(branchHours);
            //---------------Test Result -----------------------
            Assert.AreEqual(1, result.Count());
            CollectionAssert.Contains(result, $"{HumanizeDayOfWeek(branchHour.DayOfWeek)} {HumanizeTime(branchHour.OpeningTime)} to {HumanizeTime(branchHour.ClosingTime)}");
        }

        [Test]
        public void HumanizeBusinessHours_GivenAListWithTwoItems_ShouldReturnThoseItems()
        {
            //---------------Set up test pack-------------------
            var branchHour1 = BranchHoursBuilder.BuildRandom();
            var branchHour2 = BranchHoursBuilder.BuildRandom();
            var branchHours = new List<BranchHours>
            {
                branchHour1,
                branchHour2
            };
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var result = DataHelpers.HumanizeBusinessHours(branchHours);
            //---------------Test Result -----------------------
            Assert.AreEqual(2, result.Count());
            CollectionAssert.Contains(result, $"{HumanizeDayOfWeek(branchHour1.DayOfWeek)} {HumanizeTime(branchHour1.OpeningTime)} to {HumanizeTime(branchHour1.ClosingTime)}");
            CollectionAssert.Contains(result, $"{HumanizeDayOfWeek(branchHour2.DayOfWeek)} {HumanizeTime(branchHour2.OpeningTime)} to {HumanizeTime(branchHour2.ClosingTime)}");
        }

        [Test]
        public void HumanizeBusinessHours_GivenAListWithMoreThen2Items_ShouldReturnThoseItems()
        {
            //---------------Set up test pack-------------------
            var branchHour1 = BranchHoursBuilder.BuildRandom();
            var branchHour2 = BranchHoursBuilder.BuildRandom();
            var branchHour3 = BranchHoursBuilder.BuildRandom();
            var branchHours = new List<BranchHours>
            {
                branchHour1,
                branchHour2,
                branchHour3
            };
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var result = DataHelpers.HumanizeBusinessHours(branchHours);
            //---------------Test Result -----------------------
            Assert.AreEqual(3, result.Count());
            CollectionAssert.Contains(result, $"{HumanizeDayOfWeek(branchHour1.DayOfWeek)} {HumanizeTime(branchHour1.OpeningTime)} to {HumanizeTime(branchHour1.ClosingTime)}");
            CollectionAssert.Contains(result, $"{HumanizeDayOfWeek(branchHour2.DayOfWeek)} {HumanizeTime(branchHour2.OpeningTime)} to {HumanizeTime(branchHour2.ClosingTime)}");
            CollectionAssert.Contains(result, $"{HumanizeDayOfWeek(branchHour3.DayOfWeek)} {HumanizeTime(branchHour3.OpeningTime)} to {HumanizeTime(branchHour3.ClosingTime)}");
        }

        private static string HumanizeDayOfWeek(int number)
          => Enum.GetName(typeof(DayOfWeek), number);

        private static string HumanizeTime(int time)
            => TimeSpan.FromHours(time).ToString("hh':'mm");
    }
}
