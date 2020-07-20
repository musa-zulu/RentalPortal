using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using RentalPortal.Data.Models;
using System;

namespace RentalPortal.Tests.RentalPortal.Data.Models
{
    [TestFixture]
    public class TestBranchHours
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new BranchHours());
            //---------------Test Result -----------------------
        }

        [TestCase("BranchHoursId", typeof(Guid))]
        [TestCase("Branch", typeof(RentalBranch))]
        [TestCase("DayOfWeek", typeof(int))]
        [TestCase("OpeningTime", typeof(int))]
        [TestCase("ClosingTime", typeof(int))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(BranchHours);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}