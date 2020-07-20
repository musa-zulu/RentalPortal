using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using RentalPortal.Models.DTOs;
using System;

namespace RentalPortal.Tests.RentalPortal.Models.DTOs
{
    [TestFixture]
    public class TestRentalBranchDto
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new RentalBranchDto());
            //---------------Test Result -----------------------
        }

        [TestCase("RentalBranchDtoId", typeof(Guid))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(RentalBranchDto);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}