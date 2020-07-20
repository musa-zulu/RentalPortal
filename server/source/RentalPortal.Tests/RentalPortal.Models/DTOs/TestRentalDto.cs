using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using RentalPortal.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentalPortal.Tests.RentalPortal.Models.DTOs
{
    [TestFixture]
    public class TestRentalDto
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new RentalDto());
            //---------------Test Result -----------------------
        }

        [TestCase("RentalId", typeof(Guid))]
        [TestCase("RentalAssetDto", typeof(RentalAssetDto))]
        [TestCase("RentalClubCardDto", typeof(RentalClubCardDto))]
        [TestCase("RentedOutSince", typeof(DateTime))]
        [TestCase("RentedOutUntil", typeof(DateTime))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(RentalDto);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}