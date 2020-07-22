using RentalPortal.Models.DTOs;
using RentalPortal.Service.Models;
using System;
using System.Threading.Tasks;

namespace RentalPortal.Service.Interfaces
{
    public interface IPatronService
    {
        Task<PagedServiceResult<PatronDto>> GetAll(int page, int perPage);
        Task<PagedServiceResult<RentalHistoryDto>> GetRentalHistory(Guid patronId, int page, int perPage);
        Task<PagedServiceResult<HoldDto>> GetHolds(Guid patronId, int page, int perPage);
        Task<PagedServiceResult<RentalDto>> GetRentals(Guid patronId, int page, int perPage);

        Task<ServiceResult<PatronDto>> Get(Guid patronId);
        Task<ServiceResult<Guid>> Add(PatronDto patronDto);
    }
}