using AutoMapper;
using RentalPortal.Data.Models;
using RentalPortal.Models.DTOs;

namespace RentalPortal.Infrastructure.Mappings
{
    public class PatronProfile : Profile
    {
        public PatronProfile()
        {
            CreateMap<Patron, PatronDto>().ReverseMap();
        }
    }
}
