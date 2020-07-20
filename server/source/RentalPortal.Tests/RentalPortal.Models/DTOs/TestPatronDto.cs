using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using RentalPortal.Models.DTOs;
using System;

namespace RentalPortal.Tests.RentalPortal.Models.DTOs
{
    [TestFixture]
    public class TestPatronDto
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new PatronDto());
            //---------------Test Result -----------------------
        }

        [TestCase("PatrolDtoId", typeof(Guid))]
        [TestCase("FirstName", typeof(string))]
        [TestCase("LastName", typeof(string))]
        [TestCase("Gender", typeof(string))]
        [TestCase("AddressId", typeof(Guid))]
        [TestCase("TelephoneId", typeof(Guid))]
        [TestCase("DateOfBirth", typeof(DateTime))]
        [TestCase("RentalClubCardDto", typeof(RentalClubCardDto))]
        [TestCase("RentalBranchDto", typeof(RentalBranchDto))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(PatronDto);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}