using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using RentalPortal.Models.DTOs;
using System;

namespace RentalPortal.Tests.RentalPortal.Models.DTOs
{
    [TestFixture]
    public class TestRentalHistoryDto
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new RentalHistoryDto());
            //---------------Test Result -----------------------
        }

        [TestCase("RentalHistoryDtoId", typeof(Guid))]
        [TestCase("RentalAssetDto", typeof(RentalAssetDto))]
        [TestCase("RentalClubCardDto", typeof(RentalClubCardDto))]
        [TestCase("CheckedOut", typeof(DateTime))]
        [TestCase("CheckedIn", typeof(DateTime?))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(RentalHistoryDto);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}