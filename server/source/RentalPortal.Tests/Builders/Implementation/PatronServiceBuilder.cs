using AutoMapper;
using NSubstitute;
using RentalPortal.Data;
using RentalPortal.Data.Models;
using RentalPortal.Service.Implementation;
using RentalPortal.Service.Interfaces;

namespace RentalPortal.Tests.Builders.Implementation
{
    public class PatronServiceBuilder
    {
        public PatronServiceBuilder()
        {
            Context = Substitute.For<IRentalPortalDbContext>();
            Mapper = Substitute.For<IMapper>();
            Paginator = Substitute.For<IPaginator<Patron>>();
        }

        private IRentalPortalDbContext Context;
        private IMapper Mapper;
        private IPaginator<Patron> Paginator;
        public PatronServiceBuilder WithMapper(IMapper mapper)
        {
            Mapper = mapper;
            return this;
        }

        public PatronServiceBuilder WithPaginator(IPaginator<Patron> paginator)
        {
            Paginator = paginator;
            return this;
        }

        public PatronServiceBuilder WithContext(IRentalPortalDbContext context)
        {
            Context = context;
            return this;
        }

        public PatronService Build()
        {
            return new PatronService(Context, Mapper, Paginator);
        }
    }
}
