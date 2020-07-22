using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using RentalPortal.Data.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentalPortal.Tests.RentalPortal.Data.Requests
{
    [TestFixture]
    class TestMailRequest
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new MailRequest());
            //---------------Test Result -----------------------
        }

        [TestCase("ToEmail", typeof(string))]
        [TestCase("Subject", typeof(string))]
        [TestCase("Body", typeof(string))]
        public void MailRequest_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(MailRequest);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }

        [TestCase("Mail", typeof(string))]
        [TestCase("DisplayName", typeof(string))]
        [TestCase("Password", typeof(string))]
        [TestCase("Host", typeof(string))]
        [TestCase("Port", typeof(int))]
        public void MailSettings_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(MailSettings);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}