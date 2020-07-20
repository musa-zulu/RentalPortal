using System;

namespace RentalPortal.Data.Models
{
    public class Status
    {
        public Guid StatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
