using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using RentalPortal.Data.Models;
using System;
using System.Collections.Generic;

namespace RentalPortal.Tests.RentalPortal.Data.Models
{
    [TestFixture]
    public class TestRentalClubCard
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new RentalClubCard());
            //---------------Test Result -----------------------
        }

        [TestCase("RentalClubCardId", typeof(Guid))]
        [TestCase("RentalFee", typeof(decimal))]
        [TestCase("OverDueFee", typeof(decimal))]
        [TestCase("CardIssuedDate", typeof(DateTime))]
        [TestCase("Rentals", typeof(IEnumerable<Rental>))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(RentalClubCard);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}