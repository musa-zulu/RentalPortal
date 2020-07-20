using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using RentalPortal.Data.Models;
using System;
using System.Collections.Generic;

namespace RentalPortal.Tests.RentalPortal.Data.Models
{
    [TestFixture]
    public class TestRentalBranch
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new RentalBranch());
            //---------------Test Result -----------------------
        }

        [TestCase("RentalBranchId", typeof(Guid))]
        [TestCase("BranchName", typeof(string))]
        [TestCase("Description", typeof(string))]
        [TestCase("ImageUrl", typeof(string))]
        [TestCase("OpenDate", typeof(DateTime))]
        [TestCase("AddressId", typeof(Guid))]
        [TestCase("TelephoneId", typeof(Guid))]
        [TestCase("Patrons", typeof(IEnumerable<Patron>))]
        [TestCase("RentalAssets", typeof(IEnumerable<RentalAsset>))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(RentalBranch);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}