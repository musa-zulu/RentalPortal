using System;

namespace RentalPortal.Data.Models
{
    public class EntityBase
    {
        public string AddedBy { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateLastModified { get; set; }
    }
}
