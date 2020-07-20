using System.Collections.Generic;

namespace RentalPortal.Models
{
    public class PaginationResult<T>
    {
        public List<T> Results { get; set; }
        public int PerPage { get; set; }
        public int PageNumber { get; set; }
    }
}
