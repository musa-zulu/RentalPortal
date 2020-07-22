using RentalPortal.Models;

namespace RentalPortal.Service.Models
{
    public class ServiceResult<T>
    {
        public T Data { get; set; }
        public ServiceError Error { get; set; }
    }

    public class PagedServiceResult<T>
    {
        public PaginationResult<T> Data { get; set; }
        public ServiceError Error { get; set; }
    }
}