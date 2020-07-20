using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using RentalPortal.Data.Models;
using System;

namespace RentalPortal.Tests.RentalPortal.Data.Models
{
    [TestFixture]
    public class TestPatron
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new Patron());
            //---------------Test Result -----------------------
        }

        [TestCase("PatronId", typeof(Guid))]
        [TestCase("FirstName", typeof(string))]
        [TestCase("LastName", typeof(string))]
        [TestCase("AddressId", typeof(Guid))]
        [TestCase("DateOfBirth", typeof(DateTime))]
        [TestCase("TelephoneId", typeof(Guid))]
        [TestCase("Gender", typeof(string))]
        [TestCase("RentalClubCard", typeof(RentalClubCard))]
        [TestCase("HomeRentalBranch", typeof(RentalBranch))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(Patron);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}