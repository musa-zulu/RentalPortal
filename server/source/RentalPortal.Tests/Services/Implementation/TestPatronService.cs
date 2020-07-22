using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MockQueryable.NSubstitute;
using NSubstitute;
using NUnit.Framework;
using RentalPortal.Data;
using RentalPortal.Data.Models;
using RentalPortal.Models.DTOs;
using RentalPortal.Service.Implementation;
using RentalPortal.Service.Interfaces;
using RentalPortal.Tests.Builders.Implementation;
using RentalPortal.Tests.Common.Builders.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalPortal.Tests.Services.Implementation
{
    [TestFixture]
    public class TestPatronService
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------s
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new PatronService(Substitute.For<IRentalPortalDbContext>(),
                Substitute.For<IMapper>(), Substitute.For<IPaginator<Patron>>()));
            //---------------Test Result -----------------------
        }

        [Test]
        public async Task Add_GivenValidPatronDto_ShouldCallMappingEngine()
        {
            //---------------Set up test pack-------------------
            ResolveMapper(out PatronDto patronDto, out IMapper mapper, out Patron patron);
            var patronService = CreatePatronServiceBuilder()
                .WithMapper(mapper)
                .Build();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            _ = await patronService.Add(patronDto);
            //---------------Test Result -----------------------
            mapper.Received(1).Map<Patron>(patronDto);
        }

        [Test]
        public async Task Add_GivenValidPatronDto_ShouldAddAPatron()
        {
            //---------------Set up test pack-------------------
            ResolveMapper(out PatronDto patronDto, out IMapper mapper, out Patron patron);
            var patronService = CreatePatronServiceBuilder()
                .WithMapper(mapper)
                .Build();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var result = await patronService.Add(patronDto);
            //---------------Test Result -----------------------
            Assert.AreEqual(null, result.Error);
            Assert.AreEqual(patronDto.PatrolDtoId, result.Data);
        }

        [Test]
        public void Add_GivenValidPatronDto_ShouldCallSaveChanges()
        {
            //---------------Set up test pack-------------------
            ResolveMapper(out PatronDto patronDto, out IMapper mapper, out Patron patron);
            var context = Substitute.For<IRentalPortalDbContext>();          

            var patronService = CreatePatronServiceBuilder()
                .WithContext(context)
                .WithMapper(mapper)
                .Build();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            _ = patronService.Add(patronDto);
            //---------------Test Result -----------------------
            context.Received(1).SaveChangesAsync();
        }

        [Test]
        public async Task Get_GivenInValidPatronId_ShouldThrowException()
        {
            //---------------Set up test pack-------------------
            var patronService = CreatePatronServiceBuilder()
                .Build();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var result = await patronService.Get(Guid.Empty);
            //---------------Test Result -----------------------
            Assert.AreEqual(null, result.Data);
            Assert.IsNotNull(result.Error.Message);
        }

        [Test]
        public async Task Get_GivenPatronIdOfAnExistingPatron_ShouldCallMappingEngine()
        {
            //---------------Set up test pack-------------------
            ResolveMapper(out PatronDto patronDto, out IMapper mapper, out Patron patron);           
            var patrons = new List<Patron>
            {
                patron
            };
            var mock = patrons.AsQueryable().BuildMockDbSet();
            var context = Substitute.For<IRentalPortalDbContext>();
            context.Patrons.Returns(mock);

            var patronService = CreatePatronServiceBuilder()
                .WithContext(context)
                .WithMapper(mapper)
                .Build();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            _ = await patronService.Get(patron.PatronId);
            //---------------Test Result -----------------------
            mapper.Map<PatronDto>(patron);
        }

        [Test]
        public async Task Get_GivenPatronIdOfAnExistingPatron_ShouldReturnPatron()
        {
            //---------------Set up test pack-------------------
            ResolveMapper(out PatronDto patronDto, out IMapper mapper, out Patron patron);
            var patrons = new List<Patron>
            {
                patron
            };
            var mock = patrons.AsQueryable().BuildMockDbSet();

            var context = Substitute.For<IRentalPortalDbContext>();
            context.Patrons.Returns(mock);

            mapper.Map<PatronDto>(patron).Returns(patronDto);

            var patronService = CreatePatronServiceBuilder()
                .WithContext(context)
                .WithMapper(mapper)
                .Build();

            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var result = await patronService.Get(patron.PatronId);
            //---------------Test Result -----------------------
            Assert.IsNull(result.Error);
            Assert.AreEqual(patronDto, result.Data);
        }

        private static void ResolveMapper(out PatronDto patronDto, out IMapper mapper, out Patron patron)
        {
            patronDto = PatronDtoBuilder.BuildRandom();
            patron = new Patron
            {
                PatronId = patronDto.PatrolDtoId
            };
            mapper = Substitute.For<IMapper>();
            mapper.Map<Patron>(patronDto).Returns(patron);
        }

        private static PatronServiceBuilder CreatePatronServiceBuilder()
        {
            return new PatronServiceBuilder();
        }        
    }
}
