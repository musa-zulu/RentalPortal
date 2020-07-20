using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using RentalPortal.Data.Models;
using System;

namespace RentalPortal.Tests.RentalPortal.Data.Models
{
    [TestFixture]
    public class TestRental
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new Rental());
            //---------------Test Result -----------------------
        }

        [TestCase("RentalId", typeof(Guid))]
        [TestCase("RentalAsset", typeof(RentalAsset))]
        [TestCase("RentalClubCard", typeof(RentalClubCard))]
        [TestCase("RentedOutSince", typeof(DateTime))]
        [TestCase("RentedOutUntil", typeof(DateTime))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(Rental);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}