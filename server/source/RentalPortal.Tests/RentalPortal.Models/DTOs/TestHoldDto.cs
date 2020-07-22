using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using RentalPortal.Models.DTOs;
using System;

namespace RentalPortal.Tests.RentalPortal.Models.DTOs
{
    [TestFixture]
    public class TestHoldDto
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new HoldDto());
            //---------------Test Result -----------------------
        }

        [TestCase("HoldId", typeof(Guid))]
        [TestCase("HoldPlaced", typeof(DateTime))]
        [TestCase("RentalAssetDto", typeof(RentalAssetDto))]
        [TestCase("RentalClubCardDto", typeof(RentalClubCardDto))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(HoldDto);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}