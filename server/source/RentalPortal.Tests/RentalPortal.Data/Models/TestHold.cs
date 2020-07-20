using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using RentalPortal.Data.Models;
using System;

namespace RentalPortal.Tests.RentalPortal.Data.Models
{
    [TestFixture]
    public class TestHold
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new Hold());
            //---------------Test Result -----------------------
        }

        [TestCase("HoldId", typeof(Guid))]
        [TestCase("HoldPlaced", typeof(DateTime))]
        [TestCase("RentalAsset", typeof(RentalAsset))]
        [TestCase("RentalClubCard", typeof(RentalClubCard))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(Hold);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}