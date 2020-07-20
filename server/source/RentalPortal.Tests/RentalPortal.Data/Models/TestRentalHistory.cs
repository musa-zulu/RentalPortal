using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using RentalPortal.Data.Models;
using System;
using System.Collections.Generic;

namespace RentalPortal.Tests.RentalPortal.Data.Models
{
    [TestFixture]
    public class TestRentalHistory
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new RentalHistory());
            //---------------Test Result -----------------------
        }

        [TestCase("RentalHistoryId", typeof(Guid))]
        [TestCase("CheckedOut", typeof(DateTime))]
        [TestCase("CheckedIn", typeof(DateTime?))]
        [TestCase("RentalAsset", typeof(RentalAsset))]
        [TestCase("RentalClubCard", typeof(RentalClubCard))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(RentalHistory);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}