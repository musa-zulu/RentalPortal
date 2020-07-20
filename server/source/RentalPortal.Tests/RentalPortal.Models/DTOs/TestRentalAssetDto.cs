using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using RentalPortal.Models.DTOs;
using System;

namespace RentalPortal.Tests.RentalPortal.Models.DTOs
{
    [TestFixture]
    public class TestRentalAssetDto
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new RentalAssetDto());
            //---------------Test Result -----------------------
        }

        [TestCase("RentalAssetDtoId", typeof(Guid))]
        [TestCase("Description", typeof(string))]
        [TestCase("Year", typeof(int))]
        [TestCase("Status", typeof(StatusDto))]
        [TestCase("ReplacementCost", typeof(decimal))]
        [TestCase("ImageUrl", typeof(string))]
        [TestCase("NumberOfItems", typeof(int))]
        [TestCase("RentalBranchDto", typeof(RentalBranchDto))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(RentalAssetDto);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}