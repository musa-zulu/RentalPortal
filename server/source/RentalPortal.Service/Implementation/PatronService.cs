using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RentalPortal.Data;
using RentalPortal.Data.Models;
using RentalPortal.Models;
using RentalPortal.Models.DTOs;
using RentalPortal.Service.Interfaces;
using RentalPortal.Service.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RentalPortal.Service.Implementation
{
    public class PatronService : IPatronService
    {
        private readonly IRentalPortalDbContext _context;
        private readonly IMapper _mapper;
        private readonly IPaginator<Patron> _paginator;

        public PatronService(
            IRentalPortalDbContext context,
            IMapper mapper,
            IPaginator<Patron> paginator)
        {
            _context = context;
            _mapper = mapper;
            _paginator = paginator;
        }

        public async Task<ServiceResult<Guid>> Add(PatronDto patronDto)
        {
            var newPatron = _mapper.Map<Patron>(patronDto);
            await _context.Patrons.AddAsync(newPatron);
            await _context.SaveChangesAsync();
            return new ServiceResult<Guid>
            {
                Data = newPatron.PatronId,
                Error = null
            };
        }

        public async Task<ServiceResult<PatronDto>> Get(Guid patronId)
        {
            try
            {
                var patron = await _context.Patrons
                    .Include(a => a.TelephoneId)
                    .Include(a => a.AddressId)
                    .Include(a => a.RentalClubCard)
                    .Include(a => a.HomeRentalBranch)
                    .FirstOrDefaultAsync(a => a.PatronId == patronId);

                var patronDto = _mapper.Map<PatronDto>(patron);

                return new ServiceResult<PatronDto>
                {
                    Data = patronDto,
                    Error = null
                };
            }
            catch (Exception e)
            {
                return new ServiceResult<PatronDto>
                {
                    Data = null,
                    Error = new ServiceError
                    {
                        Message = e.Message,
                        Stacktrace = e.StackTrace
                    }
                };
            }
        }

        public async Task<PagedServiceResult<PatronDto>> GetAll(int page, int perPage)
        {
            var patrons = _context.Patrons;

            var pageOfPatrons = await _paginator
                .BuildPageResult(patrons, page, perPage, b => b.FirstName)
                .ToListAsync();

            var paginatedPatrons = _mapper.Map<List<PatronDto>>(pageOfPatrons);

            var paginationResult = new PaginationResult<PatronDto>
            {
                Results = paginatedPatrons,
                PerPage = perPage,
                PageNumber = page
            };

            return new PagedServiceResult<PatronDto>
            {
                Data = paginationResult,
                Error = null
            };
        }

        public Task<PagedServiceResult<RentalHistoryDto>> GetRentalHistory(Guid patronId, int page, int perPage)
        {
            throw new NotImplementedException();
        }

        public Task<PagedServiceResult<HoldDto>> GetHolds(Guid patronId, int page, int perPage)
        {
            throw new NotImplementedException();
        }

        public Task<PagedServiceResult<RentalDto>> GetRentals(Guid patronId, int page, int perPage)
        {
            throw new NotImplementedException();
        }
    }
}
