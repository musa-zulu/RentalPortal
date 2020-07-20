using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using RentalPortal.Models.DTOs;
using System;
using System.Collections.Generic;

namespace RentalPortal.Tests.RentalPortal.Models.DTOs
{
    [TestFixture]
    public class TestRentalClubCardDto
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new RentalClubCardDto());
            //---------------Test Result -----------------------
        }

        [TestCase("RentalClubCardId", typeof(Guid))]
        [TestCase("RentalFee", typeof(decimal))]
        [TestCase("OverDueFee", typeof(decimal))]
        [TestCase("CardIssuedDate", typeof(DateTime))]
        [TestCase("RentalDto", typeof(IEnumerable<RentalDto>))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(RentalClubCardDto);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}