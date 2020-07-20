using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using RentalPortal.Data.Models;
using System;

namespace RentalPortal.Tests.RentalPortal.Data.Models
{
    [TestFixture]
    public class TestRentalAsset
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new RentalAsset());
            //---------------Test Result -----------------------
        }

        [TestCase("RentalAssetId", typeof(Guid))]
        [TestCase("Description", typeof(string))]
        [TestCase("Year", typeof(int))]
        [TestCase("Status", typeof(Status))]
        [TestCase("ReplacementCost", typeof(decimal))]
        [TestCase("ImageUrl", typeof(string))]
        [TestCase("NumberOfItems", typeof(int))]
        [TestCase("RentalBranch", typeof(RentalBranch))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(RentalAsset);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}